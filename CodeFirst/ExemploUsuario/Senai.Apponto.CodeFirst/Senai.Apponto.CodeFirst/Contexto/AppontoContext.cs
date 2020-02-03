using Microsoft.EntityFrameworkCore;
using Senai.Apponto.CodeFirst.Entidades;
using System;

namespace Senai.Apponto.CodeFirst.Contexto
{
    public class AppontoContext : DbContext
    {
        public DbSet<UsuarioDominio> Usuarios { get; set; }
        public DbSet<HistoricoDominio> Historicos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS; initial catalog=apponto;integrated security=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioDominio>().HasData(new UsuarioDominio()
                {
                    Id = 1,
                    Nome = "Fernando",
                    Email = "fernando.guerra@sp.senai.br",
                    Senha = "senai132"
                });

            modelBuilder.Entity<HistoricoDominio>().HasData(new HistoricoDominio()
            {
                Id = 1,
                IdUsuario = 1,
                DataHora = DateTime.Now
            });

                
            base.OnModelCreating(modelBuilder);
        }
    }
}
