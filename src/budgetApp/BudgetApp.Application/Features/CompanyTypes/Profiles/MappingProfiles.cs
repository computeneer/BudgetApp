using AutoMapper;
using BudgetApp.Application.Features.CompanyTypes.Commands.CreateCompanyType;
using BudgetApp.Application.Features.CompanyTypes.Dtos;
using BudgetApp.Application.Features.CompanyTypes.Models;
using BudgetApp.Domain.Entities;
using Core.Persistence.Listing;

namespace BudgetApp.Application.Features.CompanyTypes.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<CompanyType, CreateCompanyTypeCommand>().ReverseMap();
            CreateMap<CompanyType, CreatedCompanyTypeDto>().ReverseMap();

            CreateMap<IListing<CompanyType>, CompanyTypeListModel>().ReverseMap();
            CreateMap<CompanyType, CompanyTypeListDto>().ReverseMap();
        }
    }
}
