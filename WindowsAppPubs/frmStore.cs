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
    public partial class frmStore : Form
    {
        public frmStore()
        {
            InitializeComponent();
        }

        private void btnTraerLista_Click(object sender, EventArgs e)
        {
            List<Author> listStores = DacStore.Lista();
            gridStore.DataSource = listStores;
        }

        private void btnTraerPorId_Click(object sender, EventArgs e)
        {
            string id = txtIdABuscar.Text;
            Author storeAux = DacStore.TraerUno(id);
            MessageBox.Show("Nombre: " + storeAux.stor_name + "\nDireccion: " + storeAux.stor_address + "\nCiudad: " + storeAux.city);
        }

        private void btnAgregarStore_Click(object sender, EventArgs e)
        {
            Author storeAux = new Author();
            storeAux.stor_id = txtId.Text;
            storeAux.stor_name = txtNombre.Text;
            storeAux.stor_address = txtDireccion.Text;
            storeAux.city = txtCiudad.Text;
            storeAux.state = txtProvincia.Text;
            storeAux.zip = txtZIP.Text;

            int filasAfectadas = DacStore.Nuevo(storeAux);
            if (filasAfectadas != 0)
            {
                MessageBox.Show("STORE añadido con exito");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string id = txtIdAModif.Text;
            Author storeAux = new Author();

                storeAux.stor_id = txtIdAModif.Text;
                storeAux.stor_name = txtNombreAModif.Text;
                storeAux.stor_address = txtDirecAModif.Text;
                storeAux.city = txtCiudadAModif.Text;
                storeAux.state = txtProvAModif.Text;
                storeAux.zip = txtZIPAModif.Text;
                int filasAfectadas = DacStore.Modificar(storeAux);
                if (filasAfectadas != 0)
                {
                    MessageBox.Show("Store modificada con exito! Nuevos datos" + "\nNombre: " + storeAux.stor_name + "\nDireccion: " + storeAux.stor_address + "\nCiudad: " + storeAux.city);
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
            Author storeAux = DacStore.TraerUno(idAEliminar);
            filasEliminadas = DacStore.Eliminar(storeAux);
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
