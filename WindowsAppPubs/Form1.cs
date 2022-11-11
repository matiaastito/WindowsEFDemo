using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppPubs.Models;

namespace WindowsAppPubs
{
    public partial class Form1 : Form
    {
        private PubsContext context = new PubsContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Publisher publisherPrueba = new Publisher();
            publisherPrueba.pub_name = txtNombre.Text;
            publisherPrueba.city = txtCiudad.Text;
            publisherPrueba.state = txtProvincia.Text;
            publisherPrueba.country = txtPais.Text;
            publisherPrueba.pub_id = Convert.ToString(9123);
            context.Publishers.Add(publisherPrueba);
            int filasAfectadas = context.SaveChanges();
            if (filasAfectadas != 0)
            {
                MessageBox.Show("Publisher añadido con exito");
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string id = txtIdAModif.Text;
            Publisher publisherAux = context.Publishers.Find(id);
            if (publisherAux != null)
            {
                publisherAux.pub_id = publisherAux.pub_id;
                publisherAux.pub_name = txtModifNombre.Text;
                publisherAux.city = txtModifCiudad.Text;
                publisherAux.state = txtModifProv.Text;
                publisherAux.country = txtModifPais.Text;
                int filasAfectadas = context.SaveChanges();
                if (filasAfectadas != 0)
                {
                    MessageBox.Show("Publisher modificado con exito");
                }
            }
        }

        private void btnEliminarPublisher_Click(object sender, EventArgs e)
        {
            string idEliminar = txtIdAEliminar.Text;
           
                Publisher publisherAux = context.Publishers.Find(idEliminar);
                context.Publishers.Remove(publisherAux);
                int filasAfectadas = context.SaveChanges();
                if (filasAfectadas != 0)
                {
                    MessageBox.Show("Publisher eliminado con exito");
                }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
