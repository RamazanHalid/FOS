using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IShippingCartService
    {
        IDataResult<List<ShippingCart>> GetAll();
        IDataResult<ShippingCart> GetBytId(int shippingCartId);
        IResult Add(ShippingCart shippingCart);
        IResult Update(ShippingCart shippingCart);
        IResult Delete(ShippingCart shippingCart);

        IDataResult<List<ShippingCartDetailDto> > GetShippingCartDetails();
    }
}