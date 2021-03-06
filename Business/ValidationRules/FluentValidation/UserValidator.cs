﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.UserFirstName).NotEmpty();
            RuleFor(u => u.UserLastName).NotEmpty();
            RuleFor(u => u.UserMail).NotEmpty();
            RuleFor(u => u.UserPassword).NotEmpty();
            RuleFor(u => u.UserFirstName).MinimumLength(2);
            RuleFor(u => u.UserLastName).MinimumLength(2);
            RuleFor(u => u.UserMail).MinimumLength(11);
            RuleFor(u => u.UserPassword).MinimumLength(8);
        }
    }
}
