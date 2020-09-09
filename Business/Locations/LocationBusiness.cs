using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Viam.SalesForce.API.Data.Locations;
using Viam.SalesForce.API.Model.Configuration;
using Viam.SalesForce.API.Model.Locations;
using Viam.SalesForce.API.Model.Products;

namespace Viam.SalesForce.API.Business.Locations
{
    public class LocationBusiness
    {

        LocationRepository _envioReadRepository;
        LocationRepository _envioWriteRepository;
        LocationRepository _envioDWRepository;

        public LocationBusiness(ConfigurationModel configuration)
        {
            _envioReadRepository = new LocationRepository(configuration.EnvioRead);
            _envioWriteRepository = new LocationRepository(configuration.EnvioWrite);
            _envioDWRepository = new LocationRepository(configuration.EnvioDW);
        }

        public List<ResumeData> getResumeData(string idlocation, int measure)
        {
            return _envioDWRepository.getResumeData(idlocation, measure);
        }

        public List<LocationModel> getLocations(string idlocation, string synchronize)
        {
            return _envioDWRepository.getLocations(idlocation, synchronize);
        }

        public ActionResult<List<ResumeDataToday>> getResumeDataToday(string idlocation)
        {
            return _envioDWRepository.getResumeDataToday(idlocation);
        }

        public ActionResult<string> setSynchronized(string idLocationList, string value)
        {
            return _envioWriteRepository.setSynchronized(idLocationList, value);
        }

        public ActionResult<string> setLocationStatus(string idLocation)
        {
            return _envioWriteRepository.setLocationStatus(idLocation);
        }

        public ActionResult<List<RateModel>> getCurrentRates(string idLocation, DateTime? dateFrom)
        {
            return _envioDWRepository.getCurrentRates(idLocation, dateFrom);
        }

        public ActionResult<string> setSalesFId(string idLocation, string idSalesForce)
        {
            return _envioWriteRepository.setSalesFId(idLocation, idSalesForce);
        }

         public ActionResult<List<AgencyProducts>> getAgencyProducts(string idProduct, string date, string idLocation)
        {
            return _envioReadRepository.getAgencyProducts(idProduct, date,idLocation);
        }

    }
}