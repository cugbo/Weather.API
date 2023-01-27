using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Weather.API.Weather.Models.DTOS;
using Weather.API.Weather.Services.Interfaces;

namespace Weather.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class AuthController : ControllerBase
    {
        private readonly IAuthManager _authManager;
        private readonly ILogger<AuthController> _logger;

        public AuthController(IAuthManager authManager, ILogger<AuthController> logger)
        {
            _authManager = authManager;
            _logger = logger;
        }
        [HttpPost("user-registration")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> RegisterUser([FromBody] RegisterUserDto registerUser)
        {
            _logger.LogInformation($"Registration attempt for {registerUser.Email}");
            try
            {
                var errors = await _authManager.RegisterUser(registerUser);
                if (errors.Any())
                {
                    foreach (var error in errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                    return BadRequest(ModelState);
            }
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Soemthing went wrongg in the {nameof(RegisterUser)} in user registration ateempt for {registerUser.Email}");
                return Problem($"Someting went wrong in the {nameof(RegisterUser)}", statusCode: 500);
            }
            
        }
        [HttpPost("login")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Login([FromBody] LoginDto login)
        {
            _logger.LogInformation($"Login in atttempt for {login.Email}");
            try
            {
                var authResponse = await _authManager.Login(login);
                if (authResponse == null)
                    return Unauthorized();
                return Ok(authResponse);

            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Someting went wrong in the {nameof(Login)}");
                return Problem($"Someting went wrong in the {nameof(Login)}", statusCode: 500);
            }
            
        }
    }
}
