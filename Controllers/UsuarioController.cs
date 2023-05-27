using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gestaodeprojetos.Models;
using gestaodeprojetos.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace gestaodeprojetos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        public async Task<ActionResult> Create(Usuario usuario)
        {
            await _usuarioService.CreateUsuarioAsync(usuario);
            return Created("api/usuario/" + usuario.Id, usuario);
        }
    }
}