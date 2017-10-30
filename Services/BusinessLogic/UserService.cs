using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.DBContext;
using DataAccess.Repositories;

namespace Services.BusinessLogic
{
    public class UserService
        :IUserService
    {
        private BaseRepository<User, EfDbContext> _baseRepository = null;

        public void Create(User user)
        {
            _baseRepository.Create(user);
        }

        public void Delete(int id)
        {
            _baseRepository.Delete(id);
        }

        public User GetItem(int id)
        {
            return _baseRepository.GetItem(id);
        }

        public IEnumerable<User> GetItemsList()
        {
            return _baseRepository.GetItemsList();
        }

        public void Save()
        {
            _baseRepository.Save();
        }

        public void Update(User user)
        {
            _baseRepository.Update(user);
        }
    }
}
