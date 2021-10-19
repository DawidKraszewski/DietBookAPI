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
    public class RecipeProfile : Profile
    {
        public RecipeProfile()
        {
            CreateMap<RecipeDto, RecipeEntity>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ForMember(d => d.Author, o => o.MapFrom(s => s.Author))
                .ForMember(d => d.Photo, o => o.MapFrom(s => s.Photo))
                .ForMember(d => d.CreatedDate, o => o.MapFrom(s => s.CreatedDate))

                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<RecipeWithDetailsDto, RecipeEntity>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ForMember(d => d.Author, o => o.MapFrom(s => s.Author))
                .ForMember(d => d.CreatedDate, o => o.MapFrom(s => s.CreatedDate))
                .ForMember(d => d.RecipeIngredients, o=> o.Ignore())
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<RecipeCreateDto, RecipeEntity>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ForMember(d => d.Author, o => o.MapFrom(s => s.Author))
                .ForMember(d => d.CreatedDate, o => o.MapFrom(s => s.CreatedDate))
                .ForMember(d => d.RecipeIngredients, o => o.Ignore())
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<RecipeEditDto, RecipeEntity>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ForMember(d => d.Author, o => o.MapFrom(s => s.Author))
                .ForMember(d => d.CreatedDate, o => o.MapFrom(s => s.CreatedDate))
                .ForMember(d => d.RecipeIngredients, o => o.Ignore())
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());

        }
    }
}
