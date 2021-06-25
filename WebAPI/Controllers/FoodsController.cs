using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodsController : ControllerBase
    {
        private IFoodService _foodService;

        public FoodsController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        [HttpGet("getall")]
       public IActionResult GetAll()
        {
            var result = _foodService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

       [HttpPost("add")]
       public IActionResult Add(Food food)
       {
           var result = _foodService.Add(food);
           if (result.Success)
           {
               return Ok(result);
           }

           return BadRequest(result);
       }

       [HttpPost("update")]
       public IActionResult Update(Food food)
       {
           var result = _foodService.Update(food);
           if (result.Success)
           {
               return Ok(result);
           }

           return BadRequest(result);
       }

       [HttpPost("delete")]
       public IActionResult Delete(Food food)
       {
           var result = _foodService.Delete(food);
           if (result.Success)
           {
               return Ok(result);
           }

           return BadRequest(result);
       }
    }
}