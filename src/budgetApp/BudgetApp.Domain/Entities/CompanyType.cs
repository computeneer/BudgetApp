using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Domain.Entities
{
    public class CompanyType : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
     
        public CompanyType()
        {
        }

        public CompanyType(Guid id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
