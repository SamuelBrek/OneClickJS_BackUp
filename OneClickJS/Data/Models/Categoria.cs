using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OneClickJS.Data.Models
{
    public class Categoria
    {
        public Categoria()
        {
            Empleos = new HashSet<Empleo>();
        }
        public int IdCategoria { get; set; }

        public string NombreCategoria { get; set; } = default!;
        public virtual ICollection<Empleo> Empleos { get; set; }

    }
}
