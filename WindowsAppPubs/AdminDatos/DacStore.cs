using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WindowsAppPubs.Models;
using static System.Windows.Forms.AxHost;

namespace WindowsAppPubs.AdminDatos
{
    public static class DacStore
    {
        private static PubsContext context = new PubsContext();
        public static List <Author> Lista()
        {
            List<Author> list = context.Stores.ToList();

            return list;
        }

        public static Author TraerUno(string id)
        {

            Author storeAux = context.Stores.Find(id);
            return storeAux;
        }

        public static int Nuevo (Author store)
        {
            context.Stores.Add(store);
            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
        }

        public static int Modificar(Author store)
        {
            int filasAfectadas = 0;
            Author storeDB = TraerUno(store.stor_id);
            if (storeDB != null)
            {

                storeDB.stor_id = store.stor_id;
                storeDB.stor_name = store.stor_name;
                storeDB.stor_address = store.stor_address;
                storeDB.city = store.city;
                storeDB.state = store.state;
                storeDB.zip = store.zip;
                filasAfectadas = context.SaveChanges();
            }
           
            return filasAfectadas;
        }

        public static int Eliminar(Author store)
        {
            int filasAfectadas = 0;
            if (store != null)
            {
                context.Stores.Remove(store);
                filasAfectadas = context.SaveChanges();
            }
            return filasAfectadas;
        }

    }
}
