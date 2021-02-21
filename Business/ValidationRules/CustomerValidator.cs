using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class CustomerValidator: AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(cu=>cu.CustomerId).NotEmpty();
            RuleFor(cu => cu.CompanyName).MinimumLength(2);
        }
    }
}
