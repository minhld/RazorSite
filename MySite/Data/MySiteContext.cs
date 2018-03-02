using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MySite.Models
{
    public class MySiteContext : DbContext
    {
        public MySiteContext (DbContextOptions<MySiteContext> options)
            : base(options)
        {
        }

        public DbSet<MySite.Models.User> User { get; set; }
    }
}
