using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.DBContext;
using DataAccess.Repositories;
using Services.Service;
using DataAccess.UnitOfWork.Base;
using DataAccess.Repositories.Base;
using Services.BusinessLogic.Base;

namespace Services.BusinessLogic
{
    public class UserService
        :EntityService<User>, IUserService
    {
        IUnitOfWork _unitOfWork;
        IUserRepository _userRepository;

        public UserService(IUnitOfWork unitOfWork, IUserRepository userRepository)
          : base(unitOfWork, userRepository)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
        }

        public User GetById(int Id)
        {
            return _userRepository.GetById(Id);
        }
    }
}
