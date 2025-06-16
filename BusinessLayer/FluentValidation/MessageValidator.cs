using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class MessageValidator: AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x=>x.Email)
                .NotEmpty().WithMessage("E_posta Adresi boş geçilemez.")
                .EmailAddress().WithMessage("Lütfen geçerli bir e-posta adresi giriniz.");
            RuleFor(x => x.Content)
                .NotEmpty().WithMessage("İçerik boş geçilemez.")
                .MinimumLength(5).WithMessage("İçerik en az 5 karakter olmalıdır.")
                .MaximumLength(100).WithMessage("İçerik en fazla 100 karakter olmalıdır.");
        }
    }
}
