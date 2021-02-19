using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Using.Core.Entities;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.CompanyName).MinimumLength(2);
        }
    }
}
