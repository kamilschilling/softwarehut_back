using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using KoronaWirusMonitor3.Models;

namespace KWMonitor.Validators
{
    public class RegionValidator : AbstractValidator<Region>
    {
        public RegionValidator()
        {
            RuleFor(region => region.Name)
                .NotEmpty().WithMessage("To je puste i nie powinno byc")
                .MinimumLength(3).WithMessage("minimum 3 znaki")
                .MaximumLength(20).WithMessage("maksymalnie 20 znakow");
        }

    }
}
