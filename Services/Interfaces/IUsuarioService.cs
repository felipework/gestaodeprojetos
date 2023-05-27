using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gestaodeprojetos.Models;

namespace gestaodeprojetos.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task<Usuario> CreateUsuarioAsync(Usuario usuario);
    }
}