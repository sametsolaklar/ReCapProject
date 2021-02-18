using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarDescription).NotEmpty();
            RuleFor(c => c.CarDescription).MinimumLength(2);
            RuleFor(c => c.CarDailyPrice).NotEmpty();
            RuleFor(c => c.CarDailyPrice).GreaterThan(0);
            RuleFor(c => c.CarDailyPrice).GreaterThanOrEqualTo(200).When(c => c.BrandId == 11);

        }
    }
}
