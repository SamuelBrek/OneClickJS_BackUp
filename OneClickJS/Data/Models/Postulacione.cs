using System.Collections.Generic;
using System.Linq;

namespace OneClickJS.Data.Models
{
    public partial class Postulacione
    {
        public int IdPostulacion { get; set; }
        public string ArchivoPostulacion { get; set; }
        public int IdEmpleo { get; set; }
        public int IdUsuario { get; set; }
        public string EstadoPostulacion { get; set; }

        public virtual Empleo IdEmpleoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }

        public string ObtenerNameEmpleo(IList<Empleo> empleos)
        {
            string nomempl = empleos.Where(emp => emp.IdEmpleo == IdEmpleo).Select(emp => emp.NombreEmpleo).FirstOrDefault();
            return nomempl;
        }
        public string ObtenerNameUsuario(IList<Usuario> usuarios)
        {
            string nomuser = usuarios.Where(usr => usr.IdUsuario == IdUsuario).Select(usr => usr.FullName()).FirstOrDefault();
            return nomuser;
        }
    }
}
