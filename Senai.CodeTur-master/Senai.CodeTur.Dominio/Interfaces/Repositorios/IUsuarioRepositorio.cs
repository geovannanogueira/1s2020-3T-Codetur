using Senai.CodeTur.Dominio.Entidades;
using Senai.CodeTur.Servico.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Senai.CodeTur.Dominio.Interfaces.Repositorios {
    public interface IUsuarioRepositorio {
        UsuarioDominio EfetuarLogin(LoginViewModel login);
    }
}
