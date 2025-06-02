using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Title1)
                .NotEmpty().WithMessage("Başlık boş geçilemez")
                .MaximumLength(15).WithMessage("Maks Karakter uzunluğu 15'tir")
                .MinimumLength(5).WithMessage("En az 5 karakter olmalıdır");
            RuleFor(x=>x.Description1).NotEmpty().WithMessage("Açıklama boş geçilemez");
        }
    }
}
