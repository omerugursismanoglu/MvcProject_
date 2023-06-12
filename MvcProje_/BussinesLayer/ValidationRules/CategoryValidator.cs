using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.ValidationRules
{
   public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator() //ctor tabtab yaparak construction için ekurallar yazılır.
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategoia adını boş geçemezsiniz!");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklamayı boş geçemezsiniz!");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen 3 karakterden fazla değer girşi yapınız...");
            RuleFor(x => x.CategoryDescription).MinimumLength(3).WithMessage("Lütfen 3 karakterden az değer girşi yapmayınız...");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Lütfen 20 karakterden fazla değer girşi yapmayınız...");
            RuleFor(x => x.CategoryName).MaximumLength(230).WithMessage("Lütfen 230 karakterden fazla değer girşi yapmayınız...");
        }
    }
}
