using BussinesLogic.DTOs;
using BussinesLogic.Interfaces;
using BussinesLogic.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PhoneShop_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService accountService;

        public AccountController(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserDto user)
        {
            if (!ModelState.IsValid) return BadRequest();

            await accountService.Register(user);
            
            return Ok();
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserCredentials credentials)
        {
            if (!ModelState.IsValid) return BadRequest();

            await accountService.Login(credentials.Email, credentials.Password);

            return Ok();
        }
        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            await accountService.Logout();

            return Ok();
        }
    }
}
