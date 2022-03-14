using OneClickJS.Data.Models.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OneClickJS.Data.Models
{
    public class Usuario
    {
        public Usuario()
        {
            Postulaciones = new HashSet<Postulacione>();
        }
        public int IdUsuario { get; set; }

        public string NombreUsuario { get; set; }

        public string ApellidoUsuario { get; set; }
        public string CorreoUsuario { get; set; }
        public string ContraseñaUsuario { get; set; }
        public string NivelUsuario { get; set; }
        public virtual ICollection<Postulacione> Postulaciones { get; set; }

        public string FullName()
        {
            return $"{NombreUsuario} {ApellidoUsuario}";
        }
    }
}
