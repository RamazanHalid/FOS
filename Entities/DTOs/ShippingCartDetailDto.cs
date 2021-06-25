using Core.Entities;

namespace Entities.DTOs
{
    public class ShippingCartDetailDto:IDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string FoodName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}