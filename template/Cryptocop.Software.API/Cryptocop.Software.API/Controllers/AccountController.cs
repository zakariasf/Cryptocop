using Cryptocop.Software.API.Models.DTOs;
using Cryptocop.Software.API.Models.ImputModels;
using Cryptocop.Software.API.Services.Implementations;
using Cryptocop.Software.API.Services.Interfaces;
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
        [Route("/register")]
        public UserDto RegisterUser(RegisterInputModel registerModel)
        {
            return accountService.CreateUser(registerModel);
        }
        
        //api/account/signin [POST]
        //api/account/signout [GET]

    }
}