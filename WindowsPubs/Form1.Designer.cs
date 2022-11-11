namespace WindowsPubs
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.gridPublisher = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblPaisAModif = new System.Windows.Forms.Label();
            this.txtPaisAModif = new System.Windows.Forms.TextBox();
            this.txtCiudAModif = new System.Windows.Forms.TextBox();
            this.txtProvAModif = new System.Windows.Forms.TextBox();
            this.txtIdAModif = new System.Windows.Forms.TextBox();
            this.txtNombreAModif = new System.Windows.Forms.TextBox();
            this.lblProvinciaAModif = new System.Windows.Forms.Label();
            this.lblCiudadAModif = new System.Windows.Forms.Label();
            this.lblNombreAModif = new System.Windows.Forms.Label();
            this.lblIdModif = new System.Windows.Forms.Label();
            this.txtIdAEliminar = new System.Windows.Forms.TextBox();
            this.lblIdAEliminar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridPublisher)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(532, 73);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(309, 192);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(111, 193);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(532, 381);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(119, 25);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar Todos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // gridPublisher
            // 
            this.gridPublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPublisher.Location = new System.Drawing.Point(532, 215);
            this.gridPublisher.Name = "gridPublisher";
            this.gridPublisher.Size = new System.Drawing.Size(240, 150);
            this.gridPublisher.TabIndex = 4;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(61, 54);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Id:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(33, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(37, 106);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblCiudad.TabIndex = 7;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(32, 132);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 8;
            this.lblProvincia.Text = "Provincia:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(86, 51);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 10;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(86, 129);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(100, 20);
            this.txtProvincia.TabIndex = 11;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(86, 103);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtCiudad.TabIndex = 12;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(86, 155);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 20);
            this.txtPais.TabIndex = 13;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(50, 158);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(30, 13);
            this.lblPais.TabIndex = 14;
            this.lblPais.Text = "Pais:";
            // 
            // lblPaisAModif
            // 
            this.lblPaisAModif.AutoSize = true;
            this.lblPaisAModif.Location = new System.Drawing.Point(248, 161);
            this.lblPaisAModif.Name = "lblPaisAModif";
            this.lblPaisAModif.Size = new System.Drawing.Size(30, 13);
            this.lblPaisAModif.TabIndex = 24;
            this.lblPaisAModif.Text = "Pais:";
            // 
            // txtPaisAModif
            // 
            this.txtPaisAModif.Location = new System.Drawing.Point(284, 158);
            this.txtPaisAModif.Name = "txtPaisAModif";
            this.txtPaisAModif.Size = new System.Drawing.Size(100, 20);
            this.txtPaisAModif.TabIndex = 23;
            // 
            // txtCiudAModif
            // 
            this.txtCiudAModif.Location = new System.Drawing.Point(284, 106);
            this.txtCiudAModif.Name = "txtCiudAModif";
            this.txtCiudAModif.Size = new System.Drawing.Size(100, 20);
            this.txtCiudAModif.TabIndex = 22;
            // 
            // txtProvAModif
            // 
            this.txtProvAModif.Location = new System.Drawing.Point(284, 132);
            this.txtProvAModif.Name = "txtProvAModif";
            this.txtProvAModif.Size = new System.Drawing.Size(100, 20);
            this.txtProvAModif.TabIndex = 21;
            // 
            // txtIdAModif
            // 
            this.txtIdAModif.Location = new System.Drawing.Point(284, 54);
            this.txtIdAModif.Name = "txtIdAModif";
            this.txtIdAModif.Size = new System.Drawing.Size(100, 20);
            this.txtIdAModif.TabIndex = 20;
            // 
            // txtNombreAModif
            // 
            this.txtNombreAModif.Location = new System.Drawing.Point(284, 80);
            this.txtNombreAModif.Name = "txtNombreAModif";
            this.txtNombreAModif.Size = new System.Drawing.Size(100, 20);
            this.txtNombreAModif.TabIndex = 19;
            // 
            // lblProvinciaAModif
            // 
            this.lblProvinciaAModif.AutoSize = true;
            this.lblProvinciaAModif.Location = new System.Drawing.Point(230, 135);
            this.lblProvinciaAModif.Name = "lblProvinciaAModif";
            this.lblProvinciaAModif.Size = new System.Drawing.Size(54, 13);
            this.lblProvinciaAModif.TabIndex = 18;
            this.lblProvinciaAModif.Text = "Provincia:";
            // 
            // lblCiudadAModif
            // 
            this.lblCiudadAModif.AutoSize = true;
            this.lblCiudadAModif.Location = new System.Drawing.Point(235, 109);
            this.lblCiudadAModif.Name = "lblCiudadAModif";
            this.lblCiudadAModif.Size = new System.Drawing.Size(43, 13);
            this.lblCiudadAModif.TabIndex = 17;
            this.lblCiudadAModif.Text = "Ciudad:";
            // 
            // lblNombreAModif
            // 
            this.lblNombreAModif.AutoSize = true;
            this.lblNombreAModif.Location = new System.Drawing.Point(231, 83);
            this.lblNombreAModif.Name = "lblNombreAModif";
            this.lblNombreAModif.Size = new System.Drawing.Size(47, 13);
            this.lblNombreAModif.TabIndex = 16;
            this.lblNombreAModif.Text = "Nombre:";
            // 
            // lblIdModif
            // 
            this.lblIdModif.AutoSize = true;
            this.lblIdModif.Location = new System.Drawing.Point(210, 57);
            this.lblIdModif.Name = "lblIdModif";
            this.lblIdModif.Size = new System.Drawing.Size(74, 13);
            this.lblIdModif.TabIndex = 15;
            this.lblIdModif.Text = "Id a Modificar:";
            // 
            // txtIdAEliminar
            // 
            this.txtIdAEliminar.Location = new System.Drawing.Point(507, 47);
            this.txtIdAEliminar.Name = "txtIdAEliminar";
            this.txtIdAEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtIdAEliminar.TabIndex = 26;
            // 
            // lblIdAEliminar
            // 
            this.lblIdAEliminar.AutoSize = true;
            this.lblIdAEliminar.Location = new System.Drawing.Point(433, 50);
            this.lblIdAEliminar.Name = "lblIdAEliminar";
            this.lblIdAEliminar.Size = new System.Drawing.Size(67, 13);
            this.lblIdAEliminar.TabIndex = 25;
            this.lblIdAEliminar.Text = "Id a Eliminar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIdAEliminar);
            this.Controls.Add(this.lblIdAEliminar);
            this.Controls.Add(this.lblPaisAModif);
            this.Controls.Add(this.txtPaisAModif);
            this.Controls.Add(this.txtCiudAModif);
            this.Controls.Add(this.txtProvAModif);
            this.Controls.Add(this.txtIdAModif);
            this.Controls.Add(this.txtNombreAModif);
            this.Controls.Add(this.lblProvinciaAModif);
            this.Controls.Add(this.lblCiudadAModif);
            this.Controls.Add(this.lblNombreAModif);
            this.Controls.Add(this.lblIdModif);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.gridPublisher);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridPublisher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView gridPublisher;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblPaisAModif;
        private System.Windows.Forms.TextBox txtPaisAModif;
        private System.Windows.Forms.TextBox txtCiudAModif;
        private System.Windows.Forms.TextBox txtProvAModif;
        private System.Windows.Forms.TextBox txtIdAModif;
        private System.Windows.Forms.TextBox txtNombreAModif;
        private System.Windows.Forms.Label lblProvinciaAModif;
        private System.Windows.Forms.Label lblCiudadAModif;
        private System.Windows.Forms.Label lblNombreAModif;
        private System.Windows.Forms.Label lblIdModif;
        private System.Windows.Forms.TextBox txtIdAEliminar;
        private System.Windows.Forms.Label lblIdAEliminar;
    }
}

