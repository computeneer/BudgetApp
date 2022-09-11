using AutoMapper;
using BudgetApp.Application.Features.CompanyTypes.Dtos;
using BudgetApp.Application.Features.CompanyTypes.Rules;
using BudgetApp.Application.Services;
using BudgetApp.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Application.Features.CompanyTypes.Commands.CreateCompanyType
{
    internal class CreateCompanyTypeCommandHandler : IRequestHandler<CreateCompanyTypeCommand, CreatedCompanyTypeDto>
    {
        private readonly ICompanyTypeRepository _companyTypeRepository;
        private readonly IMapper _mapper;
        private readonly CompanyTypeBusinessRules _companyTypeBusinessRules;

        public CreateCompanyTypeCommandHandler(IMapper mapper, ICompanyTypeRepository companyTypeRepository, CompanyTypeBusinessRules companyTypeBusinessRules)
        {
            _mapper = mapper;
            _companyTypeRepository = companyTypeRepository;
            _companyTypeBusinessRules = companyTypeBusinessRules;
        }

        public async Task<CreatedCompanyTypeDto> Handle(CreateCompanyTypeCommand request, CancellationToken cancellationToken)
        {
            _companyTypeBusinessRules.CompanyTypeNameCanNotBeDuplicatedWhenCreated(request.Name);

            CompanyType mappedCompanyType = _mapper.Map<CompanyType>(request);
            CompanyType companyType = await _companyTypeRepository.AddAsync(mappedCompanyType);
            CreatedCompanyTypeDto createdCompanyType = _mapper.Map<CreatedCompanyTypeDto>(companyType);

            return createdCompanyType;
        }
    }
}
