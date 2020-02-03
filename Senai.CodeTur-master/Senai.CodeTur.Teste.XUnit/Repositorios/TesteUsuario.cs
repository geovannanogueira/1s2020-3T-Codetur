using Senai.CodeTur.Dominio.Entidades;
using Senai.CodeTur.Dominio.Interfaces.Repositorios;
using Senai.CodeTur.Infra.Data.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Senai.CodeTur.Teste.XUnit.Repositorios {
    public class TesteUsuario {

        private IUsuarioRepositorio _usuarioRepositorio;

        public TesteUsuario() {
            _usuarioRepositorio = new UsuarioRepositorio();
        }

        [Fact]
        public void UsuarioInvalido() {
            var usuario = _usuarioRepositorio.EfetuarLogin("admin@admin.com","1112");

            Assert.Null(usuario);
        }

        [Fact]
        public void UsuarioValido() {
            var usuario = _usuarioRepositorio.EfetuarLogin("fernando.guerra@sp.senai.br", "senai132");

            Assert.NotNull(usuario);
        }

        [Fact]
        public void UsuarioValidoDadosCorretos() {
            UsuarioDominio usuario = new UsuarioDominio()
            {
                Email = "fernando.guerra@sp.senai.br",
                Senha = "senai132"
            };

            var usuarioRetorno = _usuarioRepositorio.EfetuarLogin(usuario.Email, usuario.Senha);

            Assert.Equal(usuarioRetorno.Email,usuario.Email);
            Assert.Equal(usuarioRetorno.Senha,usuario.Senha);
        }

    }
}
