using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Viam.SalesForce.API.Business.Chain;
using Viam.SalesForce.API.Model.Chain;
using Viam.SalesForce.API.Model.Configuration;

namespace Viam.SalesForce.API.Controllers.Chain
{

    [Route("api/chain")]
    [ApiController]
    public class ChainController : Controller
    {
        private readonly IOptions<ConfigurationModel> _configurations;

        private ChainBusiness _chainBusiness = null;

        public ChainController(IOptions<ConfigurationModel> configuration)
        {
            _configurations = configuration;
            _chainBusiness = new ChainBusiness(_configurations.Value);
        }

        /// <summary>
        /// List of chain codes
        /// </summary>
        /// <param name="filter">conditional</param>
        /// <returns>A list of chain codes</returns>
        [HttpGet]
        ///[Route("chain")]
        public ActionResult<List<ChainModel>> getChainList([FromQuery] string filter)
        {
            try
            {
                return _chainBusiness.getChainList(filter);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}