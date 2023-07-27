using AutoMapper;
using MagicVilla_API.Modelos;
using MagicVilla_API.Modelos.Dto;

namespace MagicVilla_API
{
    public class Mappingconfig : Profile
    {
        public Mappingconfig()
        {
            CreateMap<Villa, VillaDto>();
            CreateMap<VillaDto, Villa>();

            CreateMap<Villa, VillaCreateDto>().ReverseMap(); ;
            
            CreateMap<Villa, VillaUpdateDto>();
            CreateMap<VillaUpdateDto, Villa>();
        }
    }
}
