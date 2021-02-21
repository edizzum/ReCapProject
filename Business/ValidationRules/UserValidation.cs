using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class UserValidation:AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(u => u.FirstName).MinimumLength(2);
            RuleFor(u => u.LastName).MinimumLength(2);
            RuleFor(u => u.UserId).NotEmpty();
            RuleFor(u => u.Password).MinimumLength(5);
            RuleFor(u => u.EMail).NotEmpty();
        }
    }
}
