using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<AnnouncementAddDto>
    {
        public AnnouncementValidator()
        {
            // Title validation kuralları
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen başlığı boş geçmeyiniz");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen başlığı en az 5 karakter giriniz");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen başlığı en fazla 50 karakter giriniz");

            // Content validation kuralları
            RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen Duyuru içeriğini boş geçmeyiniz");
            RuleFor(x => x.Content).MinimumLength(20).WithMessage("Lütfen Duyuru içeriğini en az 20 karakter giriniz");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("Lütfen Duyuru içeriğine en fazla 500 karakter girişi yapınız");
        }
    }
}
