using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class ProductValidator: AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x=>x.Price)
                .NotEmpty().WithMessage("Boş Geçilemez")
                .GreaterThan(0).WithMessage("Fiyat 0'dan büyük olmalıdır");
        }
    }
}
