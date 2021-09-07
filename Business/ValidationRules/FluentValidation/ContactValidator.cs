using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(c => c.UserMail).NotEmpty().WithMessage("Mail alanı boş geçilemez!");
            RuleFor(c => c.Subject).NotEmpty().WithMessage("Konu alanı boş geçilemez!");
            RuleFor(c => c.Message).NotEmpty().WithMessage("Mesaj alanı boş geçilemez!");
            RuleFor(c => c.UserName).NotEmpty().WithMessage("Kullanıcı adı boş geçilemez!");
            RuleFor(c => c.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 (üç) karakter giriniz!");
            RuleFor(c => c.UserName).MinimumLength(3).WithMessage("Lütfen en az 3 (üç) karakter giriniz!");
            RuleFor(c => c.Subject).MaximumLength(50).WithMessage("Lütfen en fazla 50 (elli) karakter giriniz!");
        }
    }
}
