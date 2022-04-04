using AutoMapper;
using CharityBox.Core;
using CharityBox.Services.Abstract;
using CharityBox.Services.Dtos;
using CharityBox.Shared.Response;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityBox.Services.Concrete
{
     public class UserService : IUserService
    {

        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;


        public UserService(UserManager<User> userManager,IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<Response<UserDto>> CreateUserAsync(CreateUserDto createUserDto)
        {
            var user = _mapper.Map<User>(createUserDto);

            user.Id = Guid.NewGuid().ToString();

            var result = await _userManager.CreateAsync(user, createUserDto.Password);

            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(x => x.Description).ToList();

                return new Response<UserDto>(ResultStatus.Error, errors);
            }
            return new Response<UserDto>(ResultStatus.Success,"Kullanıcı başarıyla eklendi.");
        }

        public async Task<Response<User>> GetUserByNameAsync(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);

            if (user == null)
            {
                return new Response<User>(ResultStatus.Error,"Kullanıcı bulunamadı.");
            }

            return new Response<User>(ResultStatus.Success,user);

        }

    }
}
