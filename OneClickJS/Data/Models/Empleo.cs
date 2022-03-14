using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneClickJS.Data.Models
{
    public partial class Empleo
    {
        public Empleo()
        {
            IdCategoria = -1;
            IdEmpresa = -1;
            Postulaciones = new HashSet<Postulacione>();
        }
        public int IdEmpleo { get; set; }
        public string NombreEmpleo { get; set; }
        public int VacantesEmpleo { get; set; }
        public string PrestacionesEmpleo { get; set; }
        public int SueldoEmpleo { get; set; }
        public string MunicipioEmpleo { get; set; }
        public string DescripcionEmpleo { get; set; }
        public string TipoEmpleo { get; set; }
        public string FotoEmpleo { get; set; }
        public int IdCategoria { get; set; }
        public int IdEmpresa { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual Empresa IdEmpresaNavigation { get; set; }
        public virtual ICollection<Postulacione> Postulaciones { get; set; }

        /*public IEnumerable<Categoria> ObtenerName(int id)
        {
            var categorias = cat.Where(yes => yes.IdCategoria == id).Include(p => p.NombreCategoria);
            return categorias;
        }*/

        public string ObtenerNameCat(IList<Categoria> categorias)
        {
            
            string nomcatt = categorias.Where(cat => cat.IdCategoria == IdCategoria).Select(cat => cat.NombreCategoria).FirstOrDefault();
            return nomcatt;
        }

        public string ObtenerNameEmpr(IList<Empresa> empresas)
        {
            string nomempr = empresas.Where(emp => emp.IdEmpresa == IdEmpresa).Select(emp => emp.NombreEmpresa).FirstOrDefault();
            return nomempr;
        }
        public string ObtenerNameCat2(Categoria categoria)
        {
            string nomecat2 = categoria.NombreCategoria;
            return nomecat2;
        }

        public string ObtenerNameEmpr2(Empresa empresa)
        {

            string nomeempr2 = empresa.NombreEmpresa;
            return nomeempr2;
        }


    }
}
