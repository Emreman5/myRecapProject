using Entities.Concrete;
using FluentValidation;

namespace Business.FluentValidation.ValidationRules
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty();
        }
       
    }
}