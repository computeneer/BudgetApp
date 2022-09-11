using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Domain.Entities
{
    public class Company : Entity
    {
        public string CompanyName { get; set; }
        public string CompanyCode { get; set; }
        public string LogoImageURL { get; set; }
        
    }
}
