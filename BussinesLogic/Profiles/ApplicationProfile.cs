using BussinesLogic.DTOs;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Profiles
{
    public class ApplicationProfile : AutoMapper.Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Phone, PhoneDto>()
                .ForMember(d => d.OSId, o => o.MapFrom(s => s.OperationSystemId))
                .ForMember(d => d.OSName, o => o.MapFrom(s => s.OperationSystem.Name));

            CreateMap<PhoneDto, Phone>()
                .ForMember(d => d.OperationSystemId, o => o.MapFrom(s => s.OSId));

            CreateMap<UserDto, User>()
                .ForMember(d => d.UserName, o => o.MapFrom(s => s.Email))
                .ForMember(d => d.Id, o => o.Ignore());
        }
    }
}
