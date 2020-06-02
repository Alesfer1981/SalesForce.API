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
using Viam.SalesForce.API.Model.Products;

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

        /// <summary>
        /// Save a new product
        /// </summary>
        /// <param name="newProductParams">Contains the attributes to save a new product</param>
        /// <returns>Data of new product inserted</returns>
        [HttpPost]
        [Route("add")]
        public ActionResult<NewProductParams> addNewProduct(NewProductParams newProductParams)
        {
            try
            {
                return _productBusiness.addNewProduct(newProductParams);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ProductController - metodo addNewProduct API add, exception: { ex.Message} stack trace : {ex.StackTrace}");
                return BadRequest(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Find a product by code
        /// </summary>
        /// <param name="idBranch">Code of the product</param>
        /// <returns>Data of product</returns>
        [HttpGet]
        [Route("get")]
        public ActionResult<ProductModel> getProduct(string idBranch)
        {
            try
            {
                return _productBusiness.getProduct(idBranch);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ProductController - metodo getProduct API get, exception: { ex.Message} stack trace : {ex.StackTrace}");
                return BadRequest(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Update a product data
        /// </summary>
        /// <param name="productModel"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("update")]
        public ActionResult<ProductModel> updateProduct(ProductModel productModel)
        {
            try
            {
                return _productBusiness.updateProduct(productModel);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ProductController - metodo updateProduct API update, exception: { ex.Message} stack trace : {ex.StackTrace}");
                return BadRequest(ex.Message.ToString());
            }
        }


        /// <summary>
        /// Get a KPIs list 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="idProduct"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("kpis")]
        public ActionResult<List<KpisModel>> getKpis(string name, string idProduct)
        {
            try
            {
                return _productBusiness.getKpis(name, idProduct);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ProductController - metodo getKpis API kpis, exception: { ex.Message} stack trace : {ex.StackTrace}");
                return BadRequest(ex.Message.ToString());
            }
        }
    }
}