using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsPubs.Models;
using static System.Windows.Forms.AxHost;

namespace WindowsAppPubs.AdminDatos
{
    public static class DacAuthor
    {
        private static PubsContext context = new PubsContext();
        public static List<Author> Lista()
        {
            List<Author> list = context.authors.ToList();

            return list;
        }

        public static Author TraerUno(string id)
        {

            Author autorAux = context.authors.Find(id);
            return autorAux;
        }

        public static int Nuevo(Author autor)
        {
            context.authors.Add(autor);
            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
        }

        public static int Modificar(Author autor)
        {
            int filasAfectadas = 0;
            Author authorDB = TraerUno(autor.au_id);
             if (authorDB != null)
             {
                authorDB.au_id = autor.au_id;
                authorDB.au_fname = autor.au_fname;
                authorDB.au_lname = autor.au_lname;
                authorDB.phone = autor.phone;
                authorDB.address = autor.address;
                authorDB.city = autor.city;
                authorDB.state = autor.state;
                authorDB.zip = autor.zip;
                authorDB.contract = autor.contract;
                 filasAfectadas = context.SaveChanges();
             }
            return filasAfectadas;
        }


        public static int Eliminar(Author autor)
        {
            int filasAfectadas = 0;
            if (autor != null)
            {
                context.authors.Remove(autor);
                filasAfectadas = context.SaveChanges();
            }
            return filasAfectadas;
        }

    }
}