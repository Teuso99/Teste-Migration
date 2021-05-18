using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteMigrations.Models;

namespace TesteMigrations.Data
{
    public class TesteDbContext : DbContext
    {
       public TesteDbContext (DbContextOptions<TesteDbContext> options) : base (options)
       {

       }

       public DbSet<User> User { get; set; }
    }
}
