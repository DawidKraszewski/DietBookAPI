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
    public class UnitProfile : Profile
    {
        public UnitProfile()
        {
            CreateMap<UnitDto, UnitEntity>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());
        }
    }
}
