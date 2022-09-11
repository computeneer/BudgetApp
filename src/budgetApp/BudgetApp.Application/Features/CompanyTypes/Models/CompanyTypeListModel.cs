using BudgetApp.Domain.Entities;
using Core.Persistence.Listing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Application.Features.CompanyTypes.Models
{
    public class CompanyTypeListModel : BaseListingModel
    {
        public IList<CompanyType> Items { get; set; }
    }
}
