using System;
using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfShippingCartDal:EfEntityRepositoryBase<ShippingCart,NorthwindContext>,IShippingCartDal
    {
        public List<ShippingCartDetailDto> GetShippingCartDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from s in context.ShippingCarts
                    join u in context.Users on s.UserId equals u.Id
                    join fl in context.FoodLists on s.FoodListId equals fl.Id
                    join f in context.Foods on fl.FoodId equals f.Id
                    select new ShippingCartDetailDto
                    {
                        Id = s.Id,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        Email = u.Email,
                        FoodName = f.Name,
                        Price = f.Price,
                        Stock = fl.Stock

                    };
                return result.ToList();

            }
        }
    }
}