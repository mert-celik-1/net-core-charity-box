using CharityBox.Core;
using CharityBox.Data.Abstract;
using CharityBox.Services.Abstract;
using CharityBox.Shared.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityBox.Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Response<List<Category>>> GetAllCategories()
        {
            var categories=await _unitOfWork.Categories.GetAllAsync();

            return new Response<List<Category>>(ResultStatus.Success, (List<Category>)categories);
        }
    }
}
