using System.Data;
using Core.Entities.Concrete;
using Entities.Concrete;
using FluentValidation;

namespace Business.FluentValidation.ValidationRules
{
    public class UserValidator: AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.Email).NotEmpty();
        }
    }
}