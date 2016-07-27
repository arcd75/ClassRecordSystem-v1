using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRecordSystem.Models
{
    class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Setting> Settings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new Initializer());
            modelBuilder.Entity<User>().ToTable("Users", "public");
            modelBuilder.Entity<Setting>().ToTable("Settings", "public");
        }
        public class Initializer : IDatabaseInitializer<DatabaseContext>
        {
            public void InitializeDatabase(DatabaseContext context)
            {
                if (!context.Database.Exists())
                {
                    context.Database.Create();
                    Seed(context);
                    context.SaveChanges();
                }
            }
            private void Seed(DatabaseContext context)
            {
                throw new NotImplementedException();
            }
        }
    }
}
