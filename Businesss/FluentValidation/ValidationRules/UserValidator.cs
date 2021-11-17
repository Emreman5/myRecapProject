using System.Data;
using Entities.Concrete;
using FluentValidation;

namespace Business.FluentValidation.ValidationRules
{
    public class UserValidator: AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Firstname).NotEmpty();
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.Email).NotEmpty();
        }
    }
}