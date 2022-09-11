using BudgetApp.Application.Services;
using BudgetApp.Persistance.Contexts;
using BudgetApp.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Infrastructure
{
    public static class PersistanceServiceRegistration
    {

        public static IServiceCollection AddPersistanceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BudgetAppDbContext>(options => 
                                                        options.UseSqlServer(
                                                            configuration.GetConnectionString("SQLServerConnectionString")));

            services.AddScoped<ICompanyTypeRepository, CompanyTypeRepository>();

            return services;
        }

    }
}
