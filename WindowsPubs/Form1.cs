using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsPubs.Models;

namespace WindowsPubs
{
    public partial class Form1 : Form
    {

        private PubsContext context = new PubsContext();
        private Publisher pubAux = new Publisher();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            pubAux.pub_id = txtId.Text;
            pubAux.pub_name = txtNombre.Text;
            pubAux.city = txtCiudad.Text;
            pubAux.state = txtProvincia.Text;
            pubAux.country = txtPais.Text;
            context.publishers.Add(pubAux);
            int filasAlmacenadas = context.SaveChanges();
            if (filasAlmacenadas != 0)
            {
                MessageBox.Show("Publisher añadido con exito!");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string idAModif = txtIdAModif.Text;
            pubAux = context.publishers.Find(idAModif);
            if (pubAux != null)
            {
                pubAux.pub_id = txtIdAModif.Text;
                pubAux.pub_name = txtNombreAModif.Text;
                pubAux.city = txtCiudAModif.Text;
                pubAux.state = txtProvAModif.Text;
                pubAux.country = txtPaisAModif.Text;
                int filasAlmacenadas = context.SaveChanges();
                if (filasAlmacenadas != 0)
                {
                    MessageBox.Show("Publisher modificado con exito!");
                }

            }
            else
            {
                MessageBox.Show("El id a modificar no se encuentra en la tabla.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string idAEliminar = txtIdAEliminar.Text;
            pubAux = context.publishers.Find(idAEliminar);
            if (pubAux != null)
            {
                context.publishers.Remove(pubAux);
                int filasAlmacenadas = context.SaveChanges();
                if (filasAlmacenadas != 0)
                {
                    MessageBox.Show("Publisher eliminado con exito!");
                }
            }
            else
            {
                MessageBox.Show("El id a eliminar no se encuentra en la tabla.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            List <Publisher> pubList = context.publishers.ToList();
            if (pubList != null)
            {
                gridPublisher.DataSource = pubList;
            }
        }
    }
}
