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

        [Required(ErrorMessage ="No puedes dejar este campo vacío!")]
        [StringLength(25, ErrorMessage = "El nombre de la categoría es demasiado largo!")]
        public string NombreCategoria { get; set; } = default!;
        public virtual ICollection<Empleo> Empleos { get; set; }

    }
}
