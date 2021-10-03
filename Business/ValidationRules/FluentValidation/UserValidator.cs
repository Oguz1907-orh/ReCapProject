using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.FirstName).MinimumLength(2);
            RuleFor(u => u.Email).Must(EndWith).WithMessage("Email adresi .com ile bitmelidir...");
            RuleFor(u => u.Password).NotEmpty();
            RuleFor(u => u.UserId).NotEmpty();
            
        }

        private bool EndWith(string arg)
        {
            return arg.EndsWith("com");
        }
    }
}
