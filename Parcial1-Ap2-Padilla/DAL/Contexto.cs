using Microsoft.EntityFrameworkCore;
using Parcial1_Ap2_Padilla.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1_Ap2_Padilla.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Articulos> Articulo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite(@"Data Source = C:\Users\Padilla\BD\Parcial1-Ap2.db");
        }
    }
}
