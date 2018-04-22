using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TopHundred.API.Entities
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<IcoItem> IcoItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<News> News { get; set; }   
    }
}
