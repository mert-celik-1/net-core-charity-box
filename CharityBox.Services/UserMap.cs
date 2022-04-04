using AutoMapper;
using CharityBox.Core;
using CharityBox.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityBox.Services
{
    public class UserMap : Profile
    {
        public UserMap()
        {
            CreateMap<CreateUserDto, User>().ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();
        }
    }
}
