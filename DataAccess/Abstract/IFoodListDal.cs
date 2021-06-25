using Core.DataAccess;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IFoodListDal:IEntityRepository<FoodList>
    {
        
    }
}