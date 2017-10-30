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
    class MessageRepository
        :AbstractRepository, IRepository<Message>
    {
        private bool disposed = false;

        public Message Get(Expression<Func<Message, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Create(Message item)
        {
            _context.Messages.Add(item);
        }

        public void Delete(int id)
        {
            Message message = _context.Messages.Find(id);
            if (message != null)
            {
                _context.Messages.Remove(message);
            }
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public Message GetItem(int id)
        {
            return _context
                .Messages
                .Find(id);
        }

        public IEnumerable<Message> GetItemsList()
        {
            return _context
                .Messages;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Message item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
