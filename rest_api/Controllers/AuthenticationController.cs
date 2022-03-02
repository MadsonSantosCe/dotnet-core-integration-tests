using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using rest_api.Domain.Models;
using rest_api.Domain.Services;
using rest_api.Extensions;
using rest_api.Util;
using System;
using System.Threading.Tasks;

namespace rest_api.Controllers
{
    [Route("/api/[controller]")]
    [AllowAnonymous]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;

        public AuthenticationController(IUserService userService, IConfiguration configuration)
        {
            _userService = userService;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<ActionResult> VerifyLogin([FromBody] User user)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.GetErrorMessages());

                var result = await _userService.FirstOrDefaultAsync(user.Login, user.Password);

                if (result == null)
                    return BadRequest("Erro ao tentar realizar o login.");

                var token = CryptoFunctions.GenerateToken(_configuration, user);

                return Ok(new
                {
                    error = false,
                    result = new
                    {
                        token,
                        user = new { user.Id, user.Login }
                    }
                });

            }

            catch (Exception)
            {
                var message = $"Erro ao tentar realizar o login.";
                return BadRequest(new { error = true, result = new { message } });
            }

        }

    }
}
