using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingCartsController : ControllerBase
    {
        private IShippingCartService _shippingCartService;

        public ShippingCartsController(IShippingCartService shippingCartService)
        {
            _shippingCartService = shippingCartService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _shippingCartService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(ShippingCart shippingCart)
        {
            var result = _shippingCartService.Add(shippingCart);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getshippingcartdetails")]
        public IActionResult GetShippingCartDetails()
        {
            var result = _shippingCartService.GetShippingCartDetails();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

    }
}