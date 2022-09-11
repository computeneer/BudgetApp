using BudgetApp.Application.Features.CompanyTypes.Models;
using MediatR;

namespace BudgetApp.Application.Features.CompanyTypes.Queries.GetAllCompanyTypes
{
    public class GetListCompanyTypesQuery : IRequest<CompanyTypeListModel>
    {
    }
}
