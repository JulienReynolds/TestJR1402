using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestJR1402.Models
{
     public class MVCContext : DbContext
    {
        public MVCContext(DbContextOptions<MVCContext> options)
            : base(options)
        {

        }
        public DbSet<Personne> LesPersonnes { get; set; }
        public DbSet<Cours> LesCours { get; set; }




    }
}

