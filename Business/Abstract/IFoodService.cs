using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IFoodService
    {
        IDataResult<List<Food>> GetAll();
        IDataResult<Food> GetBytId(int foodId);
        IResult Add(Food food);
        IResult Update(Food food);
        IResult Delete(Food food);
    }
}