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
    public class MessageService
        : EntityService<Message>, IMessageService
    {
        IUnitOfWork _unitOfWork;
        IMessageRepository _messageRepository;

        public MessageService(IUnitOfWork unitOfWork, IMessageRepository messageRepository)
          : base(unitOfWork, messageRepository)
        {
            _unitOfWork = unitOfWork;
            _messageRepository = messageRepository;
        }

        public Message GetById(long Id)
        {
            return _messageRepository.GetById(Id);
        }
    }
}
