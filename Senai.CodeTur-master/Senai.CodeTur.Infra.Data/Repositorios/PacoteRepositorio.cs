using Senai.CodeTur.Dominio.Entidades;
using Senai.CodeTur.Dominio.Interfaces.Repositorios;
using Senai.CodeTur.Infra.Data.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senai.CodeTur.Infra.Data.Repositorios
{
    public class PacoteRepositorio : IPacoteRepositorio
    {
        public void CadastrarPacotes( PacoteDominio pacotes ) { 
           using (CodeTurContext ctx = new CodeTurContext())
           {
                ctx.Pacotes.Add(pacotes);
                ctx.SaveChanges();
           }
        }

        public List<PacoteDominio> ListarPacote()
        {
            using (CodeTurContext ctx = new CodeTurContext())
            {
                return ctx.Pacotes.ToList();
            }
        }
    }
}
