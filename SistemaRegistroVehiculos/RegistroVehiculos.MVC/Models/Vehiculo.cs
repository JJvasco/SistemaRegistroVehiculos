using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroVehiculos.MVC.Models
{
    [Table("Vehiculos")]
    public class Vehiculo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "La placa es obligatoria")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "La placa debe tener entre 5 y 10 caracteres")]
        [Display(Name = "Placa")]
        [RegularExpression(@"^[A-Z0-9]+$", ErrorMessage = "Solo letras mayúsculas y números")]
        public string Placa { get; set; } = string.Empty;

        [Required(ErrorMessage = "La marca es obligatoria")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "La marca debe tener entre 2 y 50 caracteres")]
        [Display(Name = "Marca")]
        public string Marca { get; set; } = string.Empty;

        [Required(ErrorMessage = "El modelo es obligatorio")]
        [Range(1900, 2025, ErrorMessage = "El año debe estar entre 1900 y 2025")]
        [Display(Name = "Modelo")]
        public int Modelo { get; set; }

        [Display(Name = "Activo")]
        public bool Activo { get; set; } = true;
    }
}
