using CharityBox.Core;
using CharityBox.Services.Dtos;
using CharityBox.Shared.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityBox.Services.Abstract
{
    public interface IUserService
    {
        Task<Response<UserDto>> CreateUserAsync(CreateUserDto createUserDto);

        Task<Response<User>> GetUserByNameAsync(string userName);
    }
}
