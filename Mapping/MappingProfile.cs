using Angular_2___Asp_Net.Controllers.Resources;
using Angular_2___Asp_Net.Models;
using AutoMapper;

namespace Angular_2___Asp_Net.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make,MakeResource>();
            CreateMap<Model,ModelResource>();
            
        }
    }
}