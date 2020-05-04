using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Viam.SalesForce.API.Business.Chain;
using Viam.SalesForce.API.Controllers.Groups;
using Viam.SalesForce.API.Model.Chain;
using Viam.SalesForce.API.Model.Configuration;

namespace Viam.SalesForce.API.Controllers.Chain
{
    /// <summary>
    /// Controller to chain management
    /// </summary>
    [Route("api/chain")]
    [ApiController]
    [Authorize]
    public class ChainController : Controller
    {
        /// <summary>
        /// Log management object
        /// </summary>
        private readonly ILogger<ChainController> _logger;

        /// <summary>
        /// Configuration object
        /// </summary>
        private readonly IOptions<ConfigurationModel> _configurations;

        /// <summary>
        /// Business layer object
        /// </summary>
        private ChainBusiness _chainBusiness = null;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="configuration">configuration object<</param>
        /// <param name="logger">loggin object</param>
        public ChainController(IOptions<ConfigurationModel> configuration, ILogger<ChainController> logger)
        {
            _configurations = configuration;
            _chainBusiness = new ChainBusiness(_configurations.Value);
            _logger = logger;
        }

        /// <summary>
        /// List of chain codes
        /// </summary>
        /// <param name="filter">conditional parameter to filter information, min 3 characters</param>
        /// <returns>A list of chain codes</returns>
        [HttpGet]
        //[Route("chain")]
        public ActionResult<List<ChainModel>> getChainList([FromQuery] string filter)
        {
            try
            {
                return _chainBusiness.getChainList(filter);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ChainController - metodo getChainList API chain, exception: { ex.Message} stack trace : {ex.StackTrace}");
                return BadRequest(ex.Message.ToString());
            }
        }
    }
}