using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using packt.API.Contracts;
using packt.API.Models.User;

namespace packt.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthManager _authManager;
        private readonly ILogger<AuthController> _logger;

        public AuthController(IAuthManager authManager, ILogger<AuthController> logger)
        {
            this._authManager = authManager;
            this._logger = logger;
        }

        //POST : api/Account/register
        [HttpPost]
        [Route("register")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> Register([FromBody] ApiUserDto apiUserDto)
        {
            _logger.LogInformation($"Registration attempt for {apiUserDto.Email}");
            try
            {
                var errors = await _authManager.Register(apiUserDto);

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
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(Register)}- User Registration " +
                    $"attempt for {apiUserDto.Email}");

                return Problem($"Something went wrong in the {nameof(Register)}, Please contact support.", statusCode: 500);
            }
            
        }


        //POST : api/Account/login
        [HttpPost]
        [Route("login")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> Login([FromBody] LoginDto loginDto)
        {
            _logger.LogInformation($"Login attempt for {loginDto.Email}");

            try
            {
                var authResponse = await _authManager.Login(loginDto);

                if (authResponse == null)
                {
                    return Unauthorized();
                }

                return Ok(authResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(Login)} - user login attempt for {loginDto.Email}");

                return Problem($"Something went wrong in the {nameof(Login)}. Please contact support.", statusCode: 500);
            }
        }

        //POST : api/Account/refreshtoken
        [HttpPost]
        [Route("refreshtoken")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> RefreshToken([FromBody] AuthResponseDto request)
        {
            _logger.LogInformation($"Refresh Token attempt for {request.UserId}");

            try
            {
                var authResponse = await _authManager.VerifyRefreshToken(request);

                if (authResponse == null)
                {
                    return Unauthorized();
                }

                return Ok(authResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(RefreshToken)} - user refresh token attempt for {request.UserId}");
                
                return Problem($"Something went wrong in the {nameof(RefreshToken)}. Please contact support.", statusCode: 500);
            }
        }
    }
}
