using Cryptocop.Software.API.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Cryptocop.Software.API.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        // TODO: Setup routes
        // TODO: Register and signin POST endpoints that dont need the JWT authentication

        //api/account/register [POST]
        [HttpPost]
        [Route("/register")]
        public UserDto RegisterUser()
        
        //api/account/signin [POST]
        //api/account/signout [GET]

    }
}