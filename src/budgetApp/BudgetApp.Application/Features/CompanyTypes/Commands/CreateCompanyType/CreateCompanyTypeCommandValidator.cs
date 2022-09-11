using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Application.Features.CompanyTypes.Commands.CreateCompanyType
{
    public class CreateCompanyTypeCommandValidator : AbstractValidator<CreateCompanyTypeCommand>
    {
        public CreateCompanyTypeCommandValidator()
        {
            RuleFor(c => c.Name).NotEmpty().MinimumLength(2).MaximumLength(25);
            RuleFor(c => c.Description).NotEmpty().MinimumLength(2).MaximumLength(150);
        }
    }
}
