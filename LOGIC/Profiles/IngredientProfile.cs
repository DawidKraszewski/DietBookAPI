using AutoMapper;
using DATA.Models;
using LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Profiles
{
    public class IngredientProfile : Profile
    {
        public IngredientProfile()
        {
            CreateMap<IngredientDto, IngredientEntity>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<IngredientWithDetailsDto, IngredientEntity>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());
        }
    }
}
