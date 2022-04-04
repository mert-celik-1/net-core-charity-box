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
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) : base(context)
        {
        }

        private AppDbContext AppDbContext
        {
            get { return _context as AppDbContext; }
        }
    }

}
