using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroVehiculos.WebAPI.Models
{
    [Table("Vehiculos")]
    public class Vehiculo
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(10)]
        public string Placa { get; set; } = string.Empty;
        
        [Required]
        [StringLength(50)]
        public string Marca { get; set; } = string.Empty;
        
        [Required]
        public int Modelo { get; set; }
        
        public bool Activo { get; set; }
    }
}
