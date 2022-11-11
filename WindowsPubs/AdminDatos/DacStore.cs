using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WindowsAppPubs;
using WindowsPubs.Models;
using static System.Windows.Forms.AxHost;

namespace WindowsAppPubs.AdminDatos
{
    public static class DacStore
    {
        private static PubsContext context = new PubsContext();
        public static List<Store> Lista()
        {
            List<Store> list = context.stores.ToList();

            return list;
        }

        public static Store TraerUno(string id)
        {

            Store storeAux = context.stores.Find(id);
            return storeAux;
        }

        public static int Nuevo(Store store)
        {
            context.stores.Add(store);
            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
        }

        public static int Modificar(Store store)
        {
            int filasAfectadas = 0;
            Store storeDB = TraerUno(store.stor_id);
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

        public static int Eliminar(Store store)
        {
            int filasAfectadas = 0;
            if (store != null)
            {
                context.stores.Remove(store);
                filasAfectadas = context.SaveChanges();
            }
            return filasAfectadas;
        }

    }
}