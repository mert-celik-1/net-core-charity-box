using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityBox.Data.Abstract
{
    public interface IUnitOfWork
    {
        ICampaignRepository Campaigns { get; }
        ICategoryRepository Categories { get; }
        IOrganizationRepository Organizations { get; }
        ITransactionRepository Transactions { get; }
        IUserRefreshTokenRepository RefreshTokens { get; }

        Task CommitAsync();

        void Commit();
    }
}
