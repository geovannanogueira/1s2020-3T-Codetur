using Senai.Apponto.CodeFirst.Contexto;
using Senai.Apponto.CodeFirst.Entidades;
using Senai.Apponto.CodeFirst.Interfaces.Repositorios;
using System;
using System.Linq;

namespace Senai.Apponto.CodeFirst.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        public UsuarioDominio EfetuarLogin(string email, string senha)
        {

            if (string.IsNullOrEmpty(senha))
                throw new ArgumentException("A senha não pode ser nula");

            using(AppontoContext ctx = new AppontoContext())
            {
                return ctx.Usuarios.FirstOrDefault(x => x.Email == email && x.Senha == senha);
            }
        }
    }
}
