using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBContext
{
    public class EfDbContext : DbContext
    {
        public EfDbContext() :
            base("DefaultConnection")
        {
            
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Message> Messages { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<Message>()
        //    //    .HasMany(z => z.MessageText)
        //    //    .WithRequired(y => y.User);

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
