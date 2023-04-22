using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using ESFEPruebaCRUD.EntidadesNegocio;

namespace ESFEPruebaCRUD.AccesoDatos
{
    public class RolDAL
    {
        public static async Task<int> CrearAsync(Rol pRol)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                bdContexto.Add(pRol);
                result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<int> ModificarAsync(Rol pRol)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                var rol = await bdContexto.Rol.FirstOrDefaultAsync(s => s.Id == pRol.Id);
                rol.Descripcion = pRol.Descripcion;
                bdContexto.Update(rol);
                result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<int> EliminarAsync(Rol pRol)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                var rol = await bdContexto.Rol.FirstOrDefaultAsync(s => s.Id == pRol.Id);
                bdContexto.Rol.Remove(rol);
                result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<Rol> ObtenerPorIdAsync(Rol pRol)
        {
            var rol = new Rol();
            using (var bdContexto = new BDContexto())
            {
                rol = await bdContexto.Rol.FirstOrDefaultAsync(s => s.Id == pRol.Id);
            }
            return rol;
        }
        public static async Task<List<Rol>> ObtenerTodosAsync()
        {
            var roles = new List<Rol>();
            using (var bdContexto = new BDContexto())
            {
                roles = await bdContexto.Rol.ToListAsync();
            }
            return roles;

        }
    }
}
