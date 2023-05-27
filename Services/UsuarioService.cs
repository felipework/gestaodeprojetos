using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gestaodeprojetos.Models;
using gestaodeprojetos.Repositories.Interfaces;
using gestaodeprojetos.Services.Interfaces;

namespace gestaodeprojetos.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<Usuario> CreateUsuarioAsync(Usuario usuario)
        {
            var novoUsuario = await _usuarioRepository.CreateUsuarioAsync(usuario);
            //dominio
            return novoUsuario;
        }
    }
}