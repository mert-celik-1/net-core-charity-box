using CharityBox.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
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
    public class OrganizationsController : ControllerBase
    {
        private readonly IOrganizationService _organizationService;
        private readonly IUserService _userService;

        public OrganizationsController(IOrganizationService organizationService,IUserService userService)
        {
            _organizationService = organizationService;
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrganizations()
        {

            var organizations = await _organizationService.GetAllOrganizations();

            return Ok(organizations);
        }

        [HttpGet]
        public async Task<IActionResult> GetOrganizationById(string id)
        {
            var organizaton = await _organizationService.GetOrganizationById(id);

            return Ok(organizaton);
        }



        [HttpGet]
        [Authorize]
        public async Task<IActionResult> DonateToOrganization(string organizationId,decimal price)
        {
            var name = HttpContext.User.Identity.Name;

            var user = await _userService.GetUserByNameAsync(name);

            var organizations = await _organizationService.PayToOrganizations(organizationId,price,user.Data.Id);

            return Ok(organizations);
        }
    }
}
