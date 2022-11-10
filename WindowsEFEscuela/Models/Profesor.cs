﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Docente")]
    public class Profesor
    {
        [Column("Id")]
        public int ProfesorId { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Apellido { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Titulo { get; set; }

        #region propiedades de navegacion
        public List<Alumno> Alumnos { get; set; }
        public List<Materia> Materias { get; set; }
        public Aula Aula { get; set; }
        #endregion

    }
}
