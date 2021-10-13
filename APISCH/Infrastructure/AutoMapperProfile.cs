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
        }
    }
}