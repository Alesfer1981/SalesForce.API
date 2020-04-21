using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Viam.SalesForce.API.Helper
{
    public class AppSettings
    {
        /// <summary>
        /// Key to generate the token access.
        /// </summary>
        public string SecretKey { get; set; }

        /// <summary>
        /// User name 
        /// </summary>
        public string ApiUser { get; set; }
    }
}
