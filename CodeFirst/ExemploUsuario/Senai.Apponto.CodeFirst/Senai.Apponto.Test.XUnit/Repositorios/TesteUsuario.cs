using Senai.Apponto.CodeFirst.Entidades;
using Senai.Apponto.CodeFirst.Interfaces.Repositorios;
using Senai.Apponto.CodeFirst.Repositorios;
using System;
using Xunit;

namespace Senai.Apponto.Test.XUnit.Repositorios
{
    public class TesteUsuario
    {
        private IUsuarioRepositorio repositorioUsuario;

        public TesteUsuario()
        {
            repositorioUsuario = new UsuarioRepositorio();
        }

        //Anotação de teste que realiza testes em um ponto determinado para uma funcionalidade.
        [Fact]
        public void UsuarioInvalido()
        {
            //Dados que são enviados à plataforma de teste a fim de verificar se o usuário está incorreto.
            var validacaoUsuario = repositorioUsuario.EfetuarLogin("Teste@paratestar.com", "132");
            Assert.Null(validacaoUsuario);
        }

        [Fact]
        public void UsuarioValido()
        {
            UsuarioDominio usuario = new UsuarioDominio()
            {
                Id = 1,
                Email = "fernando.guerra@sp.senai.br",
                Senha = "senai132"
            };

            //Dados que são enviados à plataforma de teste a fim de verificar se o usuário enviou um formulário sem enviar a senha.
            UsuarioDominio validarUsuario = repositorioUsuario.EfetuarLogin(usuario.Email, usuario.Senha);
            Assert.Equal(usuario.Email, validarUsuario.Email);
            Assert.Equal(usuario.Senha, validarUsuario.Senha);
        }

        [Fact]
        public void SenhaNaoEnviadaVerificaException()
        {
            Assert.Throws<ArgumentException>(() => repositorioUsuario.EfetuarLogin("Teste@paratestar.com", ""));
        }

        [Fact]
        public void SenhaNaoEnviadaVerificaMensagemException()
        {
            Action act = () => repositorioUsuario.EfetuarLogin("fernando.guerra@sp.senai.br", "");

            var exception = Assert.Throws<ArgumentException>(act);

            Assert.Equal("A senha não pode ser nula", exception.Message);
        }
    }
}
