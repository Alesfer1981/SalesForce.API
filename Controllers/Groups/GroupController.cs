using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Viam.SalesForce.API.Business.Groups;
using Viam.SalesForce.API.Business.Locations;
using Viam.SalesForce.API.Model.Configuration;
using Viam.SalesForce.API.Model.Groups;
using Viam.SalesForce.API.Model.Locations;

namespace Viam.SalesForce.API.Controllers.Groups
{
    /// <summary>
    /// Controller to group management
    /// </summary>
    [Route("api/group")]
    [ApiController]
    [Authorize]
    public class GroupController : Controller
    {
        /// <summary>
        /// Log management object
        /// </summary>
        private readonly ILogger<GroupController> _logger;

        /// <summary>
        /// Configuration object
        /// </summary>
        private readonly IOptions<ConfigurationModel> _configurations;

        /// <summary>
        /// Business layer object
        /// </summary>
        private GroupBusiness _groupBusiness = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="configuration">configuration object</param>
        /// <param name="logger">loggin object</param>
        public GroupController(IOptions<ConfigurationModel> configuration, ILogger<GroupController> logger)
        {
            _configurations = configuration;
            _groupBusiness = new GroupBusiness(_configurations.Value);
            _logger = logger;
        }

        /// <summary>
        /// List of main branches
        /// </summary>
        /// <param name="idLocation">Code of location</param>
        /// <returns>List of branches</returns>
        [HttpGet]
        [Route("branch")]
        public ActionResult<List<MainBranchModel>> getMainBranchList([FromQuery] string idLocation)
        {
            try
            {
                return _groupBusiness.getMainBranchList(idLocation);
            }
            catch (Exception ex)
            {
                _logger.LogError($"GroupController - metodo getMainBranchList API branch, exception: { ex.Message} stack trace : {ex.StackTrace}");
                return BadRequest(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Update credit of group branch
        /// </summary>
        /// <param name="salesFUpdateCreditParam">salesFUpdateCreditParam object</param>
        /// <returns></returns>
        [HttpPut]
        [Route("credit")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public ActionResult<string> updateCredit([FromBody] SalesFUpdateCreditParam salesFUpdateCreditParam)
        {
            try
            {
                return _groupBusiness.updateCredit(salesFUpdateCreditParam);
            }
            catch (Exception ex)
            {
                _logger.LogError($"GroupController - metodo updateCredit API credit, exception: { ex.Message} stack trace : {ex.StackTrace}");
                return BadRequest(ex.Message.ToString());
            }
        }
    }
}