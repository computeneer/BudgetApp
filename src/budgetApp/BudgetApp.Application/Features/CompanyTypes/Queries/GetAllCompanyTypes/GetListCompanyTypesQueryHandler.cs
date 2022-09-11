using AutoMapper;
using BudgetApp.Application.Features.CompanyTypes.Models;
using BudgetApp.Application.Services;
using BudgetApp.Domain.Entities;
using Core.Persistence.Listing;
using MediatR;

namespace BudgetApp.Application.Features.CompanyTypes.Queries.GetAllCompanyTypes
{
    public class GetListCompanyTypesQueryHandler : IRequestHandler<GetListCompanyTypesQuery, CompanyTypeListModel>
    {
        private readonly ICompanyTypeRepository _companyTypeRepository;
        private readonly IMapper _mapper;

        public GetListCompanyTypesQueryHandler(IMapper mapper, ICompanyTypeRepository companyTypeRepository)
        {
            _mapper = mapper;
            _companyTypeRepository = companyTypeRepository;
        }

        public async Task<CompanyTypeListModel> Handle(GetListCompanyTypesQuery request, CancellationToken cancellationToken)
        {
            IListing<CompanyType> companyTypesListing = await _companyTypeRepository.GetAllAsync();

            CompanyTypeListModel mappedCompanyTypeListing = _mapper.Map<CompanyTypeListModel>(companyTypesListing); 
            return mappedCompanyTypeListing;
        }
    }
}
