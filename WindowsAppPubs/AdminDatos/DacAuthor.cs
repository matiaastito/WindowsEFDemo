using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsAppPubs.Models;

namespace WindowsAppPubs.AdminDatos
{
    public static class DacAuthor
    {
        private static PubsContext context = new PubsContext();
        public static List<Author> Lista()
        {
            List<Author> list = context.Authors.ToList();

            return list;
        }

        public static Author TraerUno(string id)
        {

            Author autorAux = context.Authors.Find(id);
            return autorAux;
        }

        public static int Nuevo(Author autor)
        {
            context.Authors.Add(autor);
            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
        }

        public static int Modificar(Author autor)
        {
            int filasAfectadas = 0;
            /* if (store != null)
             {
                 store.stor_id = txtIdAModif.Text;
                 store.stor_name = txtNombreAModif.Text;
                 store.stor_address = txtDirecAModif.Text;
                 store.city = txtCiudadAModif.Text;
                 store.state = txtProvAModif.Text;
                 store.zip = txtZIPAModif.Text;
                 filasAfectadas = context.SaveChanges();
             }
            */
            return filasAfectadas;
        }

        public static int Eliminar(Author autor)
        {
            int filasAfectadas = 0;
            if (autor != null)
            {
                context.Authors.Remove(autor);
                filasAfectadas = context.SaveChanges();
            }
            return filasAfectadas;
        }

    }
}
