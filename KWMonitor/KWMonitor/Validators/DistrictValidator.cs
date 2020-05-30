using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using KoronaWirusMonitor3.Models;

namespace KWMonitor.Validators
{
    public class DistrictValidator : AbstractValidator<District>
    {
        public DistrictValidator()
        {
            RuleFor(district => district.Name)
                .NotEmpty().WithMessage("To je puste i nie powinno byc")
                .MinimumLength(3).WithMessage("minimum 3 znaki")
                .MaximumLength(20).WithMessage("maksymalnie 20 znakow");
        }
    }
}
