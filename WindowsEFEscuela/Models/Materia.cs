using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsEFEscuela.Models
{
    [Table("Materia")]
    public class Materia
    {
        [ForeignKey("Aula")]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Programa { get; set; }

        #region propiedades de navegacion
        public Profesor Profesor { get; set; }

        public Aula Aula { get; set; }

        #endregion
    }
}
