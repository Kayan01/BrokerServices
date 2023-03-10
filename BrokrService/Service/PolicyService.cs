using BrokrService.Helpers;
using BrokrService.Models;
using BrokrService.Service.Contracts;
using BrokrService.Utils.Logger;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Server.IIS.Core;
using Newtonsoft.Json;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using Attribute = BrokrService.Models.Attribute;

namespace BrokrService.Service
{
    
    public class PolicyService : IPolicyService
    {
        private readonly HttpClient _httpClient;
        private readonly IClientService _clientService;
        private readonly ILoggerManager _logger;
        public PolicyService(HttpClient httpClient, IClientService clientService, ILoggerManager logger)
        {
            _httpClient = httpClient;
            _clientService = clientService;
            _logger = logger;
        }

        public async Task<ResponseModel> PolicySetUpAsync(PolicyDto policy)
        {
            try
            {
                var policyUrl = "http://192.168.10.59:8080/policy";
            string policyNumber = null;


            var clientno = _clientService.ClientSetUp(policy.clientDto);
            policy.InsuredNumber = await clientno;
            string json = JsonConvert.SerializeObject(policy);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(policyUrl, content);
           
                if (!response.IsSuccessStatusCode)
                    throw new RestException(HttpStatusCode.BadRequest, "There's an issue getting the policy number");

                policyNumber = await response.Content.ReadAsStringAsync();
                var hashedPolicyNumber = HashPolicyNumber(policyNumber);
                return new ResponseModel
                {
                    IsSucceed = true,
                    PolicyID = policyNumber,
                    PolicyUniqueID = hashedPolicyNumber,
                    DataGroup = new List<DataGroup>
                    {
                        new DataGroup
                        {
                            GroupName = "PolicyData",
                            GroupTag = 1,
                            AttArray = new List<Attribute>
                            {
                                new Attribute
                                {
                                    Name = "HashedPolicyNumber",
                                    Value = hashedPolicyNumber
                                }
                            }
                        }
                    },
                    ErrCodes = new List<string>(),
                    ErrMsgs = new List<string>(),
                    WarnCodes = new List<string>(),
                    WarnMsgs = new List<string>()
                };

            }
            catch (Exception ex)
            {
                _logger.LogError($"{DateTime.Now}: {nameof(PolicySetUpAsync)} ERROR => {ex.Message} {ex.StackTrace}");
                throw new RestException(HttpStatusCode.InternalServerError, "An error occured while processing your request. Please, try again");
            }

        }

            private string HashPolicyNumber(string policyNumber)
            {
                SHA256 sha256Hash = SHA256.Create();
                byte[] data = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(policyNumber));
                StringBuilder stringBuilder = new StringBuilder();
                for(int i = 0; i < data.Length; i++)
                {
                    stringBuilder.Append(data[i].ToString("x2"));
                }
                string hashedPolicyNumber = stringBuilder.ToString();
                sha256Hash.Dispose();
                return hashedPolicyNumber;
            }
    }
       
}
