using Senai.CodeTur.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Senai.CodeTur.Dominio.Interfaces.Repositorios
{
    public interface IPacoteRepositorio
    {
        PacoteDominio CadastrarPacotes(PacoteDominio pacotes);

        PacoteDominio BuscarPorId(int id);

        List<PacoteDominio> ListarPacote();
    }
}
