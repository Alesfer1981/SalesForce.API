using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public class LocationController : Controller
    {
        /// <summary>
        /// Log management object
        /// </summary>
        private readonly ILogger<LocationController> _logger;

        /// <summary>
        /// Configuration object
        /// </summary>
        private readonly IOptions<ConfigurationModel> _configurations;

        /// <summary>
        /// Business layer object
        /// </summary>
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
        /// <param name="synchronize">Flag to indicate if the location was upated or not 1:updated 0:not updated</param>
        /// <returns>List of locations</returns>
        [HttpGet]
        [Route("location")]
        public ActionResult<List<LocationModel>> getLocations([FromQuery] string idLocation,
                                                                          string synchronize,
                                                                          int? pageNumber,
                                                                          int? pageSize)
        {
            try
            {
                //throw new Exception("force exception");
                List<LocationModel> lstLocations = _locationBusiness.getLocations(idLocation, synchronize);

                List<LocationModel> lstLocationsTotal = lstLocations;
                decimal totalRecords = lstLocations.Count();

                int currentPage = pageNumber ?? 1;
                int currentPageSize = pageSize ?? lstLocations.Count();

                lstLocations = lstLocations.Skip((currentPage - 1) * currentPageSize).Take(currentPageSize).ToList();

                return Json(new
                {
                    totalRecords = totalRecords,
                    totalPages = Math.Ceiling(Convert.ToDouble(lstLocationsTotal.Count() / pageSize)),
                    lstLocations = lstLocations
                });
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
                                                                        int measure,
                                                                        int? pageNumber,
                                                                        int? pageSize)
        {
            try
            {
                measure = string.IsNullOrEmpty(measure.ToString()) ? 0 : measure;

                List<ResumeData> lstResumeData = _locationBusiness.getResumeData(idLocation, measure);

                List<ResumeData> lstResumeDataTotal = lstResumeData;
                decimal totalRecords = lstResumeData.Count();

                int currentPage = pageNumber ?? 1;
                int currentPageSize = pageSize ?? lstResumeData.Count();

                lstResumeData = lstResumeData.Skip((currentPage - 1) * currentPageSize).Take(currentPageSize).ToList();

                return Json(new
                {
                    totalRecords = totalRecords,
                    totalPages = Math.Ceiling(Convert.ToDouble(lstResumeDataTotal.Count() / pageSize)),
                    lstResumeData = lstResumeData
                });
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
        /// Set status a group of locations
        /// </summary>
        /// <param name="idLocationList">List of locations codes separated by comma</param>
        /// <param name="value">Value to set synchronize column</param>
        /// <returns>Confirm operation</returns>
        [HttpPut]
        [Route("synch")]
        public ActionResult<string> setSynchronized([FromQuery] string idLocationList, string value)
        {
            try
            {
                return _locationBusiness.setSynchronized(idLocationList, value);
            }
            catch (Exception ex)
            {
                _logger.LogError($"LocationController - metodo setSynchronized API synch, exception: { ex.Message} stack trace : {ex.StackTrace}");
                return BadRequest(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Disable all location active products
        /// </summary>
        /// <param name="idLocation">Code of location</param>
        /// <returns>Message response</returns>
        [HttpPut]
        [Route("locationStatus")]
        public ActionResult<string> setLocationStatus([FromQuery] string idLocation)
        {
            try
            {
                return _locationBusiness.setLocationStatus(idLocation);
            }
            catch (Exception ex)
            {
                _logger.LogError($"LocationController - metodo setLocationStatus API locationStatus, exception: { ex.Message} stack trace : {ex.StackTrace}");
                return BadRequest(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Get list of current rates
        /// </summary>
        /// <param name="idLocation">Code of location</param>
        /// <param name="dateFrom"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("rates")]
        public ActionResult<List<RateModel>> getCurrentRates([FromQuery] string idLocation, string dateFrom)
        {
            try
            {
                DateTime? dateProcess;
                if (!string.IsNullOrEmpty(dateFrom))
                {
                    dateProcess = DateTime.Parse(dateFrom);
                }
                else
                {
                    dateProcess = null;
                }
                return _locationBusiness.getCurrentRates(idLocation, dateProcess);
            }
            catch (Exception ex)
            {
                _logger.LogError($"LocationController - metodo getCurrentRates API locationStatus, exception: { ex.Message} stack trace : {ex.StackTrace}");
                return BadRequest(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Update Sales Force identifier
        /// </summary>
        /// <param name="idLocation">Location Code</param>
        /// <param name="idSalesForce">Sales Force Code</param>
        /// <returns></returns>
        [HttpPut]
        [Route("salesForceId")]
        public ActionResult<string> setSalesFId(string idLocation, string idSalesForce)
        {
            try
            {
                return _locationBusiness.setSalesFId(idLocation, idSalesForce);
            }
            catch (Exception ex)
            {
                _logger.LogError($"LocationController - metodo setSalesFId API salesId, exception: { ex.Message} stack trace : {ex.StackTrace}");
                return BadRequest(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Test conection
        /// </summary>
        /// <returns>True/False</returns>
        [HttpGet]
        [Route("echoping")]
        [AllowAnonymous]
        public IActionResult EchoPingAPI()
        {
            return Ok(true);
        }
    }
}