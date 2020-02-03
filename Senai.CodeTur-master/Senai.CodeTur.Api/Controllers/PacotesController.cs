using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.CodeTur.Dominio.Entidades;
using Senai.CodeTur.Infra.Data.Repositorios;

namespace Senai.CodeTur.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacotesController : ControllerBase
    {
        PacoteRepositorio pacoteRepositorio = new PacoteRepositorio();

        [HttpPost]
        public IActionResult CadastrarPacotes(PacoteDominio pacotes)
        {
            try
            {
                pacoteRepositorio.CadastrarPacotes(pacotes);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = " Eita, erro: " + ex.Message });
            }
        }

        [HttpGet]
        public IActionResult ListarPacotes()
        {
            return Ok(pacoteRepositorio.ListarPacote());
        }
    }
}