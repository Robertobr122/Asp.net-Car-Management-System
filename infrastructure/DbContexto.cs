using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using minimal_api.Domain;

namespace minimal_api.infrastructure
{
    public class DbContexto : DbContext
    {
        public DbSet<Administrador> Administradores { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "String de conexão",
                ServerVersion.AutoDetect("String de conexão")
            );
        }
    }
}