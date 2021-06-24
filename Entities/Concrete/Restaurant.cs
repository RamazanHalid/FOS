using Core.Entities;

namespace Entities.Concrete
{
    public class Restaurant: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public int FoodListId { get; set; }
        public int Point { get; set; }
        public string City { get; set; }
    }
}