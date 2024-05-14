using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.ContactUsValidationRules
{
    public class ContactUsValidator : AbstractValidator<SendMessaageDTO>
    {
        public ContactUsValidator()
        {
            // Mail validation
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş bırakılamaz");
            RuleFor(x => x.Mail).MaximumLength(100).WithMessage("Mail alanı en fazla 100 karakter olabilir");
            RuleFor(x => x.Mail).MinimumLength(5).WithMessage("Mail alanı en az 5 karakter olabilir");

            // mail subject validation
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu alanı boş bırakılamaz");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Konu alanı en fazla 100 karakter olabilir");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Konu alanı en az 5 karakter olabilir");

            // Message body ( content ) validation

            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Mesaj alanı boş geçilemez");
            RuleFor(x => x.MessageBody).MaximumLength(125).WithMessage("Mesaj alanı en fazla 125 karakter olabilir.");
            RuleFor(x => x.MessageBody).MinimumLength(20).WithMessage("Mesaj alanı en az 20 karakter olabilir.");
        }
    }
}
