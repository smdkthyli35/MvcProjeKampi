using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(w=>w.WriterName).NotEmpty().WithMessage("Yazar adını boş bırakamazsınız!");
            RuleFor(w=>w.WriterSurName).NotEmpty().WithMessage("Yazar soyadını boş geçemezsiniz!");
            RuleFor(w=>w.WriterAbout).NotEmpty().WithMessage("Hakkımda kısmını boş geçemezsiniz!");
            RuleFor(w=>w.WriterMail).NotEmpty().WithMessage("Mail kısmını boş geçemezsiniz!");
            RuleFor(w=>w.WriterPassword).NotEmpty().WithMessage("Şifre kısmını boş geçemezsiniz!");
            RuleFor(w=>w.WriterTitle).NotEmpty().WithMessage("Unvan kısmını boş geçemezsiniz!");
            RuleFor(w=>w.WriterName).MinimumLength(2).WithMessage("Lütfen en az iki karakter giriniz!");
            RuleFor(w=>w.WriterName).MaximumLength(50).WithMessage("Lütfen elli (50) karakterden fazla değer girişi yapmayınız!");
            RuleFor(w => w.WriterSurName).MinimumLength(2).WithMessage("Lütfen en az iki karakter giriniz!");
            RuleFor(w => w.WriterSurName).MaximumLength(50).WithMessage("Lütfen elli (50) karakterden fazla değer girişi yapmayınız!");
        }
    }
}
