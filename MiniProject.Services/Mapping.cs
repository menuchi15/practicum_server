using AutoMapper;
using MiniProject.Common.DTOs;
using MiniProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Services
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<UserDetails, UserDetailsDTO>().ForMember(dest => dest.Children, opt => opt.MapFrom(src => src.Children)).ReverseMap();
            CreateMap<Child,ChildDTO>().ReverseMap();
        }
    }
}
