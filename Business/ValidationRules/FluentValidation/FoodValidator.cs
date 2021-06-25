using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class FoodValidator:AbstractValidator<Food>
    {
        public FoodValidator()
        {
            RuleFor(f => f.Name).NotEmpty();
            RuleFor(f => f.Price).GreaterThan(0);
            RuleFor(f => f.PrepareTime).NotEmpty();
            RuleFor(f => f.Content).MaximumLength(100);

        }
    }
}