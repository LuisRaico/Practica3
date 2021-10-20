using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Practica3.Models;



namespace Practica3.Data
{
    public class ApplicationDbContext:IdentityDbContext
    {public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
            {
        }
        public DbSet<Solicitud> Solicitudes {get; set;}
        public DbSet<Usuario> Usuarios {get; set;}
        
    }
}