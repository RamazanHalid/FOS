using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RestaurantManager:IRestaurantService
    {
        private IRestaurantDal _restaurantDal;

        public RestaurantManager(IRestaurantDal restaurantDal)
        {
            _restaurantDal = restaurantDal;
        }

        public IDataResult<List<Restaurant>> GetAll()
        {
            return new SuccessDataResult<List<Restaurant>>(_restaurantDal.GetAll());
        }

        public IDataResult<Restaurant> GetBytId(int restaurantId)
        {
            throw new System.NotImplementedException();
        }

        public IResult Add(Restaurant restaurant)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(Restaurant restaurant)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(Restaurant restaurant)
        {
            throw new System.NotImplementedException();
        }
    }
}