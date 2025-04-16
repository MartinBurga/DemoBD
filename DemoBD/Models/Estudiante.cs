using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace DemoBD.Models
{
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public String Nombre { get; set; }
        [Required]
        public String Apellido { get; set; }

        public DateOnly FechaNacimiento { get; set; }
        [AllowNull]
        public Boolean tienebeca { get; set; }
        [ForeignKey("IdCarrera")]
        public int IdCarrera { get; set; }
        public Carrera? carrera { get; set; }

    }
}
