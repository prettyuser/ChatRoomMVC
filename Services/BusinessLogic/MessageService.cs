using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Repositories;
using DataAccess.DBContext;

namespace Services.BusinessLogic
{
    public class MessageService
        :IMessageService
    {
        private BaseRepository<Message, EfDbContext> _baseRepository = null; 

        public void Create(Message message)
        {
            _baseRepository.Create(message);
        }

        public void Delete(int id)
        {
            _baseRepository.Delete(id);
        }

        public Message GetItem(int id)
        {
            return _baseRepository.GetItem(id);
        }

        public IEnumerable<Message> GetItemsList()
        {
            return _baseRepository.GetItemsList();
        }

        public void Save()
        {
            _baseRepository.Save();
        }

        public void Update(Message message)
        {
            _baseRepository.Update(message);
        }
    }
}
