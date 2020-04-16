using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Viam.SalesForce.API.Business.Locations;
using Viam.SalesForce.API.Helper;
using Viam.SalesForce.API.Model.Configuration;
using Viam.SalesForce.API.Model.Locations;

namespace Viam.SalesForce.API.Controllers.Locations
{
    /// <summary>
    /// Controller to locations management
    /// </summary>
    [Route("api/location")]
    [ApiController]
    public class LocationController : Controller
    {
        private readonly ILogger<LocationController> _logger;

        private readonly IOptions<ConfigurationModel> _configurations;

        private LocationBusiness _locationBusiness = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="configuration">configuration object</param>
        /// <param name="logger">loggin object</param>
        public LocationController(IOptions<ConfigurationModel> configuration, ILogger<LocationController> logger)
        {
            _configurations = configuration;
            _locationBusiness = new LocationBusiness(_configurations.Value);
            _logger = logger;
        }

        /// <summary>
        /// Get a list of locations
        /// </summary>
        /// <param name="idLocation">Code of location</param>
        /// <param name="synchronize"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("location")]
        public ActionResult<List<LocationModel>> getLocations([FromQuery] string idLocation,
                                                                          string synchronize)
        {
            try
            {
                //throw new Exception("force exception");
                return _locationBusiness.getLocations(idLocation, synchronize);
            }
            catch (Exception ex)
            {
                _logger.LogError($"LocationController - metodo getLocations API location, exception: { ex.Message} stack trace : {ex.StackTrace}");
                return BadRequest(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Report of resume data
        /// </summary>
        /// <param name="idLocation">Code of location</param>
        /// <param name="measure">Values: 0 for all and 1 for only changes</param>
        /// <returns>List of resume data</returns>
        [HttpGet]
        [Route("resume")]
        public ActionResult<List<ResumeData>> getResumeData([FromQuery] string idLocation,
                                                                        int measure)
        {
            try
            {
                return _locationBusiness.getResumeData(idLocation, measure);
            }
            catch (Exception ex)
            {
                _logger.LogError($"LocationController - metodo getResumeData API resume, exception: { ex.Message} stack trace : {ex.StackTrace}");
                return BadRequest(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Report of data at today date
        /// </summary>
        /// <param name="idLocation">Code of location</param>
        /// <returns>List of resume data today</returns>
        [HttpGet]
        [Route("today")]
        public ActionResult<List<ResumeDataToday>> getResumeDataToday([FromQuery] string idLocation)
        {
            try
            {
                return _locationBusiness.getResumeDataToday(idLocation);
            }
            catch (Exception ex)
            {
                _logger.LogError($"LocationController - metodo getResumeDataToday API today, exception: { ex.Message} stack trace : {ex.StackTrace}");
                return BadRequest(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Test conection
        /// </summary>
        /// <returns>True/False</returns>
        [HttpGet]
        [Route("echoping")]
        public IActionResult EchoPingAPI()
        {
            return Ok(true);
        }
    }
}