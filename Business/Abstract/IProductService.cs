using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>>  GetAllByCategory(int id);
        IDataResult<Product> GetBytId(int productId);
        IDataResult<List<Product>>  GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>>  GetProductDetails();
        IResult Add(Product product);
        IResult Update(Product product);
        IResult AddTransactionalTest(Product product);
    }
}