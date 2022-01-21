using System.ComponentModel.DataAnnotations;

namespace Vehicles.API.Data.Entiities
{
    public class VehicleType
    {
        public int Id { get; set; }
        [Display(Name ="Tipo de Vehiculo")]
        [MaxLength(50, ErrorMessage ="El campo {0} tiene un maximo de {1} caracteres")]
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string Description { get; set; }
    }
}
