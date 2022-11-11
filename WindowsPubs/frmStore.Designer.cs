namespace WindowsAppPubs
{
    partial class frmStore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTraerLista = new System.Windows.Forms.Button();
            this.gridStore = new System.Windows.Forms.DataGridView();
            this.btnTraerPorId = new System.Windows.Forms.Button();
            this.lblBuscarId = new System.Windows.Forms.Label();
            this.txtIdABuscar = new System.Windows.Forms.TextBox();
            this.btnAgregarStore = new System.Windows.Forms.Button();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtZIP = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblZIP = new System.Windows.Forms.Label();
            this.lblZIPAModif = new System.Windows.Forms.Label();
            this.lblProvAModif = new System.Windows.Forms.Label();
            this.lblCiudadAModif = new System.Windows.Forms.Label();
            this.lblDirecAModif = new System.Windows.Forms.Label();
            this.lblNombreAModif = new System.Windows.Forms.Label();
            this.lblIdAModif = new System.Windows.Forms.Label();
            this.txtZIPAModif = new System.Windows.Forms.TextBox();
            this.txtProvAModif = new System.Windows.Forms.TextBox();
            this.txtIdAModif = new System.Windows.Forms.TextBox();
            this.txtNombreAModif = new System.Windows.Forms.TextBox();
            this.txtDirecAModif = new System.Windows.Forms.TextBox();
            this.txtCiudadAModif = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtIdAEliminar = new System.Windows.Forms.TextBox();
            this.lblIdAEliminar = new System.Windows.Forms.Label();
            this.btnEliminarElemento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridStore)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraerLista
            // 
            this.btnTraerLista.Location = new System.Drawing.Point(42, 32);
            this.btnTraerLista.Name = "btnTraerLista";
            this.btnTraerLista.Size = new System.Drawing.Size(75, 23);
            this.btnTraerLista.TabIndex = 0;
            this.btnTraerLista.Text = "Mostrar Lista";
            this.btnTraerLista.UseVisualStyleBackColor = true;
            this.btnTraerLista.Click += new System.EventHandler(this.btnTraerLista_Click);
            // 
            // gridStore
            // 
            this.gridStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStore.Location = new System.Drawing.Point(42, 72);
            this.gridStore.Name = "gridStore";
            this.gridStore.Size = new System.Drawing.Size(240, 150);
            this.gridStore.TabIndex = 1;
            // 
            // btnTraerPorId
            // 
            this.btnTraerPorId.Location = new System.Drawing.Point(87, 376);
            this.btnTraerPorId.Name = "btnTraerPorId";
            this.btnTraerPorId.Size = new System.Drawing.Size(76, 40);
            this.btnTraerPorId.TabIndex = 2;
            this.btnTraerPorId.Text = "Traer Elemento";
            this.btnTraerPorId.UseVisualStyleBackColor = true;
            this.btnTraerPorId.Click += new System.EventHandler(this.btnTraerPorId_Click);
            // 
            // lblBuscarId
            // 
            this.lblBuscarId.AutoSize = true;
            this.lblBuscarId.Location = new System.Drawing.Point(18, 353);
            this.lblBuscarId.Name = "lblBuscarId";
            this.lblBuscarId.Size = new System.Drawing.Size(63, 13);
            this.lblBuscarId.TabIndex = 3;
            this.lblBuscarId.Text = "Id a buscar:";
            // 
            // txtIdABuscar
            // 
            this.txtIdABuscar.Location = new System.Drawing.Point(87, 350);
            this.txtIdABuscar.Name = "txtIdABuscar";
            this.txtIdABuscar.Size = new System.Drawing.Size(100, 20);
            this.txtIdABuscar.TabIndex = 4;
            // 
            // btnAgregarStore
            // 
            this.btnAgregarStore.Location = new System.Drawing.Point(443, 242);
            this.btnAgregarStore.Name = "btnAgregarStore";
            this.btnAgregarStore.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarStore.TabIndex = 5;
            this.btnAgregarStore.Text = "Agregar";
            this.btnAgregarStore.UseVisualStyleBackColor = true;
            this.btnAgregarStore.Click += new System.EventHandler(this.btnAgregarStore_Click);
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(418, 150);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtCiudad.TabIndex = 6;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(418, 124);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(418, 98);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(418, 72);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 9;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(418, 176);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(100, 20);
            this.txtProvincia.TabIndex = 10;
            // 
            // txtZIP
            // 
            this.txtZIP.Location = new System.Drawing.Point(418, 202);
            this.txtZIP.Name = "txtZIP";
            this.txtZIP.Size = new System.Drawing.Size(100, 20);
            this.txtZIP.TabIndex = 11;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(391, 75);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "ID:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(365, 101);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(357, 127);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 14;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(369, 153);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblCiudad.TabIndex = 15;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(358, 179);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 16;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblZIP
            // 
            this.lblZIP.AutoSize = true;
            this.lblZIP.Location = new System.Drawing.Point(385, 205);
            this.lblZIP.Name = "lblZIP";
            this.lblZIP.Size = new System.Drawing.Size(27, 13);
            this.lblZIP.TabIndex = 17;
            this.lblZIP.Text = "ZIP:";
            // 
            // lblZIPAModif
            // 
            this.lblZIPAModif.AutoSize = true;
            this.lblZIPAModif.Location = new System.Drawing.Point(575, 205);
            this.lblZIPAModif.Name = "lblZIPAModif";
            this.lblZIPAModif.Size = new System.Drawing.Size(27, 13);
            this.lblZIPAModif.TabIndex = 30;
            this.lblZIPAModif.Text = "ZIP:";
            // 
            // lblProvAModif
            // 
            this.lblProvAModif.AutoSize = true;
            this.lblProvAModif.Location = new System.Drawing.Point(548, 179);
            this.lblProvAModif.Name = "lblProvAModif";
            this.lblProvAModif.Size = new System.Drawing.Size(54, 13);
            this.lblProvAModif.TabIndex = 29;
            this.lblProvAModif.Text = "Provincia:";
            // 
            // lblCiudadAModif
            // 
            this.lblCiudadAModif.AutoSize = true;
            this.lblCiudadAModif.Location = new System.Drawing.Point(559, 153);
            this.lblCiudadAModif.Name = "lblCiudadAModif";
            this.lblCiudadAModif.Size = new System.Drawing.Size(43, 13);
            this.lblCiudadAModif.TabIndex = 28;
            this.lblCiudadAModif.Text = "Ciudad:";
            // 
            // lblDirecAModif
            // 
            this.lblDirecAModif.AutoSize = true;
            this.lblDirecAModif.Location = new System.Drawing.Point(547, 127);
            this.lblDirecAModif.Name = "lblDirecAModif";
            this.lblDirecAModif.Size = new System.Drawing.Size(55, 13);
            this.lblDirecAModif.TabIndex = 27;
            this.lblDirecAModif.Text = "Direccion:";
            // 
            // lblNombreAModif
            // 
            this.lblNombreAModif.AutoSize = true;
            this.lblNombreAModif.Location = new System.Drawing.Point(555, 101);
            this.lblNombreAModif.Name = "lblNombreAModif";
            this.lblNombreAModif.Size = new System.Drawing.Size(47, 13);
            this.lblNombreAModif.TabIndex = 26;
            this.lblNombreAModif.Text = "Nombre:";
            // 
            // lblIdAModif
            // 
            this.lblIdAModif.AutoSize = true;
            this.lblIdAModif.Location = new System.Drawing.Point(526, 72);
            this.lblIdAModif.Name = "lblIdAModif";
            this.lblIdAModif.Size = new System.Drawing.Size(76, 13);
            this.lblIdAModif.TabIndex = 25;
            this.lblIdAModif.Text = "ID a Modificar:";
            // 
            // txtZIPAModif
            // 
            this.txtZIPAModif.Location = new System.Drawing.Point(608, 202);
            this.txtZIPAModif.Name = "txtZIPAModif";
            this.txtZIPAModif.Size = new System.Drawing.Size(100, 20);
            this.txtZIPAModif.TabIndex = 24;
            // 
            // txtProvAModif
            // 
            this.txtProvAModif.Location = new System.Drawing.Point(608, 176);
            this.txtProvAModif.Name = "txtProvAModif";
            this.txtProvAModif.Size = new System.Drawing.Size(100, 20);
            this.txtProvAModif.TabIndex = 23;
            // 
            // txtIdAModif
            // 
            this.txtIdAModif.Location = new System.Drawing.Point(608, 72);
            this.txtIdAModif.Name = "txtIdAModif";
            this.txtIdAModif.Size = new System.Drawing.Size(100, 20);
            this.txtIdAModif.TabIndex = 22;
            // 
            // txtNombreAModif
            // 
            this.txtNombreAModif.Location = new System.Drawing.Point(608, 98);
            this.txtNombreAModif.Name = "txtNombreAModif";
            this.txtNombreAModif.Size = new System.Drawing.Size(100, 20);
            this.txtNombreAModif.TabIndex = 21;
            // 
            // txtDirecAModif
            // 
            this.txtDirecAModif.Location = new System.Drawing.Point(608, 124);
            this.txtDirecAModif.Name = "txtDirecAModif";
            this.txtDirecAModif.Size = new System.Drawing.Size(100, 20);
            this.txtDirecAModif.TabIndex = 20;
            // 
            // txtCiudadAModif
            // 
            this.txtCiudadAModif.Location = new System.Drawing.Point(608, 150);
            this.txtCiudadAModif.Name = "txtCiudadAModif";
            this.txtCiudadAModif.Size = new System.Drawing.Size(100, 20);
            this.txtCiudadAModif.TabIndex = 19;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(633, 242);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtIdAEliminar
            // 
            this.txtIdAEliminar.Location = new System.Drawing.Point(312, 350);
            this.txtIdAEliminar.Name = "txtIdAEliminar";
            this.txtIdAEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtIdAEliminar.TabIndex = 34;
            // 
            // lblIdAEliminar
            // 
            this.lblIdAEliminar.AutoSize = true;
            this.lblIdAEliminar.Location = new System.Drawing.Point(243, 353);
            this.lblIdAEliminar.Name = "lblIdAEliminar";
            this.lblIdAEliminar.Size = new System.Drawing.Size(66, 13);
            this.lblIdAEliminar.TabIndex = 33;
            this.lblIdAEliminar.Text = "Id a eliminar:";
            // 
            // btnEliminarElemento
            // 
            this.btnEliminarElemento.Location = new System.Drawing.Point(312, 376);
            this.btnEliminarElemento.Name = "btnEliminarElemento";
            this.btnEliminarElemento.Size = new System.Drawing.Size(76, 40);
            this.btnEliminarElemento.TabIndex = 32;
            this.btnEliminarElemento.Text = "Eliminar Elemento";
            this.btnEliminarElemento.UseVisualStyleBackColor = true;
            this.btnEliminarElemento.Click += new System.EventHandler(this.btnEliminarElemento_Click);
            // 
            // frmStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIdAEliminar);
            this.Controls.Add(this.lblIdAEliminar);
            this.Controls.Add(this.btnEliminarElemento);
            this.Controls.Add(this.lblZIPAModif);
            this.Controls.Add(this.lblProvAModif);
            this.Controls.Add(this.lblCiudadAModif);
            this.Controls.Add(this.lblDirecAModif);
            this.Controls.Add(this.lblNombreAModif);
            this.Controls.Add(this.lblIdAModif);
            this.Controls.Add(this.txtZIPAModif);
            this.Controls.Add(this.txtProvAModif);
            this.Controls.Add(this.txtIdAModif);
            this.Controls.Add(this.txtNombreAModif);
            this.Controls.Add(this.txtDirecAModif);
            this.Controls.Add(this.txtCiudadAModif);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblZIP);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtZIP);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.btnAgregarStore);
            this.Controls.Add(this.txtIdABuscar);
            this.Controls.Add(this.lblBuscarId);
            this.Controls.Add(this.btnTraerPorId);
            this.Controls.Add(this.gridStore);
            this.Controls.Add(this.btnTraerLista);
            this.Name = "frmStore";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.gridStore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTraerLista;
        private System.Windows.Forms.DataGridView gridStore;
        private System.Windows.Forms.Button btnTraerPorId;
        private System.Windows.Forms.Label lblBuscarId;
        private System.Windows.Forms.TextBox txtIdABuscar;
        private System.Windows.Forms.Button btnAgregarStore;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtZIP;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblZIP;
        private System.Windows.Forms.Label lblZIPAModif;
        private System.Windows.Forms.Label lblProvAModif;
        private System.Windows.Forms.Label lblCiudadAModif;
        private System.Windows.Forms.Label lblDirecAModif;
        private System.Windows.Forms.Label lblNombreAModif;
        private System.Windows.Forms.Label lblIdAModif;
        private System.Windows.Forms.TextBox txtZIPAModif;
        private System.Windows.Forms.TextBox txtProvAModif;
        private System.Windows.Forms.TextBox txtIdAModif;
        private System.Windows.Forms.TextBox txtNombreAModif;
        private System.Windows.Forms.TextBox txtDirecAModif;
        private System.Windows.Forms.TextBox txtCiudadAModif;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtIdAEliminar;
        private System.Windows.Forms.Label lblIdAEliminar;
        private System.Windows.Forms.Button btnEliminarElemento;
    }
}