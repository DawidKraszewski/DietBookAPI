using AutoMapper;
using CRUD_API.Models;
using LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_API.Profiles
{
    public class RecipeProfile : Profile
    {
        public RecipeProfile()
        {
            CreateMap<RecipeDto, RecipeViewModel>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ForMember(d => d.Author, o => o.MapFrom(s => s.Author))
                .ForMember(d => d.Photo, o => o.MapFrom(s => s.Photo))
                .ForMember(d=> d.CreatedDate, o => o.MapFrom(s => s.CreatedDate))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<RecipeWithDetailsDto, RecipeWithDetailsViewModel>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ForMember(d => d.Author, o => o.MapFrom(s => s.Author))
                .ForMember(d => d.Photo, o => o.MapFrom(s => s.Photo))
                .ForMember(d => d.CreatedDate, o => o.MapFrom(s => s.CreatedDate))
                .ForMember(d => d.Steps, o => o.MapFrom(s => s.Steps))
                .ForMember(d => d.RecipeIngredients, o => o.MapFrom(s => s.RecipeIngredients))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<RecipeCreateDto, RecipeCreateViewModel>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ForMember(d => d.Author, o => o.MapFrom(s => s.Author))
                .ForMember(d => d.Photo, o => o.MapFrom(s => s.Photo))
                .ForMember(d => d.CreatedDate, o => o.MapFrom(s => s.CreatedDate))
                .ForMember(d => d.Steps, o => o.MapFrom(s => s.Steps))
                .ForMember(d => d.RecipeIngredients, o => o.MapFrom(s => s.RecipeIngredients))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<RecipeEditDto, RecipeEditViewModel>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ForMember(d => d.Author, o => o.MapFrom(s => s.Author))
                .ForMember(d => d.Photo, o => o.MapFrom(s => s.Photo))
                .ForMember(d => d.NewPhoto, o => o.MapFrom(s => s.NewPhoto))
                .ForMember(d => d.CreatedDate, o => o.MapFrom(s => s.CreatedDate))
                .ForMember(d => d.Steps, o => o.MapFrom(s => s.Steps))
                .ForMember(d => d.RecipeIngredients, o => o.MapFrom(s => s.RecipeIngredients))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());
        }
    }
}
