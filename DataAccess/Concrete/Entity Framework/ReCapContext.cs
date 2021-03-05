using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Entity_Framework
{
    public class ReCapContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;DataBase=ReCapDB;Trusted_Connection=true");
           //hangi veri tabanına bağlanacagını gösterdik

        }
        //şimdi de db tabloları ile nesnelerimizi birleştiriyoruz.
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Color> Colors { get; set; }

    }
}
