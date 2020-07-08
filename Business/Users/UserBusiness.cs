using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Viam.SalesForce.API.Data.Locations;
using Viam.SalesForce.API.Data.Users;
using Viam.SalesForce.API.Model.Configuration;
using Viam.SalesForce.API.Model.User;

namespace Viam.SalesForce.API.Business.Users
{
    public class UserBusiness
    {

        UserRepository _envioWriteRepository;

        public UserBusiness(ConfigurationModel configuration)
        {
            _envioWriteRepository = new UserRepository(configuration.EnvioWrite);
        }

        public Usuario getUserAPI(string login, string password)
        {
            return _envioWriteRepository.getUserAPI(login, password);
        }
    }
}
