using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Viam.SalesForce.API.Business.Products;
using Viam.SalesForce.API.Model.Configuration;

namespace Viam.SalesForce.API.Controllers.Products
{
    /// <summary>
    /// Controller to chain management
    /// </summary>
    [Route("api/product")]
    [ApiController]
    [Authorize]
    public class ProductController : Controller
    {
        /// <summary>
        /// Log management object
        /// </summary>
        private readonly ILogger<ProductController> _logger;

        /// <summary>
        /// Configuration object
        /// </summary>
        private readonly IOptions<ConfigurationModel> _configurations;

        /// <summary>
        /// Business layer object
        /// </summary>
        private ProductBusiness _productBusiness = null;


        public ProductController(IOptions<ConfigurationModel> configuration, ILogger<ProductController> logger)
        {
            _configurations = configuration;
            _productBusiness = new ProductBusiness(_configurations.Value);
            _logger = logger;
        }

        /// <summary>
        /// Update product status
        /// </summary>
        /// <param name="idbranch">code of product</param>
        /// <param name="flag">status value to change</param>
        /// <returns>Message response</returns>
        [HttpPut]
        [Route("status")]
        public ActionResult<string> setProductStatus([FromQuery] string idbranch, string status, string flag)
        {
            try
            {
                return _productBusiness.setProductStatus(idbranch, status, flag);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ProductController - metodo setProductStatus API status, exception: { ex.Message} stack trace : {ex.StackTrace}");
                return BadRequest(ex.Message.ToString());
            }
        }
    }
}