using Microsoft.EntityFrameworkCore;
using System;

namespace Practica03_Teoria.Data
{
    public class ApplicationDbContext: DbContext
    {

       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Practica03_Teoria.Models.Solicitudes> DataSolicitudes { get; set; }

        public DbSet<Practica03_Teoria.Models.Categorias> DataCategorias { get; set; }
        
    }
}