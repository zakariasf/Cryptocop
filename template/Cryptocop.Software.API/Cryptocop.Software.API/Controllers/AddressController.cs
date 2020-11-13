using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cryptocop.Software.API.Controllers
{
    [Authorize]
    [Route("api/addresses")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        // TODO: Setup routes

        //api/addresses [GET]
        //api/addresses [POST]
        //api/addresses/{id} [DELETE]
    }
}