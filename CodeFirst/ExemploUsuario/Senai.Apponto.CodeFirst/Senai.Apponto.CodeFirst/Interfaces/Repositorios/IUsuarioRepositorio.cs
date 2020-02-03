using Senai.Apponto.CodeFirst.Entidades;

namespace Senai.Apponto.CodeFirst.Interfaces.Repositorios
{
    public interface IUsuarioRepositorio
    {
        UsuarioDominio EfetuarLogin(string email, string senha);
    }
}
