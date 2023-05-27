using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gestaodeprojetos.Data;
using gestaodeprojetos.Models;
using gestaodeprojetos.Repositories.Interfaces;

namespace gestaodeprojetos.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationDbContext _context;

        public UsuarioRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Usuario> CreateUsuarioAsync(Usuario usuario)
        {
            await _context.Usuarios.AddAsync(usuario);
            await _context.SaveChangesAsync();
            return usuario;
        }
    }
}