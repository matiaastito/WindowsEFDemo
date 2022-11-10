using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Aula")]
    public class Aula
    {
        [ForeignKey("Materia")]
        public int Id { get; set; }

        [Required]
        public int Capacidad { get; set; }

        [Required]
        [Column(TypeName ="char")]
        [MaxLength(1)]
        public string Codigo { get; set; }

        #region propiedades de navegacion
        public Profesor Profesor { get; set; }
        public Materia Materia { get; set; }


        #endregion

    }
}
