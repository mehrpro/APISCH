using APISCH.DTO;
using APISCH.Entities;
using AutoMapper;

namespace APISCH.Infrastructure
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ImportExport, ImportExportDto>();
            CreateMap<Company, CompanyDto>();
            CreateMap<CompanyCreateDto, Company>();
            CreateMap<PersonCreateDto, Person>();
            CreateMap<Person, PersonDto>().ForMember(f => f.FullName, opts =>
                opts.MapFrom(x => string.Join(' ', x.FName, x.LName)));
        }
    }
}