using BrokrService.Models;
using BrokrService.Service;
using BrokrService.Service.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Attribute = BrokrService.Models.Attribute;

namespace BrokrService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolicySetUpController : ControllerBase
    {
        private readonly IPolicyService _policyService;
        public PolicySetUpController(IPolicyService policyService)
        {
            _policyService = policyService;
        }

        [HttpPost("policy")]
        [ProducesResponseType(typeof(ResponseModel), StatusCodes.Status200OK)]  
        public async Task<IActionResult>CoinsurePolicy([FromBody] PolicyDto policyDto)
        {
            var response = await _policyService.PolicySetUpAsync(policyDto);
            return Ok(response);
        }
    }
}


//    try
//            {
//                // Hash policy data
//                var hashedPolicyData = HashPolicyData(policyDto);

//    // Call endpoint in existing application to set up client
//    // Return client ID
//    var clientId = await SetupClientAsync(policyDto.ClientDto, hashedPolicyData);

//    // Use client ID to set up policy
//    // Return policy number
//    var policyNumber = await SetupPolicyAsync(clientId, policyDto);

//    // Hash policy number
//    var hashedPolicyNumber = HashPolicyNumber(policyNumber);

//    // Return response object
//    var response = new ResponseCoinsurePolicy
//    {
//        IsSucceed = true,
//        PolicyID = policyNumber,
//        PolicyUniqueID = hashedPolicyNumber,
//        DataGroup = new List<DataGroup>
//            {
//                new DataGroup
//                {
//                    GroupName = "PolicyData",
//                    GroupTag = 1,
//                    GroupCount = 1,
//                    AttArray = new List<Attribute>
//                    {
//                        new Attribute
//                        {
//                            Name = "HashedPolicyData",
//                            Value = hashedPolicyData
//                        },
//                        new Attribute
//                        {
//                            Name = "HashedPolicyNumber",
//                            Value = hashedPolicyNumber
//                        }
//                    }
//                }
//            },
//        ErrCodes = new List<string>(),
//        ErrMsgs = new List<string>(),
//        WarnCodes = new List<string>(),
//        WarnMsgs = new List<string>()
//    };

//                return Ok(response);
//}
//            catch (Exception ex)
//{
//    // Handle exception and return appropriate HTTP status code
//    return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
//}

//}

//[ProducesResponseType(StatusCodes.Status400BadRequest)]
//[ProducesResponseType(StatusCodes.Status500InternalServerError)]
