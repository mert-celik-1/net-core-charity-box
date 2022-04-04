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
    public class CampaignService : ICampaignService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<User> _userManager;

        public CampaignService(IUnitOfWork unitOfWork, UserManager<User> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }
        public async Task<NoDataResponse> CreateCampaign(Campaign campaign)
        {
            campaign.Id = Guid.NewGuid().ToString();

            await _unitOfWork.Campaigns.AddAsync(campaign);

            await _unitOfWork.CommitAsync();

            return new NoDataResponse(ResultStatus.Success, "Kampanya başarıyla eklendi");
        }

        public async Task<Response<List<Campaign>>> GetAllActiveCampaigns()
        {
            var campaigns = await _unitOfWork.Campaigns.GetAllAsync(x => x.IsDone == false && x.IsVerified==true &&x.IsRejected==false, x=>x.User,x=>x.Category);

            return new Response<List<Campaign>>(ResultStatus.Success, (List<Campaign>)campaigns);
        }

        public async Task<Response<List<Campaign>>> GetAllFinishedCampaigns()
        {
            var campaigns = await _unitOfWork.Campaigns.GetAllAsync(x => x.IsDone == true && x.IsVerified == true && x.IsRejected == false, x => x.User, x => x.Category);

            return new Response<List<Campaign>>(ResultStatus.Success, (List<Campaign>)campaigns);
        }

        public async Task<Response<Campaign>> GetCampaignById(string id)
        {
            var campaign = await _unitOfWork.Campaigns.GetAsync(x => x.Id==id, x => x.User, x => x.Category);

            return new Response<Campaign>(ResultStatus.Success, campaign);
        }

        public async Task<Response<List<Campaign>>> GetCampaignsByCategoryId(string categoryId)
        {
            var campaigns = await _unitOfWork.Campaigns.GetAllAsync(x => x.CategoryId == categoryId && x.IsDone==false, x => x.User, x => x.Category);

            return new Response<List<Campaign>>(ResultStatus.Success, (List<Campaign>)campaigns);
        }

        public async Task<NoDataResponse> PayToCampaigns(string campaignId, decimal price, string userId)
        {
            var campaign = await _unitOfWork.Campaigns.GetAsync(x => x.Id == campaignId);

            var user = await _userManager.FindByIdAsync(userId);

            if (user.Balance < price)
            {
                return new NoDataResponse(ResultStatus.Error, "Bakiye Yetersiz");

            }

            campaign.CurrentMoney += price;
            user.Balance -= price;


            if (campaign.CurrentMoney > campaign.Limit)
            {
                campaign.IsDone = true;
                await _unitOfWork.CommitAsync();

                return new NoDataResponse(ResultStatus.Success, "Kampanya Tamamlandı");
            }
          
            await _unitOfWork.CommitAsync();

            return new NoDataResponse(ResultStatus.Success);
        }

        public async Task<NoDataResponse> RejectPendingCampaignAdmin(string campaignId)
        {
            var campaing = await _unitOfWork.Campaigns.GetAsync(x => x.Id == campaignId);

            campaing.IsRejected = true;
            campaing.IsVerified = false;

            await _unitOfWork.CommitAsync();

            return new NoDataResponse(ResultStatus.Success);
        }

        public async Task<NoDataResponse> VerifyPendingCampaignAdmin(string campaignId)
        {
            var campaing = await _unitOfWork.Campaigns.GetAsync(x => x.Id == campaignId);

            campaing.IsRejected = false;
            campaing.IsVerified = true;

            await _unitOfWork.CommitAsync();

            return new NoDataResponse(ResultStatus.Success);
        }
    }
}
