using Senai.CodeTur.Dominio.Entidades;
using Senai.CodeTur.Dominio.Interfaces.Repositorios;
using Senai.CodeTur.Infra.Data.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senai.CodeTur.Infra.Data.Repositorios {
    public class UsuarioRepositorio : IUsuarioRepositorio {

        /// <summary>
        /// Verifica se o usuário existe
        /// </summary>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <returns>Retorna um objeto UsuarioDominio</returns>

        public UsuarioDominio EfetuarLogin(string email, string senha) {
            try {
                using (CodeTurContext ctx = new CodeTurContext()) {
                    return ctx.Usuarios.FirstOrDefault(x => x.Email == email && x.Senha == senha);
                }
            } catch (Exception e) {
                throw new Exception(e.Message);
            }
        }
    }
}
