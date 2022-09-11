using BudgetApp.Application.Services;
using BudgetApp.Domain.Entities;
using BudgetApp.Persistance.Contexts;
using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Persistance.Repositories
{
    public class CompanyTypeRepository : EfRepositoryBase<CompanyType, BudgetAppDbContext>, ICompanyTypeRepository
    {
        public CompanyTypeRepository(BudgetAppDbContext context) : base(context)
        {
        }
    }
}
