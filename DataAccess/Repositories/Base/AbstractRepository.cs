using DataAccess.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Base
{
    public abstract class AbstractRepository
    {
        protected EfDbContext _context = null;

        protected AbstractRepository(EfDbContext context)
        {
            _context = context;
        }

        protected AbstractRepository()
        {
            _context = new EfDbContext();
        }
    }
}
