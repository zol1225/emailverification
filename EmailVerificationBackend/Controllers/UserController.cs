using Microsoft.AspNetCore.Mvc;
using EmailVerificationBackend.Services;
using EmailVerificationBackend.Models;

namespace EmailVerificationBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet("hello")]
        public IActionResult GetHello()
        {
            return Ok("Hello from .NET 8 Backend!");
        }

        [HttpPost("signup")]
        public IActionResult SignUp([FromBody] SignUpRequest request)
        {
            _userService.CreateUser(request.Email, request.Password);
            return Ok("User created successfully!");
        }

    }
}
