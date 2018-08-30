using auth.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace auth.Controllers
{

    [Route("api/auth")]
    [ApiController]
    class AuthController: Controller
    {

        private IAuthService _authService;

        public AuthController(IAuthService _authService)
        {
            this._authService = _authService;
        }

        [Route("login")]
        [HttpPost]
        public IActionResult Login([FromBody] string email, [FromBody] string password)
        {
            try
            {
                string token = _authService.Login(email, password);
                return Ok(token);
            } catch (Exception e)
            {
                return NotFound();
            }
        }

        [Route("user/add")]
        [HttpPost]
        public IActionResult AddUserCredentials([FromBody] string email, [FromBody] string password)
        {
            Boolean result = _authService.AddUserCreadentials(email, password);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

        [Route("token/verify")]
        [HttpPost]
        public IActionResult VerifyUserToken([FromBody] string token)
        {
            string result = _authService.VerifyUserToken(token);
            if (result != null && result != "")
            {
                return Ok(result);
            } else
            {
                return NotFound();
            }
        }

    }
}
