using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class FoodListManager:IFoodListService
    {
        private IFoodListDal _foodListDal;

        public FoodListManager(IFoodListDal foodListDal)
        {
            _foodListDal = foodListDal;
        }

        public IDataResult<List<FoodList>> GetAll()
        {
            return new SuccessDataResult<List<FoodList>>(_foodListDal.GetAll());
        }

        public IDataResult<FoodList> GetBytId(int foodListId)
        {
            return new SuccessDataResult<FoodList>(_foodListDal.Get(f => f.Id == foodListId));
        }

        public IResult Add(FoodList foodList)
        {
           _foodListDal.Add(foodList);
           return new SuccessResult(Messages.FoodListAdded);
        }

        public IResult Update(FoodList foodList)
        {
            var result = _foodListDal.Get(f => f.Id == foodList.Id);
            if (result == null)
            {
                return new ErrorResult(Messages.FoodListNotFound);
            }
            _foodListDal.Update(foodList);
            return new SuccessResult(Messages.FoodListUpdated);
        }

        public IResult Delete(FoodList foodList)
        {
            var result = _foodListDal.Get(f => f.Id == foodList.Id);
            if (result == null)
            {
                return new ErrorResult(Messages.FoodListNotFound);
            }
            _foodListDal.Delete(foodList);
            return new SuccessResult(Messages.FoodListDeleted);
        }
    }
}