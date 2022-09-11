using BudgetApp.Application.Services;
using Core.CrossCuttingConcerns.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Application.Features.CompanyTypes.Rules
{
    public class CompanyTypeBusinessRules
    {
        private readonly ICompanyTypeRepository _companyTypeRepository;

        public CompanyTypeBusinessRules(ICompanyTypeRepository companyTypeRepository)
        {
            _companyTypeRepository = companyTypeRepository;
        }

        public void CompanyTypeNameCanNotBeDuplicatedWhenCreated(string companyTypeName)
        {
            bool result = _companyTypeRepository.Query().Any(c => c.Name.ToLower()
                                                                       .Equals(companyTypeName.ToLower()));
            if(result)
            {
                throw new BusinessException("Given CompanyType name already exists");
            }
        }
    }
}
