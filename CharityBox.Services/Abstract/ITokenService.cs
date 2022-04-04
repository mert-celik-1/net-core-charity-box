using CharityBox.Core;
using CharityBox.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityBox.Services.Abstract
{
    public interface ITokenService
    {
        TokenDto CreateToken(User user);
    }
}
