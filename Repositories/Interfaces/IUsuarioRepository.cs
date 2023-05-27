using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gestaodeprojetos.Models;

namespace gestaodeprojetos.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario> CreateUsuarioAsync(Usuario usuario);
    }
}