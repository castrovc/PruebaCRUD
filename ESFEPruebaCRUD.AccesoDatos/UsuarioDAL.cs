using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using ESFEPruebaCRUD.EntidadesNegocio;

namespace ESFEPruebaCRUD.AccesoDatos
{
    public class UsuarioDAL
    {
        public static async Task<int> CrearAsync(Usuario pUsuario)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                bdContexto.Add(pUsuario);
                result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<int> ModificarAsync(Usuario pUsuario)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                var usuario= await bdContexto.Usuario.FirstOrDefaultAsync(s => s.Id == pUsuario.Id);
                usuario.Nombre = pUsuario.Nombre;
                usuario.CorreoElectronico = pUsuario.CorreoElectronico;
                usuario.Contrasena = pUsuario.Contrasena;
                bdContexto.Update(usuario);
                result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<int> EliminarAsync(Usuario pUsuario)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                var usuario= await bdContexto.Usuario.FirstOrDefaultAsync(s => s.Id == pUsuario.Id);
                bdContexto.Usuario.Remove(usuario);
                result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<Usuario> ObtenerPorIdAsync(Usuario pUsuario)
        {
            var usuario = new Usuario();
            using (var bdContexto = new BDContexto())
            {
                usuario = await bdContexto.Usuario.FirstOrDefaultAsync(s => s.Id == pUsuario.Id);
            }
            return usuario;
        }
        public static async Task<List<Usuario>> ObtenerTodosAsync()
        {
            var usuarios = new List<Usuario>();
            using (var bdContexto = new BDContexto())
            {
                usuarios = await bdContexto.Usuario.ToListAsync();
            }
            return usuarios;

        }
    }
}
