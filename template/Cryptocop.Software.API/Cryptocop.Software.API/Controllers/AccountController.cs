using Cryptocop.Software.API.Models.DTOs;
using Cryptocop.Software.API.Models.ImputModels;
using Cryptocop.Software.API.Services.Implementations;
using Cryptocop.Software.API.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cryptocop.Software.API.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService accountService = new AccountService();

        //api/account/register [POST]
        [HttpPost]
        public ActionResult<UserDto> RegisterUser(RegisterInputModel registerModel)
        {
            if (ModelState.IsValid)
            {
                var user = accountService.CreateUser(registerModel);
                return StatusCode(StatusCodes.Status201Created, user);
            }
            else
            {
                return BadRequest(registerModel);
            }
        }
        

        //api/account/signin [POST]

       
        //api/account/signout [GET]

    }
}