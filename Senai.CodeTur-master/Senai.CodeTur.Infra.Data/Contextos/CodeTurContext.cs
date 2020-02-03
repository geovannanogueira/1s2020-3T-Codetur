using Microsoft.EntityFrameworkCore;
using Senai.CodeTur.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Senai.CodeTur.Infra.Data.Contextos {
    public class CodeTurContext : DbContext {

        public DbSet<UsuarioDominio> Usuarios { get; set; }
        public DbSet<PacoteDominio> Pacotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS3TT;Initial Catalog=CodeTur;User ID=sa;Pwd=sa132");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<UsuarioDominio>().HasData(
                new UsuarioDominio()
                {
                    IdUsuario = 1,
                    Email = "fernando.guerra@sp.senai.br",
                    Senha = "senai132",
                    Tipo = "Administrador"
                }
                );

            modelBuilder.Entity<PacoteDominio>().HasData(
                new PacoteDominio()
                {
                    IdPacote = 1,
                    Titulo = "Intercâmbio",
                    Imagem = "https://www.estudarfora.org.br/app/uploads/2018/01/mestrado-no-MIT.jpg",
                    Descricao = "Instituto de Tecnologia de Massachusetts",
                    DataInicial = DateTime.Parse("2020-01-10"),
                    DataFinal = DateTime.Today,
                    País = "Massachusetts, Estados Unidos",
                    Ativo = true,
                    Oferta = false 
                }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
         