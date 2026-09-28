using AuthHm.DTOs;
using AuthHm.Services.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthHm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthServices _auth;
        public AuthController(IAuthServices auth) => _auth = auth;

        [HttpPost("register")]
        public IActionResult Register(RegisterDto dto)
        {
            var result = _auth.Register(dto);
            return StatusCode(result.Status, result);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginDto dto)
        {
            var result = _auth.Login(dto);
            return StatusCode(result.Status, result);
        }
    }


}
