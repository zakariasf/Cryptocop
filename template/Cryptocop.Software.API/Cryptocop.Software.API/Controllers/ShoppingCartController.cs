﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cryptocop.Software.API.Controllers
{
    [Authorize]
    [Route("api/cart")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        // TODO: Setup routes

        //api/cart [GET]
        //api/cart [POST]
        //api/cart/{id} [DELETE]
        //api/cart/{id} [PATCH]
        //api/cart [DELETE]
    }
}