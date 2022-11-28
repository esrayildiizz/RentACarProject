﻿using Entities.Concrete;
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
            RuleFor(x => x.Description).NotEmpty().WithMessage("Araba Açıklamasını Boş Geçemezsiniz.");
        }
       
    }
}
