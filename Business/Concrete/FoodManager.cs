using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class FoodManager:IFoodService
    {
        private IFoodDal _foodDal;

        public FoodManager(IFoodDal foodDal)
        {
            _foodDal = foodDal;
        }

        public IDataResult<List<Food>> GetAll()
        {
            return new SuccessDataResult<List<Food>>(_foodDal.GetAll());
        }

        public IDataResult<Food> GetBytId(int foodId)
        {
            return new SuccessDataResult<Food>(_foodDal.Get(f => f.Id == foodId));
        }

        
        [ValidationAspect(typeof(FoodValidator))]
        public IResult Add(Food food)
        {
            var result = BusinessRules.Run(CheckTimeForStateRules());
            if (result != null)
            {
                return result;
            }
            _foodDal.Add(food);
            return new SuccessResult(Messages.FoodAdded);
        }

        public IResult Update(Food food)
        {
            var result = _foodDal.Get(f => f.Id == food.Id);
            if (result == null)
            {
                return new ErrorResult(Messages.FoodNotFound);
            }
            _foodDal.Update(food);
            return new SuccessResult(Messages.FoodUpdated);
        }

        public IResult Delete(Food food)
        {
            var result = _foodDal.Get(f => f.Id == food.Id);
            if (result == null)
            {
                return new ErrorResult(Messages.FoodNotFound);
            }
            _foodDal.Delete(food);
            return new SuccessResult(Messages.FoodDeleted);
        }

        private IResult CheckTimeForStateRules()
        {
            if (DateTime.Now.Hour >= 15 && DateTime.Now.Hour <= 5)
            {
                return new ErrorResult(Messages.StateRules);
            }

            return new SuccessResult();
        }
        
    }
}