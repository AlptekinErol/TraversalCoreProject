﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator:AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.GuideNAme).NotEmpty().WithMessage("Lütfen rehber adını giriniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen rehber açıklamasını giriniz");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen görselini giriniz");
            RuleFor(x => x.GuideNAme).MaximumLength(30).WithMessage("Lütfen 30 karakteri geçmeyiniz");
            RuleFor(x => x.GuideNAme).MinimumLength(8).WithMessage("Lütfen 8 karakterden uzun bir isim giriniz");

        }
    }
}
