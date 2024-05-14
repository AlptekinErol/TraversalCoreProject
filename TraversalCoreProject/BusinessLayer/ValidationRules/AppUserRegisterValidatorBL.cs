using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidatorBL : AbstractValidator<AppUserRegisterDTO>  // appuser Dto üzerinden kullanılmasını sağladık
    {
        public AppUserRegisterValidatorBL()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");

            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez");

            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez");

            // Username rules
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı alanı boş geçilemez");
            RuleFor(x => x.UserName).MinimumLength(5).WithMessage("Kullanıcı adı en az 5 karakter olmalı");
            RuleFor(x => x.UserName).MaximumLength(20).WithMessage("Kullanıcı adı en fazla 20s karakter olmalı");

            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez");

            // Confirm password rules
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre onay alanı boş geçilemez");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Şifreler birbirleri ile eşleşmiyor.");
        }
    }
}
