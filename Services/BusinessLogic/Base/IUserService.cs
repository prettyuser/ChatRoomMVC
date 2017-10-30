using DataAccess.Entities;
using Services.Service.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BusinessLogic.Base
{
    public interface IUserService 
        : IEntityService<User>
    {
        User GetById(int Id);
    }
}
