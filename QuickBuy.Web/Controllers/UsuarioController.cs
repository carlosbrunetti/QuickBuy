using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuickBuy.Dominio.Contratos;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Web.Controllers
{
    [Route("api/[Controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpPost]
        public IActionResult Post()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("VerificarUsuario")]
        public IActionResult VerificarUsuario([FromBody] Usuario usuario)
        {
            try
            {
                var usuarioRetorno = _usuarioRepositorio.Obter(usuario.Email,usuario.Senha);
                if (usuarioRetorno != null)
                    return Ok(usuarioRetorno);
                return BadRequest("Usuário inválido.");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }

    }
}