using System.Linq;
using Cryptocop.Software.API.Models.DTOs;
using Cryptocop.Software.API.Models.ImputModels;
using Cryptocop.Software.API.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cryptocop.Software.API.Controllers
{
    [Authorize]
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly ITokenService _tokenService;

        public AccountController(IAccountService accountService, ITokenService tokenService)
        {
            _accountService = accountService;
            _tokenService = tokenService;
        }

        public IAccountService AccountService { get; }

        //api/account/register [POST]
        [AllowAnonymous]
        [HttpPost]
        [Route("register")]
        public ActionResult<UserDto> RegisterUser(RegisterInputModel registerModel)
        {
            if (ModelState.IsValid)
            {
                var user = _accountService.CreateUser(registerModel);
                return StatusCode(StatusCodes.Status201Created, user);
            }
            else
            {
                return BadRequest(registerModel);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("signin")]
        public ActionResult SignIn(LoginInputModel loginModel)
        {
            var user = _accountService.AuthenticateUser(loginModel);
            if (user == null) { return Unauthorized(); }
            return Ok(_tokenService.GenerateJwtToken(user));
        }


        //api/account/signout [GET]
        [HttpGet]
        [Route("signout")]
        public ActionResult<UserDto> SignOut(LoginInputModel loginModel)
        {
            int.TryParse(User.Claims.FirstOrDefault(c => c.Type == "tokenId").Value, out var tokenId);
            _accountService.Logout(tokenId);
            return NoContent();
        }

    }
}