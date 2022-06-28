using Hearit.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearit.Services
{
    public interface IUsuarioService
    {
        Task<Nuevo_Usuario> CreateUsuario(Nuevo_Usuario usuario);
        Task DeleteUsuario(Nuevo_Usuario usuario);
        Task<Nuevo_Usuario> GetUsuario(int id);
        Task<List<Nuevo_Usuario>> GetUsuarios();
        Task UpdateUsuario(Nuevo_Usuario usuario);

    }
}
