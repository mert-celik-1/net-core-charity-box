using CharityBox.Core;
using CharityBox.Core.Repository;
using CharityBox.Data.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityBox.Data.Concrete
{
    public class TransactionRepository : GenericRepository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(DbContext context) : base(context)
        {
        }

        private AppDbContext AppDbContext
        {
            get { return _context as AppDbContext; }
        }
    }

}
