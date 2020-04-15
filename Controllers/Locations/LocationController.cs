using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Viam.SalesForce.API.Business.Locations;
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
        private readonly IOptions<ConfigurationModel> _configurations;

        private LocationBusiness _locationBusiness = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="configuration">configuration object</param>
        public LocationController(IOptions<ConfigurationModel> configuration)
        {
            _configurations = configuration;
            _locationBusiness = new LocationBusiness(_configurations.Value);
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
                return _locationBusiness.getLocations(idLocation, synchronize);
            }
            catch (Exception ex)
            {

                throw;
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

                throw;
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

                throw;
            }
        }

        /// <summary>
        /// List of main branches
        /// </summary>
        /// <param name="filter">conditional</param>
        /// <returns>List of branches</returns>
        [HttpGet]
        [Route("branch")]
        public ActionResult<List<MainBranchModel>> getMainBranchList(string filter)
        {
            try
            {
                return _locationBusiness.getMainBranchList(filter);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        /// <summary>
        /// Test conection
        /// </summary>
        /// <returns>True/False</returns>
        [HttpGet]
        [Route("echoping")]
        public IActionResult EchoPingAgents()
        {
            return Ok(true);
        }
    }
}