using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ShippingCartManager:IShippingCartService
    {
        private IShippingCartDal _shippingCartDal;

        public ShippingCartManager(IShippingCartDal shippingCartDal)
        {
            _shippingCartDal = shippingCartDal;
        }


        public IDataResult<List<ShippingCart>> GetAll()
        {
            return new SuccessDataResult<List<ShippingCart>>(_shippingCartDal.GetAll());
        }

        public IDataResult<ShippingCart> GetBytId(int shippingCartId)
        {
            return new SuccessDataResult<ShippingCart>(_shippingCartDal.Get(s => s.Id == shippingCartId));
        }

        public IResult Add(ShippingCart shippingCart)
        {
            _shippingCartDal.Add(shippingCart);
            return new SuccessResult(Messages.ShippingCartAdded);
        }

        public IResult Update(ShippingCart shippingCart)
        {
            var result = _shippingCartDal.Get(s => s.Id == shippingCart.Id);
            if (result == null)
            {
                return new ErrorResult(Messages.ShippingCartNotFound);
            }
            _shippingCartDal.Update(shippingCart);
            return new SuccessResult(Messages.ShippingCartUpdated);
        }

        public IResult Delete(ShippingCart shippingCart)
        {
            var result = _shippingCartDal.Get(s => s.Id == shippingCart.Id);
            if (result == null)
            {
                return new ErrorResult(Messages.ShippingCartNotFound);
            }
            _shippingCartDal.Delete(shippingCart);
            return new SuccessResult(Messages.FoodDeleted);
        }
    }
}