namespace WindowsAppPubs
{
    partial class frmAuthor
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
            this.txtIdAEliminar = new System.Windows.Forms.TextBox();
            this.lblIdAEliminar = new System.Windows.Forms.Label();
            this.btnEliminarElemento = new System.Windows.Forms.Button();
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
            this.lblZIP = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtZIP = new System.Windows.Forms.TextBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.btnAgregarStore = new System.Windows.Forms.Button();
            this.txtIdABuscar = new System.Windows.Forms.TextBox();
            this.lblBuscarId = new System.Windows.Forms.Label();
            this.btnTraerPorId = new System.Windows.Forms.Button();
            this.gridAuthor = new System.Windows.Forms.DataGridView();
            this.btnTraerLista = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblContract = new System.Windows.Forms.Label();
            this.txtContract = new System.Windows.Forms.TextBox();
            this.lblTelefonoAModif = new System.Windows.Forms.Label();
            this.txtTelAModif = new System.Windows.Forms.TextBox();
            this.lblApellidoAModif = new System.Windows.Forms.Label();
            this.txtApellidoAModif = new System.Windows.Forms.TextBox();
            this.lblContractAModif = new System.Windows.Forms.Label();
            this.txtContAModif = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdAEliminar
            // 
            this.txtIdAEliminar.Location = new System.Drawing.Point(349, 351);
            this.txtIdAEliminar.Name = "txtIdAEliminar";
            this.txtIdAEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtIdAEliminar.TabIndex = 68;
            // 
            // lblIdAEliminar
            // 
            this.lblIdAEliminar.AutoSize = true;
            this.lblIdAEliminar.Location = new System.Drawing.Point(280, 354);
            this.lblIdAEliminar.Name = "lblIdAEliminar";
            this.lblIdAEliminar.Size = new System.Drawing.Size(66, 13);
            this.lblIdAEliminar.TabIndex = 67;
            this.lblIdAEliminar.Text = "Id a eliminar:";
            // 
            // btnEliminarElemento
            // 
            this.btnEliminarElemento.Location = new System.Drawing.Point(349, 377);
            this.btnEliminarElemento.Name = "btnEliminarElemento";
            this.btnEliminarElemento.Size = new System.Drawing.Size(76, 40);
            this.btnEliminarElemento.TabIndex = 66;
            this.btnEliminarElemento.Text = "Eliminar Elemento";
            this.btnEliminarElemento.UseVisualStyleBackColor = true;
            this.btnEliminarElemento.Click += new System.EventHandler(this.btnEliminarElemento_Click);
            // 
            // lblZIPAModif
            // 
            this.lblZIPAModif.AutoSize = true;
            this.lblZIPAModif.Location = new System.Drawing.Point(612, 261);
            this.lblZIPAModif.Name = "lblZIPAModif";
            this.lblZIPAModif.Size = new System.Drawing.Size(27, 13);
            this.lblZIPAModif.TabIndex = 65;
            this.lblZIPAModif.Text = "ZIP:";
            // 
            // lblProvAModif
            // 
            this.lblProvAModif.AutoSize = true;
            this.lblProvAModif.Location = new System.Drawing.Point(585, 235);
            this.lblProvAModif.Name = "lblProvAModif";
            this.lblProvAModif.Size = new System.Drawing.Size(54, 13);
            this.lblProvAModif.TabIndex = 64;
            this.lblProvAModif.Text = "Provincia:";
            // 
            // lblCiudadAModif
            // 
            this.lblCiudadAModif.AutoSize = true;
            this.lblCiudadAModif.Location = new System.Drawing.Point(596, 209);
            this.lblCiudadAModif.Name = "lblCiudadAModif";
            this.lblCiudadAModif.Size = new System.Drawing.Size(43, 13);
            this.lblCiudadAModif.TabIndex = 63;
            this.lblCiudadAModif.Text = "Ciudad:";
            // 
            // lblDirecAModif
            // 
            this.lblDirecAModif.AutoSize = true;
            this.lblDirecAModif.Location = new System.Drawing.Point(584, 183);
            this.lblDirecAModif.Name = "lblDirecAModif";
            this.lblDirecAModif.Size = new System.Drawing.Size(55, 13);
            this.lblDirecAModif.TabIndex = 62;
            this.lblDirecAModif.Text = "Direccion:";
            // 
            // lblNombreAModif
            // 
            this.lblNombreAModif.AutoSize = true;
            this.lblNombreAModif.Location = new System.Drawing.Point(592, 102);
            this.lblNombreAModif.Name = "lblNombreAModif";
            this.lblNombreAModif.Size = new System.Drawing.Size(47, 13);
            this.lblNombreAModif.TabIndex = 61;
            this.lblNombreAModif.Text = "Nombre:";
            // 
            // lblIdAModif
            // 
            this.lblIdAModif.AutoSize = true;
            this.lblIdAModif.Location = new System.Drawing.Point(563, 73);
            this.lblIdAModif.Name = "lblIdAModif";
            this.lblIdAModif.Size = new System.Drawing.Size(76, 13);
            this.lblIdAModif.TabIndex = 60;
            this.lblIdAModif.Text = "ID a Modificar:";
            // 
            // txtZIPAModif
            // 
            this.txtZIPAModif.Location = new System.Drawing.Point(645, 258);
            this.txtZIPAModif.Name = "txtZIPAModif";
            this.txtZIPAModif.Size = new System.Drawing.Size(100, 20);
            this.txtZIPAModif.TabIndex = 59;
            // 
            // txtProvAModif
            // 
            this.txtProvAModif.Location = new System.Drawing.Point(645, 232);
            this.txtProvAModif.Name = "txtProvAModif";
            this.txtProvAModif.Size = new System.Drawing.Size(100, 20);
            this.txtProvAModif.TabIndex = 58;
            // 
            // txtIdAModif
            // 
            this.txtIdAModif.Location = new System.Drawing.Point(645, 73);
            this.txtIdAModif.Name = "txtIdAModif";
            this.txtIdAModif.Size = new System.Drawing.Size(100, 20);
            this.txtIdAModif.TabIndex = 57;
            // 
            // txtNombreAModif
            // 
            this.txtNombreAModif.Location = new System.Drawing.Point(645, 99);
            this.txtNombreAModif.Name = "txtNombreAModif";
            this.txtNombreAModif.Size = new System.Drawing.Size(100, 20);
            this.txtNombreAModif.TabIndex = 56;
            // 
            // txtDirecAModif
            // 
            this.txtDirecAModif.Location = new System.Drawing.Point(645, 180);
            this.txtDirecAModif.Name = "txtDirecAModif";
            this.txtDirecAModif.Size = new System.Drawing.Size(100, 20);
            this.txtDirecAModif.TabIndex = 55;
            // 
            // txtCiudadAModif
            // 
            this.txtCiudadAModif.Location = new System.Drawing.Point(645, 206);
            this.txtCiudadAModif.Name = "txtCiudadAModif";
            this.txtCiudadAModif.Size = new System.Drawing.Size(100, 20);
            this.txtCiudadAModif.TabIndex = 54;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(670, 310);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 53;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblZIP
            // 
            this.lblZIP.AutoSize = true;
            this.lblZIP.Location = new System.Drawing.Point(422, 258);
            this.lblZIP.Name = "lblZIP";
            this.lblZIP.Size = new System.Drawing.Size(27, 13);
            this.lblZIP.TabIndex = 52;
            this.lblZIP.Text = "ZIP:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(395, 232);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 51;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(406, 206);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblCiudad.TabIndex = 50;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(394, 180);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 49;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(402, 102);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 48;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(428, 76);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 47;
            this.lblId.Text = "ID:";
            // 
            // txtZIP
            // 
            this.txtZIP.Location = new System.Drawing.Point(455, 255);
            this.txtZIP.Name = "txtZIP";
            this.txtZIP.Size = new System.Drawing.Size(100, 20);
            this.txtZIP.TabIndex = 46;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(455, 229);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(100, 20);
            this.txtProvincia.TabIndex = 45;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(455, 73);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 44;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(455, 99);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 43;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(455, 177);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 42;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(455, 203);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtCiudad.TabIndex = 41;
            // 
            // btnAgregarStore
            // 
            this.btnAgregarStore.Location = new System.Drawing.Point(480, 310);
            this.btnAgregarStore.Name = "btnAgregarStore";
            this.btnAgregarStore.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarStore.TabIndex = 40;
            this.btnAgregarStore.Text = "Agregar";
            this.btnAgregarStore.UseVisualStyleBackColor = true;
            this.btnAgregarStore.Click += new System.EventHandler(this.btnAgregarStore_Click);
            // 
            // txtIdABuscar
            // 
            this.txtIdABuscar.Location = new System.Drawing.Point(124, 351);
            this.txtIdABuscar.Name = "txtIdABuscar";
            this.txtIdABuscar.Size = new System.Drawing.Size(100, 20);
            this.txtIdABuscar.TabIndex = 39;
            // 
            // lblBuscarId
            // 
            this.lblBuscarId.AutoSize = true;
            this.lblBuscarId.Location = new System.Drawing.Point(55, 354);
            this.lblBuscarId.Name = "lblBuscarId";
            this.lblBuscarId.Size = new System.Drawing.Size(63, 13);
            this.lblBuscarId.TabIndex = 38;
            this.lblBuscarId.Text = "Id a buscar:";
            // 
            // btnTraerPorId
            // 
            this.btnTraerPorId.Location = new System.Drawing.Point(124, 377);
            this.btnTraerPorId.Name = "btnTraerPorId";
            this.btnTraerPorId.Size = new System.Drawing.Size(76, 40);
            this.btnTraerPorId.TabIndex = 37;
            this.btnTraerPorId.Text = "Traer Elemento";
            this.btnTraerPorId.UseVisualStyleBackColor = true;
            this.btnTraerPorId.Click += new System.EventHandler(this.btnTraerPorId_Click);
            // 
            // gridAuthor
            // 
            this.gridAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAuthor.Location = new System.Drawing.Point(79, 73);
            this.gridAuthor.Name = "gridAuthor";
            this.gridAuthor.Size = new System.Drawing.Size(240, 150);
            this.gridAuthor.TabIndex = 36;
            // 
            // btnTraerLista
            // 
            this.btnTraerLista.Location = new System.Drawing.Point(79, 33);
            this.btnTraerLista.Name = "btnTraerLista";
            this.btnTraerLista.Size = new System.Drawing.Size(75, 23);
            this.btnTraerLista.TabIndex = 35;
            this.btnTraerLista.Text = "Mostrar Lista";
            this.btnTraerLista.UseVisualStyleBackColor = true;
            this.btnTraerLista.Click += new System.EventHandler(this.btnTraerLista_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(402, 128);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 70;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(455, 125);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 69;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(394, 154);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 72;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(455, 151);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 71;
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Location = new System.Drawing.Point(399, 284);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(50, 13);
            this.lblContract.TabIndex = 74;
            this.lblContract.Text = "Contract:";
            // 
            // txtContract
            // 
            this.txtContract.Location = new System.Drawing.Point(455, 281);
            this.txtContract.Name = "txtContract";
            this.txtContract.Size = new System.Drawing.Size(100, 20);
            this.txtContract.TabIndex = 73;
            // 
            // lblTelefonoAModif
            // 
            this.lblTelefonoAModif.AutoSize = true;
            this.lblTelefonoAModif.Location = new System.Drawing.Point(584, 154);
            this.lblTelefonoAModif.Name = "lblTelefonoAModif";
            this.lblTelefonoAModif.Size = new System.Drawing.Size(52, 13);
            this.lblTelefonoAModif.TabIndex = 78;
            this.lblTelefonoAModif.Text = "Telefono:";
            // 
            // txtTelAModif
            // 
            this.txtTelAModif.Location = new System.Drawing.Point(645, 151);
            this.txtTelAModif.Name = "txtTelAModif";
            this.txtTelAModif.Size = new System.Drawing.Size(100, 20);
            this.txtTelAModif.TabIndex = 77;
            // 
            // lblApellidoAModif
            // 
            this.lblApellidoAModif.AutoSize = true;
            this.lblApellidoAModif.Location = new System.Drawing.Point(592, 128);
            this.lblApellidoAModif.Name = "lblApellidoAModif";
            this.lblApellidoAModif.Size = new System.Drawing.Size(47, 13);
            this.lblApellidoAModif.TabIndex = 76;
            this.lblApellidoAModif.Text = "Apellido:";
            // 
            // txtApellidoAModif
            // 
            this.txtApellidoAModif.Location = new System.Drawing.Point(645, 125);
            this.txtApellidoAModif.Name = "txtApellidoAModif";
            this.txtApellidoAModif.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoAModif.TabIndex = 75;
            // 
            // lblContractAModif
            // 
            this.lblContractAModif.AutoSize = true;
            this.lblContractAModif.Location = new System.Drawing.Point(589, 287);
            this.lblContractAModif.Name = "lblContractAModif";
            this.lblContractAModif.Size = new System.Drawing.Size(50, 13);
            this.lblContractAModif.TabIndex = 80;
            this.lblContractAModif.Text = "Contract:";
            // 
            // txtContAModif
            // 
            this.txtContAModif.Location = new System.Drawing.Point(645, 284);
            this.txtContAModif.Name = "txtContAModif";
            this.txtContAModif.Size = new System.Drawing.Size(100, 20);
            this.txtContAModif.TabIndex = 79;
            // 
            // frmAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblContractAModif);
            this.Controls.Add(this.txtContAModif);
            this.Controls.Add(this.lblTelefonoAModif);
            this.Controls.Add(this.txtTelAModif);
            this.Controls.Add(this.lblApellidoAModif);
            this.Controls.Add(this.txtApellidoAModif);
            this.Controls.Add(this.lblContract);
            this.Controls.Add(this.txtContract);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
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
            this.Controls.Add(this.gridAuthor);
            this.Controls.Add(this.btnTraerLista);
            this.Name = "frmAuthor";
            this.Text = "frmAuthor";
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdAEliminar;
        private System.Windows.Forms.Label lblIdAEliminar;
        private System.Windows.Forms.Button btnEliminarElemento;
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
        private System.Windows.Forms.Label lblZIP;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtZIP;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Button btnAgregarStore;
        private System.Windows.Forms.TextBox txtIdABuscar;
        private System.Windows.Forms.Label lblBuscarId;
        private System.Windows.Forms.Button btnTraerPorId;
        private System.Windows.Forms.DataGridView gridAuthor;
        private System.Windows.Forms.Button btnTraerLista;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.TextBox txtContract;
        private System.Windows.Forms.Label lblTelefonoAModif;
        private System.Windows.Forms.TextBox txtTelAModif;
        private System.Windows.Forms.Label lblApellidoAModif;
        private System.Windows.Forms.TextBox txtApellidoAModif;
        private System.Windows.Forms.Label lblContractAModif;
        private System.Windows.Forms.TextBox txtContAModif;
    }
}