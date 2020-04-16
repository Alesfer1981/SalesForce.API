using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Viam.SalesForce.API.Data.Locations;
using Viam.SalesForce.API.Model.Configuration;
using Viam.SalesForce.API.Model.Locations;

namespace Viam.SalesForce.API.Business.Locations
{
    public class LocationBusiness
    {

        LocationRepository _envioReadRepository;

        public LocationBusiness(ConfigurationModel configuration)
        {
            _envioReadRepository = new LocationRepository(configuration.EnvioRead);
        }

        public ActionResult<List<ResumeData>> getResumeData(string idlocation, int measure)
        {
            return _envioReadRepository.getResumeData(idlocation, measure);
        }

        public ActionResult<List<LocationModel>> getLocations(string idlocation, string synchronize)
        {
            return _envioReadRepository.getLocations(idlocation, synchronize);
        }

        public ActionResult<List<ResumeDataToday>> getResumeDataToday(string idlocation)
        {
            return _envioReadRepository.getResumeDataToday(idlocation);
        }

        
    }
}
