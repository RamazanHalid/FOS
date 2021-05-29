using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Food:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price  { get; set; }
        public string Content { get; set; }
        public string PrepareTime { get; set; }
    }
}