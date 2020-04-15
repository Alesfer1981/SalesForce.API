using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Viam.SalesForce.API.Data.Chain;
using Viam.SalesForce.API.Model.Chain;
using Viam.SalesForce.API.Model.Configuration;

namespace Viam.SalesForce.API.Business.Chain
{
    public class ChainBusiness
    {
        ChainRepository _envioReadRepository;

        public ChainBusiness(ConfigurationModel configuration)
        {
            _envioReadRepository = new ChainRepository(configuration.EnvioRead);
        }

        public ActionResult<List<ChainModel>> getChainList(string filter)
        {
            return _envioReadRepository.getChainList(filter);
        }
    }
}
