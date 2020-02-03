using Senai.CodeTur.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Senai.CodeTur.Dominio.Interfaces.Repositorios
{
    public interface IPacoteRepositorio
    {
        void CadastrarPacotes(PacoteDominio pacotes);

        List<PacoteDominio> ListarPacote();
    }
}
