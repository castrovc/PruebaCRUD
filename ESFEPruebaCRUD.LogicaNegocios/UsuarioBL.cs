using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ESFEPruebaCRUD.AccesoDatos;
using ESFEPruebaCRUD.EntidadesNegocio;

namespace ESFEPruebaCRUD.LogicaNegocios
{
    public class UsuarioBL
    {
        public async Task<int> CrerAsync(Usuario pUsuario)
        {
            return await UsuarioDAL.CrearAsync(pUsuario);
        }
        public async Task<int> ModificarAsync(Usuario pUsuario)
        {
            return await UsuarioDAL.ModificarAsync(pUsuario);
        }
        public async Task<int> EliminarAsync(Usuario pUsuario)
        {
            return await UsuarioDAL.EliminarAsync(pUsuario);
        }
        public async Task<Usuario> ObtenerPorIdAsync(Usuario pUsuario)
        {
            return await UsuarioDAL.ObtenerPorIdAsync(pUsuario);
        }
        public async Task<List<Usuario>> ObtenerTodosAsync()
        {
            return await UsuarioDAL.ObtenerTodosAsync();
        }
    }
}
