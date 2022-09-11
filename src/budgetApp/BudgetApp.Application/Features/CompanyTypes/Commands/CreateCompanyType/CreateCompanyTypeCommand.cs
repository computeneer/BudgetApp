using BudgetApp.Application.Features.CompanyTypes.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Application.Features.CompanyTypes.Commands.CreateCompanyType
{
    public class CreateCompanyTypeCommand : IRequest<CreatedCompanyTypeDto>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
