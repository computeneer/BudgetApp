using BudgetApp.Domain.Entities;
using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Application.Services
{
    public interface ICompanyTypeRepository : IAsyncRepository<CompanyType>, IRepository<CompanyType>
    {
    }
}
