using DataAccess.DBContext;
using DataAccess.Entities;
using DataAccess.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class UserRepository
        : GenericRepository<User>, IUserRepository
    {
        public UserRepository(EfDbContext context)
           : base(context)
        {

        }

        public override IEnumerable<User> GetAll()
        {
            return _entities.Set<User>().Include(x => x.Messages).AsEnumerable();
        }

        public User GetById(long id)
        {
            return _dbset.Include(x => x.Messages).Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
