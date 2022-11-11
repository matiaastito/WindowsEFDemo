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
using WindowsPubs.Models;

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
            if (authorAux != null)
            {
                MessageBox.Show("Nombre: " + authorAux.au_fname + "\nApellido: " + authorAux.au_lname + "\nTelefono: " + authorAux.phone);
            }
            else
            {
                MessageBox.Show("El autor que intenta traer no se encuentra en la base");
            }
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
            authorAux.contract = Convert.ToBoolean(txtContract.Text);
            int filasAfectadas = DacAuthor.Nuevo(authorAux);
            if (filasAfectadas != 0)
            {
                MessageBox.Show("Autor añadido con exito");
            }
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            Author authorAux = new Author();

            authorAux.au_id = txtIdAModif.Text;
            authorAux.au_fname = txtNombreAModif.Text;
            authorAux.au_lname = txtApellidoAModif.Text;
            authorAux.phone = txtTelAModif.Text;
            authorAux.address = txtDirecAModif.Text;
            authorAux.city = txtCiudadAModif.Text;
            authorAux.state = txtProvAModif.Text;
            authorAux.zip = txtZIPAModif.Text;
            authorAux.contract = Convert.ToBoolean(txtContAModif.Text);
            int filasAfectadas = DacAuthor.Modificar(authorAux);
            if (filasAfectadas != 0)
            {
                MessageBox.Show("Autor modificada con exito! Nuevos datos" + "\nNombre: " + authorAux.au_fname + "\nApellido: " + authorAux.au_lname + "\nTelefono: " + authorAux.phone);
            }

            else
            {
                MessageBox.Show("El id no se encuentra en la tabla de Autores");
            }
        }

        private void btnEliminarElemento_Click(object sender, EventArgs e)
        {
            string idAEliminar = txtIdAEliminar.Text;
            int filasAfectadas = 0;
            Author storeAux = DacAuthor.TraerUno(idAEliminar);
            filasAfectadas = DacAuthor.Eliminar(storeAux);
            if (filasAfectadas != 0)
            {
                MessageBox.Show("Elemento eliminado con exito");
            }
            else
            {
                MessageBox.Show("El id no se encuentra en la tabla de Autores");
            }
        }
    }
}
