using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BusinessLogic
{
    public interface IMessageService
    {
        IEnumerable<Message> GetItemsList();
        Message GetItem(int id);
        void Create(Message message);
        void Update(Message message);
        void Delete(int id);
        void Save();
    }
}
