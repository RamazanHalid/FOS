using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
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
            return new SuccessDataResult<Restaurant>(_restaurantDal.Get(r => r.Id == restaurantId));
        }

        public IResult Add(Restaurant restaurant)
        {
            _restaurantDal.Add(restaurant);
            return new SuccessResult(Messages.RestaurantAdded);
        }

        public IResult Update(Restaurant restaurant)
        {
            var result = _restaurantDal.Get(r => r.Id == restaurant.Id);
            if (result==null)
            {
                return new ErrorResult(Messages.RestaurantNotFound);
            }
            _restaurantDal.Update(restaurant);
            return new SuccessResult(Messages.RestaurantUpdated);
        }

        public IResult Delete(Restaurant restaurant)
        {
            var result = _restaurantDal.Get(r => r.Id == restaurant.Id);
            if (result == null)
            {
                return new ErrorResult(Messages.RestaurantNotFound);
            }

            _restaurantDal.Delete(restaurant);
            return new SuccessResult(Messages.RestaurantDeleted);
        }
    }
}