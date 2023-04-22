using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ESFEPruebaCRUD.AccesoDatos;
using ESFEPruebaCRUD.EntidadesNegocio;

namespace ESFEPruebaCRUD.LogicaNegocios
{
    public class RolBL
    {
        public async Task<int> CrerAsync(Rol pRol)
        {
            return await RolDAL.CrearAsync(pRol);
        }
        public async Task<int> ModificarAsync(Rol pRol)
        {
            return await RolDAL.ModificarAsync(pRol);
        }
        public async Task<int> EliminarAsync(Rol pRol)
        {
            return await RolDAL.EliminarAsync(pRol);
        }
        public async Task<Rol> ObtenerPorIdAsync(Rol pRol)
        {
            return await RolDAL.ObtenerPorIdAsync(pRol);
        }
        public async Task<List<Rol>> ObtenerTodosAsync()
        {
            return await RolDAL.ObtenerTodosAsync();
        }
    }
}
