using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(r=>r.BrandName).NotEmpty();
            RuleFor(r=>r.BrandName).MinimumLength(2);
        }
    }
}
