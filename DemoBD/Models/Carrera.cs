using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoBD.Models
{
    public class Carrera
    {
        [Key]

        public int Id { get; set; }
        [MaxLength]
        public String Nombre { get; set; }

        public int IdFacultad { get; set; }
        [ForeignKey("IdFacultad")]
        public Facultad? facultad { get; set; }
    }
}
