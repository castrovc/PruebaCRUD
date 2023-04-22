using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ESFEPruebaCRUD.EntidadesNegocio
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Rol")]
        [Required(ErrorMessage = "Rol es obligatorio")]
        [Display(Name = "Rol")]
        public int IdRol { get; set; }

        [Required(ErrorMessage = "Nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Correo Electronico es obligatorio")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string CorreoElectronico { get; set; }

        [Required(ErrorMessage = "Contraseña es obligatorio")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string Contrasena { get; set; }
        public Rol rol { get; set; }

    }
}
