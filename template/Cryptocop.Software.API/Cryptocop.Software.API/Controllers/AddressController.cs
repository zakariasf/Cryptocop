using Cryptocop.Software.API.Models.ImputModels;
using Cryptocop.Software.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace Cryptocop.Software.API.Controllers
{
    [Route("api/addresses")]
    [ApiController]

    public class AddressController : ControllerBase
    {
        private IAddressService _service;

        public AddressController(IAddressService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAllAddresses()
        {
            var result = _service.GetAllAddresses("test");
            return Ok(result);
        }

        [HttpPost]
        [Route("")]
        public IActionResult AddAddress([FromBody] AddressInputModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not valid!");
            _service.AddAddress("test@test.is", model);
            return Ok();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult DeleteAddress(int id)
        {
            _service.DeleteAddress("test", id);
            return Ok();
        }
        //api/addresses [POST]
        //api/addresses/{id} [DELETE]
    }
}