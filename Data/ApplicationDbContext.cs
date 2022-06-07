using System;
using System.Collections.Generic;
using System.Text;
// using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Fablab.Models;

namespace Fablab.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Pasante> Pasantes {get; set;}
        public DbSet<Inventario> Inventarios {get; set;}
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        
    }
}