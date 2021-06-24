using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRestaurantService
    {
        IDataResult<List<Restaurant>> GetAll();
        IDataResult<Restaurant> GetBytId(int restaurantId);
        IResult Add(Restaurant restaurant);
        IResult Update(Restaurant restaurant);
        IResult Delete(Restaurant restaurant);
    }
}