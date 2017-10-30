using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BusinessLogic
{
    public interface IUserService
    {
        IEnumerable<User> GetItemsList();
        User GetItem(int id);
        void Create(User user);
        void Update(User user);
        void Delete(int id);
        void Save();
    }
}
