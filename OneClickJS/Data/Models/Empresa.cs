using OneClickJS.Data.Models.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OneClickJS.Data.Models
{
    public class Empresa
    {
        public Empresa()
        {
            Empleos = new HashSet<Empleo>();
        }
        public int IdEmpresa { get; set; }
        public string NombreEmpresa { get; set; }
        public string DirectorEmpresa { get; set; }
        public string CorreoEmpresa { get; set; }
        public string ContraseniaEmpresa { get; set; }
        public string CalleEmpresa { get; set; }
        public string NumeroEmpresa { get; set; }
        public string CruzamientoEmpresa { get; set; }
        public string ColoniaEmpresa { get; set; }
        public string TelefonoEmpresa { get; set; }
        public string MunicipioEmpresa { get; set; }
        public string FotoEmpresa { get; set; }
        public string NivelEmpresa { get; set; }

        public string Direccion()
        {
            return $"Calle {CalleEmpresa}, #{NumeroEmpresa}, entre {CruzamientoEmpresa}, colonia {ColoniaEmpresa}";
        }

        public virtual ICollection<Empleo> Empleos { get; set; }
    }
}
