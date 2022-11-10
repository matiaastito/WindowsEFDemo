using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEF.Models
{
    [Table("Producto")]
    public class Producto
    {
        public int ProductoID { get; set; }

        [Required] //campo obligatorio -- DB:NOT NULL
        [Column(TypeName = "varchar")] //tipo de datos de sql server
        [MaxLength(50)] //longitud max de la cadena
        public string Nombre { get; set; }

        [Required] //campo obligatorio -- DB:NOT NULL
        [Column(TypeName = "money")] //tipo de datos de sql server
        public decimal Precio { get; set; }

        #region propiedades de navegacion 
        public Categoria Categoria { get; set; }
        #endregion

        public Producto(int idProducto, string nombre, decimal precio)
        {
            ProductoID = idProducto;
            Nombre = nombre;
            Precio = precio;
        }

        public Producto()
        {
        }
    }
}
