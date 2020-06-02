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

        public List<ResumeData> getResumeData(string idlocation, string idSalesRep)
        {
            return _envioReadRepository.getResumeData(idlocation, idSalesRep);
        }

        public List<LocationModel> getLocations(string idlocation, string synchronize)
        {
            return _envioReadRepository.getLocations(idlocation, synchronize);
        }

        public ActionResult<List<ResumeDataToday>> getResumeDataToday(string idlocation)
        {
            return _envioReadRepository.getResumeDataToday(idlocation);
        }

        public ActionResult<string> setSynchronized(string idLocationList, string value)
        {
            return _envioReadRepository.setSynchronized(idLocationList, value);
        }

        public ActionResult<string> setLocationStatus(string idLocation)
        {
            return _envioReadRepository.setLocationStatus(idLocation);
        }

        public ActionResult<List<RateModel>> getCurrentRates(string idLocation, DateTime? dateFrom)
        {
            return _envioReadRepository.getCurrentRates(idLocation, dateFrom);
        }

        public ActionResult<string> setSalesFId(string idLocation, string idSalesForce)
        {
            return _envioReadRepository.setSalesFId(idLocation, idSalesForce);
        }

    }
}