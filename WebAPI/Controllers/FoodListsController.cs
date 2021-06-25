using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodListsController : ControllerBase
    {

        private IFoodListService _foodListService;

        public FoodListsController(IFoodListService foodListService)
        {
            _foodListService = foodListService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _foodListService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(FoodList foodList)
        {
            var result = _foodListService.Add(foodList);
            if (result.Success)
            {
                return Ok(result);  
            }

            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(FoodList foodList)
        {
            var result = _foodListService.Update(foodList);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(FoodList foodList)
        {
            var result = _foodListService.Delete(foodList);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}