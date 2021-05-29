using Core.Entities;

namespace Entities.Concrete
{
    public class ShippingCart:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FoodListId { get; set; }
        public int Units { get; set; }
    }
}