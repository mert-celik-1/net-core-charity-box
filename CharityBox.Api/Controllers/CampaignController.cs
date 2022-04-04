using CharityBox.Core;
using CharityBox.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharityBox.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CampaignController : ControllerBase
    {
        private readonly ICampaignService _campaignService;
        private readonly IUserService _userService;

        public CampaignController(ICampaignService campaignService, IUserService userService)
        {
            _campaignService = campaignService;
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetActiveCampaigns()
        {

            var campaigns = await _campaignService.GetAllActiveCampaigns();

            return Ok(campaigns);
        }

        [HttpGet]
        public async Task<IActionResult> GetFinishedCampaigns()
        {

            var campaigns = await _campaignService.GetAllFinishedCampaigns();

            return Ok(campaigns);
        }

        [HttpGet]
        public async Task<IActionResult> GetCampaignById(string id)
        {

            var campaigns = await _campaignService.GetCampaignById(id);

            return Ok(campaigns);
        }

        [HttpGet]
        public async Task<IActionResult> GetCampaignsByCategoryId(string categoryId)
        {

            var campaigns = await _campaignService.GetCampaignsByCategoryId(categoryId);

            return Ok(campaigns);
        }

        [HttpGet]
        public async Task<IActionResult> PayToCampaign(string campaignId, decimal price)
        {
            var name = HttpContext.User.Identity.Name;

            var user = await _userService.GetUserByNameAsync(name);

            var campaigns = await _campaignService.PayToCampaigns(campaignId, price, user.Data.Id);

            return Ok(campaigns);
        }

        [HttpGet]
        public async Task<IActionResult> RejectPendingCampaignAdmin(string campaignId)
        {
            var campaigns = await _campaignService.RejectPendingCampaignAdmin(campaignId);

            return Ok(campaigns);
        }

        [HttpGet]
        public async Task<IActionResult> VerifyPendingCampaignAdmin(string campaignId)
        {
            var campaigns = await _campaignService.VerifyPendingCampaignAdmin(campaignId);

            return Ok(campaigns);
        }

        [HttpPost]
        public async Task<IActionResult> AddCampaign(Campaign campaign)
        {
            var campaigns = await _campaignService.CreateCampaign(campaign);

            return Ok(campaigns);
        }


    }
}
