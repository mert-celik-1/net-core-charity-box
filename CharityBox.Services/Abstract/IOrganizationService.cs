using CharityBox.Core;
using CharityBox.Shared.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityBox.Services.Abstract
{
    public interface IOrganizationService
    {
        Task<Response<List<Organizations>>> GetAllOrganizations();
        Task<Response<Organizations>> GetOrganizationById(string id);
        Task<NoDataResponse> PayToOrganizations(string organizationId, decimal price, string userId); 
    }
}
