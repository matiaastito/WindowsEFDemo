using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEF.Models
{

    [Table("Categoria")] 
    public class Categoria
    {
        public int Id { get; set; }

        [Required] //campo obligatorio -- DB:NOT NULL
        [Column(TypeName ="varchar")] //tipo de datos de sql server
        [MaxLength(50)] //longitud max de la cadena
        public string Nombre { get; set; }

        #region propiedades de navegacion
        public List<Producto> Productos { get; set; }

        #endregion

        public Categoria(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public Categoria()
        {
        }
    }
}
