using AutoMapper;
using CRUD_API.Models;
using LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_API.Profiles
{
    public class IngredientProfile : Profile
    {
        public IngredientProfile()
        {
            CreateMap<IngredientDto, IngredientViewModel>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ForMember(d => d.Unit, o => o.MapFrom(s => s.Unit))
                .ForMember(d => d.Quantity, o => o.MapFrom(s => s.Quantity))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<IngredientWithDetailsDto, IngredientWithDetailsViewModel>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ForMember(d => d.Unit, o => o.MapFrom(s => s.Unit))
                .ForMember(d => d.Quantity, o => o.MapFrom(s => s.Quantity))
                .ForMember(d=> d.IngredientRecipes, o=> o.MapFrom(s=>s.IngredientRecipes))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());
        }
    }
}
