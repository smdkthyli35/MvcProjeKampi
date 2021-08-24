using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.CategoryName).NotEmpty().WithMessage("Kategori adını boş bırakamazsınız!");
            RuleFor(c => c.CategoryDescription).NotEmpty().WithMessage("Kategori açıklamasını boş geçemezsiniz!");
            RuleFor(c => c.CategoryName).MinimumLength(3).WithMessage("Lütfen en az üç karakter giriniz!");
            RuleFor(c => c.CategoryName).MaximumLength(20).WithMessage("Lütfen yirmi karakterden fazla değer girişi yapmayınız!");
        }
    }
}
