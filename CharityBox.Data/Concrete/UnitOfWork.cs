using CharityBox.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityBox.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private CampaignRepository _campaignRepository;
        private CategoryRepository _categoryRepository;
        private TransactionRepository _transactionRepository;
        private OrganizationRepository _organizationRepository;
        private UserRefreshTokenRepository _userRefreshTokenRepository;
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }


        public ICampaignRepository Campaigns => _campaignRepository ?? new CampaignRepository(_context);

        public ICategoryRepository Categories => _categoryRepository ?? new CategoryRepository(_context);

        public IOrganizationRepository Organizations => _organizationRepository ?? new OrganizationRepository(_context);

        public ITransactionRepository Transactions => _transactionRepository ?? new TransactionRepository(_context);

        public IUserRefreshTokenRepository RefreshTokens => _userRefreshTokenRepository ?? new UserRefreshTokenRepository(_context);

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
