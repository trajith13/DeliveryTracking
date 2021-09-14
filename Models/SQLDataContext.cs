using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DeliveryTracking.Models
{
    public class SQLDataContext: DbContext
    {      
        public DbSet<Order> Orders { get; set; }
        public SQLDataContext(DbContextOptions<SQLDataContext> options) :base (options)
        {
            Database.EnsureCreated();
        }
    }

}
                                                              