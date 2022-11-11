using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppNorthwind.Models;

namespace WindowsAppNorthwind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NorthwindContext context = new NorthwindContext();

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            
            
            Shipper shipper1= new Shipper() { CompanyName="Buenas", Phone="(503)444-5555" };

            context.Shippers.Add(shipper1);

            context.SaveChanges();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = 6; 
            Shipper shipperAux = context.Shippers.Find(id);
            if(shipperAux != null)
            {
                shipperAux.CompanyName = "Buenasssssss";
                shipperAux.Phone = "(503)425-4565";
            }
            context.SaveChanges();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            Shipper shipperAux = context.Shippers.Find(id);
            if (shipperAux != null)
            {
                context.Shippers.Remove(shipperAux);
            }
            context.SaveChanges();
        }

        private void btnTraerTodos_Click(object sender, EventArgs e)
        {
            List <Shipper> list = context.Shippers.ToList(); 
            gridShippers.DataSource = list;
        }
    }
}
