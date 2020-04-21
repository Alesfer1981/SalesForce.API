using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Viam.SalesForce.API.Business.Groups;
using Viam.SalesForce.API.Business.Locations;
using Viam.SalesForce.API.Model.Configuration;
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
        private readonly ILogger<GroupController> _logger;

        //private readonly ILoggerManager loggerFactory;

        private readonly IOptions<ConfigurationModel> _configurations;

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
        /// <param name="idLocation">Location identifier</param>
        /// <returns>List of branches</returns>
        [HttpGet]
        [Route("branch")]
        public ActionResult<List<MainBranchModel>> getMainBranchList(string idLocation)
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
    }
}