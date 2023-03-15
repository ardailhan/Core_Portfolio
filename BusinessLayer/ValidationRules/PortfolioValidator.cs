using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Portfolio name can not be empty..");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Portfolio visual can not be empty..");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Portfolio visual can not be empty..");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Portfolio price can not be empty..");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Portfolio value can not be empty..");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Portfolio name should be at least 5 charachters..");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Portfolio name should be at most 100 charachters..");
        }
    }
}
