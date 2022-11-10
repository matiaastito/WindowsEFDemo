using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Alumno")]
    public class Alumno
    {
        [Key]
        public int IdAlumno { get; set; }

        [Required]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }
        
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Apellido { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        #region propiedades de navegacion
        public Profesor Profesor { get; set; }
        #endregion
    }
}
