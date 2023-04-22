using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ESFEPruebaCRUD.EntidadesNegocio
{
    public class Rol

    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Descripcion es obligatorio")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string Descripcion { get; set; }
        public List<Usuario> Usuarios { get; set; }
    }

}

