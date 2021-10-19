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

        
    }
}