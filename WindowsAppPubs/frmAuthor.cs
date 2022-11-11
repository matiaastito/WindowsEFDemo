using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppPubs.AdminDatos;
using WindowsAppPubs.Models;

namespace WindowsAppPubs
{
    public partial class frmAuthor : Form
    {

        public frmAuthor()
        {
            InitializeComponent();
        }
        private void btnTraerLista_Click(object sender, EventArgs e)
        {
            List<Author> listAuthors = DacAuthor.Lista();
            gridAuthor.DataSource = listAuthors;
        }

        private void btnTraerPorId_Click(object sender, EventArgs e)
        {
            string id = txtIdABuscar.Text;
            Author authorAux = DacAuthor.TraerUno(id);
            MessageBox.Show("Nombre: " + authorAux.au_fname + "\nApellido: " + authorAux.au_lname + "\nTelefono: " + authorAux.phone);
        }

        private void btnAgregarStore_Click(object sender, EventArgs e)
        {
            Author authorAux = new Author();
            authorAux.au_id = txtId.Text;
            authorAux.au_fname = txtNombre.Text;
            authorAux.au_lname = txtNombre.Text;
            authorAux.phone = txtNombre.Text;
            authorAux.address = txtDireccion.Text;
            authorAux.city = txtCiudad.Text;
            authorAux.state = txtProvincia.Text;
            authorAux.zip = txtZIP.Text;
            authorAux.contract = txtContract.Text;
            int filasAfectadas = DacAuthor.Nuevo(authorAux);
            if (filasAfectadas != 0)
            {
                MessageBox.Show("STORE añadido con exito");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string id = txtIdAModif.Text;
            Author authorAux = new Author();

            authorAux.stor_id = txtIdAModif.Text;
            authorAux.stor_name = txtNombreAModif.Text;
            authorAux.stor_address = txtDirecAModif.Text;
            authorAux.city = txtCiudadAModif.Text;
            authorAux.state = txtProvAModif.Text;
            authorAux.zip = txtZIPAModif.Text;
            int filasAfectadas = DacAuthor.Modificar(authorAux);
            if (filasAfectadas != 0)
            {
                MessageBox.Show("Store modificada con exito! Nuevos datos" + "\nNombre: " + authorAux.stor_name + "\nDireccion: " + authorAux.stor_address + "\nCiudad: " + authorAux.city);
            }

            else
            {
                MessageBox.Show("El id no se encuentra en la tabla de stores");
            }
        }

        private void btnEliminarElemento_Click(object sender, EventArgs e)
        {
            string idAEliminar = txtIdAEliminar.Text;
            int filasEliminadas = 0;
            Author storeAux = DacAuthor.TraerUno(idAEliminar);
            filasEliminadas = DacAuthor.Eliminar(storeAux);
            if (filasEliminadas != 0)
            {
                MessageBox.Show("Elemento eliminado con exito");
            }
            else
            {
                MessageBox.Show("El id no se encuentra en la tabla de stores");
            }
        }
    }
}
