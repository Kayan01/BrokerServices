using BrokrService.Helpers;
using BrokrService.Models;
using BrokrService.Service.Contracts;
using BrokrService.Utils.Logger;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace BrokrService.Service
{
    public class ClientService : IClientService
    {
        private readonly HttpClient _httpClient;
        private readonly ILoggerManager _logger;

        public ClientService(HttpClient httpClient, ILoggerManager logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }
        public async Task<string> ClientSetUp(ClientDto client)
        {
            try
            {
            var insured = "http://192.168.10.59:8080/insured";
            string clientNo = null;
            var json = JsonConvert.SerializeObject(client);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(insured, content);
            
                if (response.IsSuccessStatusCode)
                {
                    clientNo = await response.Content.ReadAsStringAsync();
                    return clientNo;
                }
                else
                {
                    _logger.LogInfo($"{DateTime.Now}: ClientRequestFailed: REQUEST => {JsonConvert.SerializeObject(content)}: RESPONSE: => {response.ReasonPhrase} {response.RequestMessage}");
                    throw new RestException(HttpStatusCode.BadRequest, "There was an error while creating the profile please try again.");
                }     
            }
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync("An error occured: " + ex.Message);
                _logger.LogError($"{DateTime.Now}: {nameof(ClientSetUp)} ERROR => {ex.Message} {ex.StackTrace}");
                throw new RestException(HttpStatusCode.InternalServerError, "An error occured while processing your request. Please, try again");
            }
            
        }
        
    }
}
