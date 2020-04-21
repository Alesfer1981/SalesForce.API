using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Viam.SalesForce.API.Business.Users;
using Viam.SalesForce.API.Controllers.Locations;
using Viam.SalesForce.API.Model.Configuration;
using Viam.SalesForce.API.Model.User;
using Viam.SalesForce.API.Services;

namespace Viam.SalesForce.API.Controllers.Users
{
    [Route("api/user")]
    [ApiController]
    public class UsersController : Controller
    {
        /// <summary>
        /// Interface for log management.
        /// </summary>
        private readonly ILogger<UsersController> _logger;

        private readonly IOptions<ConfigurationModel> _configurations;

        private UserBusiness _userBusiness = null;

        private UserService _userService = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="configuration">configuration object</param>
        /// <param name="logger">loggin object</param>
        public UsersController(IOptions<ConfigurationModel> configuration, ILogger<UsersController> logger) //, IUserService userInterface)
        {
            _configurations = configuration;
            _userBusiness = new UserBusiness(_configurations.Value);
            _logger = logger;
            _userService = new UserService(_configurations.Value);
        }

        /// <summary>
        /// Method to API access.
        /// </summary>
        /// <param name="userModel"></param>
        /// <returns>Token authetication</returns>
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Authenticate([FromBody] UserModel userModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                try
                {
                    Usuario _usuario = _userBusiness.getUserAPI(userModel.UserName, userModel.Password);

                    if (!string.IsNullOrEmpty(_usuario.Fname) && !string.IsNullOrEmpty(_usuario.Lname))
                    {
                        _userService.Authenticate(_usuario);
                        //return Ok(user.Token);
                        return Json(new
                        {
                            token = _usuario.Token,
                            userName = _usuario.Login
                        });
                    }
                    else
                    {
                        _logger.LogWarning($"UsersController, método Authenticate: No se encontro el usurio: { _usuario.Login}");
                        return Unauthorized();
                    }
                }
                catch (Exception e)
                {
                    _logger.LogError($"UsersController - método Authenticate, exception: { e.Message}");
                    //_log.LogError($"Error en UsersController, en el método Authenticate. Descripción : { e.Message }");
                    return BadRequest("Access denied");
                }
            }
        }
    }
}