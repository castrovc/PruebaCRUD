using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using ESFEPruebaCRUD.EntidadesNegocio;



namespace ESFEPruebaCRUD.AccesoDatos
{
    public class BDContexto : DbContext
    {
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=PruebaTecnica2023CRUD;Integrated Security=True");
        }
    }
}
