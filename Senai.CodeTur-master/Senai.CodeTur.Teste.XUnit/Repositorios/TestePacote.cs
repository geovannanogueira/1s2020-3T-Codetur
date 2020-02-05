using Senai.CodeTur.Dominio.Entidades;
using Senai.CodeTur.Dominio.Interfaces.Repositorios;
using Senai.CodeTur.Infra.Data.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Senai.CodeTur.Teste.XUnit.Repositorios
{
    public class TestePacote
    {
        private IPacoteRepositorio _pacoteRepositorio;

        public TestePacote()
        {
            _pacoteRepositorio = new PacoteRepositorio();
        }

        [Fact]
        public void ListarPacote()
        {
            var lista = _pacoteRepositorio.ListarPacote();

            Assert.NotNull(lista);
        }

        [Fact]
        public void CadastrarPacotes()
        {

            var pacte = new PacoteDominio() {
                Titulo = "Titulo",
                Ativo = true,
                Oferta = false,
                DataFinal = DateTime.Today.AddDays(5),
                DataInicial = DateTime.Today,
                Descricao = "Descricao",
                Imagem = "imgem",
                País = "Pais"
            };

            var pacote = _pacoteRepositorio.CadastrarPacotes(pacte);

            Assert.NotNull(pacote);
        }
    }
}
