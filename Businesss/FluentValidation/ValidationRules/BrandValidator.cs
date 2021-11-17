using System.Data;
using Entities.Concrete;
using FluentValidation;

namespace Business.FluentValidation.ValidationRules
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.Name).NotEmpty();
            RuleFor(b => b.Name).MinimumLength(2);
            
        }
    }
}