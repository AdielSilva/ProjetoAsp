using Microsoft.EntityFrameworkCore;
using ProjetoAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAsp.Database
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Palavra> Palavras { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base (options)
        {
            Database.EnsureCreated();
        }
        
    }
}
