using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Viam.SalesForce.API.Data.Groups;
using Viam.SalesForce.API.Model.Configuration;
using Viam.SalesForce.API.Model.Groups;
using Viam.SalesForce.API.Model.Locations;

namespace Viam.SalesForce.API.Business.Groups
{
    public class GroupBusiness
    {
        GroupRepository _envioReadRepository;
        GroupRepository _envioWriteRepository;

        public GroupBusiness(ConfigurationModel configuration)
        {
            _envioReadRepository = new GroupRepository(configuration.EnvioRead);
            _envioWriteRepository = new GroupRepository(configuration.EnvioWrite);
        }

        public ActionResult<List<MainBranchModel>> getMainBranchList(string idLocation)
        {
            return _envioReadRepository.getMainBranchList(idLocation);
        }

        public ActionResult<string> updateCredit(SalesFUpdateCreditParam salesFUpdateCreditParam)
        {
            return _envioWriteRepository.updateCredit(salesFUpdateCreditParam);
        }
    }
}
