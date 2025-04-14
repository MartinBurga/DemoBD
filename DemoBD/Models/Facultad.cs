using System.ComponentModel.DataAnnotations;

namespace DemoBD.Models
{
    public class Facultad
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public String Nombre { get; set; }
    }
}
