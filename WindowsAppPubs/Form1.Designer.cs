namespace WindowsAppPubs
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
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarPublisher = new System.Windows.Forms.Button();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblModificarPais = new System.Windows.Forms.Label();
            this.txtModifPais = new System.Windows.Forms.TextBox();
            this.txtModifCiudad = new System.Windows.Forms.TextBox();
            this.txtModifProv = new System.Windows.Forms.TextBox();
            this.txtModifNombre = new System.Windows.Forms.TextBox();
            this.lblModificarProvincia = new System.Windows.Forms.Label();
            this.lblModificarNombre = new System.Windows.Forms.Label();
            this.lblModificarCiudad = new System.Windows.Forms.Label();
            this.txtIdAEliminar = new System.Windows.Forms.TextBox();
            this.lblIdAEliminar = new System.Windows.Forms.Label();
            this.txtIdAModif = new System.Windows.Forms.TextBox();
            this.lblIdAModif = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(107, 150);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(338, 190);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarPublisher
            // 
            this.btnEliminarPublisher.Location = new System.Drawing.Point(561, 150);
            this.btnEliminarPublisher.Name = "btnEliminarPublisher";
            this.btnEliminarPublisher.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPublisher.TabIndex = 2;
            this.btnEliminarPublisher.Text = "Eliminar";
            this.btnEliminarPublisher.UseVisualStyleBackColor = true;
            this.btnEliminarPublisher.Click += new System.EventHandler(this.btnEliminarPublisher_Click);
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(20, 58);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblCiudad.TabIndex = 3;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(20, 87);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 5;
            this.lblProvincia.Text = "Provincia:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(82, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(82, 84);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(100, 20);
            this.txtProvincia.TabIndex = 7;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(82, 55);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtCiudad.TabIndex = 8;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(82, 110);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 20);
            this.txtPais.TabIndex = 9;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(20, 113);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(30, 13);
            this.lblPais.TabIndex = 10;
            this.lblPais.Text = "Pais:";
            // 
            // lblModificarPais
            // 
            this.lblModificarPais.AutoSize = true;
            this.lblModificarPais.Location = new System.Drawing.Point(251, 153);
            this.lblModificarPais.Name = "lblModificarPais";
            this.lblModificarPais.Size = new System.Drawing.Size(30, 13);
            this.lblModificarPais.TabIndex = 18;
            this.lblModificarPais.Text = "Pais:";
            // 
            // txtModifPais
            // 
            this.txtModifPais.Location = new System.Drawing.Point(313, 150);
            this.txtModifPais.Name = "txtModifPais";
            this.txtModifPais.Size = new System.Drawing.Size(100, 20);
            this.txtModifPais.TabIndex = 17;
            // 
            // txtModifCiudad
            // 
            this.txtModifCiudad.Location = new System.Drawing.Point(313, 95);
            this.txtModifCiudad.Name = "txtModifCiudad";
            this.txtModifCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtModifCiudad.TabIndex = 16;
            // 
            // txtModifProv
            // 
            this.txtModifProv.Location = new System.Drawing.Point(313, 124);
            this.txtModifProv.Name = "txtModifProv";
            this.txtModifProv.Size = new System.Drawing.Size(100, 20);
            this.txtModifProv.TabIndex = 15;
            // 
            // txtModifNombre
            // 
            this.txtModifNombre.Location = new System.Drawing.Point(313, 69);
            this.txtModifNombre.Name = "txtModifNombre";
            this.txtModifNombre.Size = new System.Drawing.Size(100, 20);
            this.txtModifNombre.TabIndex = 14;
            // 
            // lblModificarProvincia
            // 
            this.lblModificarProvincia.AutoSize = true;
            this.lblModificarProvincia.Location = new System.Drawing.Point(251, 127);
            this.lblModificarProvincia.Name = "lblModificarProvincia";
            this.lblModificarProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblModificarProvincia.TabIndex = 13;
            this.lblModificarProvincia.Text = "Provincia:";
            // 
            // lblModificarNombre
            // 
            this.lblModificarNombre.AutoSize = true;
            this.lblModificarNombre.Location = new System.Drawing.Point(250, 69);
            this.lblModificarNombre.Name = "lblModificarNombre";
            this.lblModificarNombre.Size = new System.Drawing.Size(47, 13);
            this.lblModificarNombre.TabIndex = 12;
            this.lblModificarNombre.Text = "Nombre:";
            // 
            // lblModificarCiudad
            // 
            this.lblModificarCiudad.AutoSize = true;
            this.lblModificarCiudad.Location = new System.Drawing.Point(251, 98);
            this.lblModificarCiudad.Name = "lblModificarCiudad";
            this.lblModificarCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblModificarCiudad.TabIndex = 11;
            this.lblModificarCiudad.Text = "Ciudad:";
            // 
            // txtIdAEliminar
            // 
            this.txtIdAEliminar.Location = new System.Drawing.Point(536, 106);
            this.txtIdAEliminar.Name = "txtIdAEliminar";
            this.txtIdAEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtIdAEliminar.TabIndex = 20;
            // 
            // lblIdAEliminar
            // 
            this.lblIdAEliminar.AutoSize = true;
            this.lblIdAEliminar.Location = new System.Drawing.Point(466, 109);
            this.lblIdAEliminar.Name = "lblIdAEliminar";
            this.lblIdAEliminar.Size = new System.Drawing.Size(67, 13);
            this.lblIdAEliminar.TabIndex = 19;
            this.lblIdAEliminar.Text = "Id a Eliminar:";
            // 
            // txtIdAModif
            // 
            this.txtIdAModif.Location = new System.Drawing.Point(313, 26);
            this.txtIdAModif.Name = "txtIdAModif";
            this.txtIdAModif.Size = new System.Drawing.Size(100, 20);
            this.txtIdAModif.TabIndex = 22;
            // 
            // lblIdAModif
            // 
            this.lblIdAModif.AutoSize = true;
            this.lblIdAModif.Location = new System.Drawing.Point(231, 29);
            this.lblIdAModif.Name = "lblIdAModif";
            this.lblIdAModif.Size = new System.Drawing.Size(74, 13);
            this.lblIdAModif.TabIndex = 21;
            this.lblIdAModif.Text = "Id a Modificar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIdAModif);
            this.Controls.Add(this.lblIdAModif);
            this.Controls.Add(this.txtIdAEliminar);
            this.Controls.Add(this.lblIdAEliminar);
            this.Controls.Add(this.lblModificarPais);
            this.Controls.Add(this.txtModifPais);
            this.Controls.Add(this.txtModifCiudad);
            this.Controls.Add(this.txtModifProv);
            this.Controls.Add(this.txtModifNombre);
            this.Controls.Add(this.lblModificarProvincia);
            this.Controls.Add(this.lblModificarNombre);
            this.Controls.Add(this.lblModificarCiudad);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.btnEliminarPublisher);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarPublisher;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblModificarPais;
        private System.Windows.Forms.TextBox txtModifPais;
        private System.Windows.Forms.TextBox txtModifCiudad;
        private System.Windows.Forms.TextBox txtModifProv;
        private System.Windows.Forms.TextBox txtModifNombre;
        private System.Windows.Forms.Label lblModificarProvincia;
        private System.Windows.Forms.Label lblModificarNombre;
        private System.Windows.Forms.Label lblModificarCiudad;
        private System.Windows.Forms.TextBox txtIdAEliminar;
        private System.Windows.Forms.Label lblIdAEliminar;
        private System.Windows.Forms.TextBox txtIdAModif;
        private System.Windows.Forms.Label lblIdAModif;
    }
}

