using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{ 
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        private IRestaurantService _restaurantService;

        public RestaurantsController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
           
            var result = _restaurantService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data) ;
        }
        [HttpPost("add")]
        public IActionResult Add(Restaurant restaurant)
        {
            var result = _restaurantService.Add(restaurant);
            if (result.Success)
            {
                
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}