using CharityBox.Core;
using CharityBox.Data.Abstract;
using CharityBox.Services.Abstract;
using CharityBox.Shared.Response;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityBox.Services.Concrete
{
    public class OrganizationService : IOrganizationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<User> _userManager;

        public OrganizationService(IUnitOfWork unitOfWork,UserManager<User> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }

        
        public async Task<Response<List<Organizations>>> GetAllOrganizations()
        {
            var organizations=await _unitOfWork.Organizations.GetAllAsync();

            return new Response<List<Organizations>>(ResultStatus.Success, (List<Organizations>)organizations);
        }

        public async Task<Response<Organizations>> GetOrganizationById(string id)
        {
            var organization = await _unitOfWork.Organizations.GetAsync(x => x.Id == id);

            return new Response<Organizations>(ResultStatus.Success, organization);
        }

        public async Task<NoDataResponse> PayToOrganizations(string organizationId,decimal price,string userId)
        {
            var organizaton = await _unitOfWork.Organizations.GetAsync(x => x.Id == organizationId);

            var user = await _userManager.FindByIdAsync(userId);

            if (user.Balance<price)
            {
                return new NoDataResponse(ResultStatus.Error, "Bakiye Yetersiz");

            }



            organizaton.Balance += price;
            user.Balance -= price;

            await _unitOfWork.CommitAsync();

            return new NoDataResponse(ResultStatus.Success);
        }
    }
}
