﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Viam.SalesForce.API.Model.Configuration
{
    public class ConfigurationModel
    {
        IConfiguration configuration;

        public ConfigurationModel()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            configuration = builder.Build();
        }

        public string EnvioRead
        {
            get;
            set;
        }

        public string EnvioWrite
        {
            get;
            set;
        }

        public string EnvioDW 
        { 
            get; 
            set; 
        }

        public string SecretKey
        {
            get;
            set;
        }

        public string Issuer
        {
            get;
            set;
        }
    }
}
