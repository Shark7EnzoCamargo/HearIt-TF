using Hearit.DataAccess;
using Hearit.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearit.Services
{
    public class UsuarioService : IUsuarioService  
    {
        private readonly HearitDbContext _context;

        public UsuarioService(HearitDbContext context)
        {
            this._context = context;
        }

        public async Task<Nuevo_Usuario> CreateUsuario(Nuevo_Usuario usuario)
        {
            await _context.Usuarios.AddAsync(usuario);
            await _context.SaveChangesAsync();

            return usuario;
        }

        public async Task DeleteUsuario(Nuevo_Usuario usuario)
        {
            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
        }

        public async Task<Nuevo_Usuario> GetUsuario(int id)
        {
            return await _context.Usuarios.Where(g => g.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Nuevo_Usuario>> GetUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public async Task UpdateUsuario(Nuevo_Usuario usuario)
        {
            _context.Entry(usuario).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }  

    }
}
