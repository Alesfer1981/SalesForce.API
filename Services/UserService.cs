using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Viam.SalesForce.API.Helper;
using Viam.SalesForce.API.Model.Configuration;
using Viam.SalesForce.API.Model.User;

namespace Viam.SalesForce.API.Services
{

    /// <summary>
    /// Interface for User Class
    /// </summary>
    //public interface IUserService
    //{
    //    /// <summary>
    //    /// Method to valid user credentials
    //    /// </summary>
    //    /// <param name="usuario"></param>
    //    /// <returns></returns>
    //    Usuario Authenticate(Usuario usuario);

    //    /// <summary>
    //    /// Interface to keep tracking user register.
    //    /// </summary>
    //    /// <param name="user">user name</param>
    //    /// <param name="option">option used</param>
    //    //void TrackingUser(string user, string option);
    //}

    internal class UserService
    {
        /// <summary>
        /// Secret key access value
        /// </summary>
        private readonly string _secretKey;

        /// <summary>
        /// Value to configure access key
        /// </summary>
        private readonly string _issuer;

        /// <summary>
        /// Interface to log management
        /// </summary>
        private readonly ILogger<UserService> _logger;

        /// <summary>
        /// Constructor User Class
        /// </summary>
        /// <param name="appSettings">Configuration values</param>
        /// <param name="logger">Custom log object</param>
        public UserService(ConfigurationModel configuration) //, ILogger<UserService> logger)
        {
            _secretKey = configuration.SecretKey;
            _issuer = configuration.Issuer;
        }

        public UserService(ILogger<UserService> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Method to get token access
        /// </summary>
        /// <param name="usuario">usuario object</param>
        /// <returns>usuario object with token</returns>
        //public Usuario Authenticate(Usuario usuario)
        //{
        //    try
        //    {
        //        var tokenHandler = new JwtSecurityTokenHandler();
        //        var key = Encoding.ASCII.GetBytes("Este es el password");
        //        var tokenDescriptor = new SecurityTokenDescriptor
        //        {
        //            Subject = new ClaimsIdentity(new Claim[]
        //            {
        //            //new Claim(ClaimTypes.Name, usuario.Login.ToString()),
        //            //new Claim("idAgent", usuario.IdAgent),
        //            new Claim("login", usuario.Login),
        //            new Claim("typeUser", usuario.TypeUser),
        //            new Claim("status", usuario.Status),
        //            new Claim("Fname", usuario.Fname),
        //            new Claim("Lname", usuario.Lname)
        //            }),
        //            Expires = DateTime.UtcNow.AddHours(24),
        //            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
        //                                                            SecurityAlgorithms.HmacSha256Signature)
        //        };

        //        var token = tokenHandler.CreateToken(tokenDescriptor);
        //        usuario.Token = tokenHandler.WriteToken(token);

        //        //Reset password for security 
        //        //usuario.Password = null;
        //    }
        //    catch (Exception e)
        //    {
        //        //_logger.LogError($"UserService - método Authenticate, exception: { e.Message}");
        //    }
        //    return usuario;
        //}

        /// <summary>
        /// Method to get token access
        /// </summary>
        /// <param name="usuario">usuario object</param>
        /// <returns>usuario object with token</returns>
        public Usuario Authenticate(Usuario usuario)
        {
            try
            {
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(_issuer, _issuer,
                   new Claim[]{ 
                    //new Claim(ClaimTypes.Name, usuario.Login.ToString()),
                    //new Claim("idAgent", usuario.IdAgent),
                    new Claim("login", usuario.Login),
                    new Claim("typeUser", usuario.TypeUser),
                    new Claim("status", usuario.Status),
                    new Claim("Fname", usuario.Fname),
                    new Claim("Lname", usuario.Lname)
                        },
                expires: DateTime.Now.AddMinutes(120), signingCredentials: credentials);
                usuario.Token = new JwtSecurityTokenHandler().WriteToken(token);

            }
            catch (Exception ex)
            {
                _logger.LogError($"UserService - método Authenticate, exception: { ex.Message}");
            }
            return usuario;
        }
    }
}
