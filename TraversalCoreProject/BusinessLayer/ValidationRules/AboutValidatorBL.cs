using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidatorBL:AbstractValidator<About>
    {
        public AboutValidatorBL()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description boş bırakılamaz...");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Resim boş bırakılamaz...");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Description minimum 50 karakter olmalıdır..");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Description kısaltın lütfen....");
        }
    }
}
