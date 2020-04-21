using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Viam.SalesForce.API.Model.User
{
    public class UserModel
    {

        public string UserName { get; set; }


        public string Password { get; set; }
    }

    public class Usuario
    {
        /// <summary>
        /// User name
        /// </summary>
        [Key]
        public string Login { get; set; }

        /// <summary>
        /// Type user
        /// </summary>
        public string TypeUser { get; set; }

        /// <summary>
        /// Status of agent
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// First Name
        /// </summary>
        public string Fname { get; set; }

        /// <summary>
        /// Last Name
        /// </summary>
        public string Lname { get; set; }

        /// <summary>
        /// Chain of characters
        /// </summary>
        public string Token { get; set; }
    }
}
