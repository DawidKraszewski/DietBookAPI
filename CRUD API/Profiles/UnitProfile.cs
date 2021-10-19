using AutoMapper;
using CRUD_API.Models;
using LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_API.Profiles
{
    public class UnitProfile : Profile
    {
        public UnitProfile()
        {
            CreateMap<UnitViewModel, UnitDto>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());
        }
    }
}
