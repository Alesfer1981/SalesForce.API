using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Viam.SalesForce.API.Data.Products;
using Viam.SalesForce.API.Model.Configuration;

namespace Viam.SalesForce.API.Business.Products
{
    public class ProductBusiness
    {
        ProductRepository _envioReadRepository;

        public ProductBusiness(ConfigurationModel configuration)
        {
            _envioReadRepository = new ProductRepository(configuration.EnvioRead);
        }

        public ActionResult<string> setProductStatus(string idbranch, string status, string flag)
        {
            return _envioReadRepository.setProductStatus(idbranch, status, flag);
        }

    }
}