using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IFoodListService
    {
        IDataResult<List<FoodList>> GetAll();
        IDataResult<FoodList> GetBytId(int foodListId);
        IResult Add(FoodList foodList);
        IResult Update(FoodList foodList);
        IResult Delete(FoodList foodList);
    }
}