using CharityBox.Core;
using CharityBox.Shared.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityBox.Services.Abstract
{
    public interface ICategoryService
    {
        Task<Response<List<Category>>> GetAllCategories();

    }
}
