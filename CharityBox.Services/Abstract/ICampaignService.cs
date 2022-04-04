using CharityBox.Core;
using CharityBox.Shared.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityBox.Services.Abstract
{
    public interface ICampaignService
    {
        Task<Response<List<Campaign>>> GetAllActiveCampaigns();
        Task<Response<List<Campaign>>> GetAllFinishedCampaigns();
        Task<Response<Campaign>> GetCampaignById(string id);
        Task<Response<List<Campaign>>> GetCampaignsByCategoryId(string categoryId);
        Task<NoDataResponse> CreateCampaign(Campaign campaign);
        Task<NoDataResponse> PayToCampaigns(string campaignId, decimal price, string userId);
        Task<NoDataResponse> VerifyPendingCampaignAdmin(string campaignId);
        Task<NoDataResponse> RejectPendingCampaignAdmin(string campaignId);

    }
}
