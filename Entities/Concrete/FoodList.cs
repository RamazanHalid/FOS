using Core.Entities;

namespace Entities.Concrete
{
    public class FoodList: IEntity
    {
        public int Id { get; set; }
        public int FoodId { get; set; }
        public int Stock { get; set; }
    }
}