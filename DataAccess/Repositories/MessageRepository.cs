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
    public class MessageRepository
        :GenericRepository<Message>, IMessageRepository
    {
        public MessageRepository(EfDbContext context)
           : base(context)
        {

        }

        public Message GetById(long id)
        {
            return FindBy(x => x.Id == id).FirstOrDefault();
        }
    }
}
