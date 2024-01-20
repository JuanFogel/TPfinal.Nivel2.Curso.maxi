namespace TpFinalNivel2
{
    partial class FrmAgregar
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
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxAgregarNombre = new System.Windows.Forms.TextBox();
            this.textBoxAgregarCodigo = new System.Windows.Forms.TextBox();
            this.textBoxAgregarDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxAgregarUrlImagen = new System.Windows.Forms.TextBox();
            this.labelAgregarDescripcion = new System.Windows.Forms.Label();
            this.labelAgregarMarca = new System.Windows.Forms.Label();
            this.labelAgregarNombre = new System.Windows.Forms.Label();
            this.labelAgregarCodigo = new System.Windows.Forms.Label();
            this.labelAgregarTecnologia = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.comboBoxTecnologia = new System.Windows.Forms.ComboBox();
            this.pictureBoxAgregarImg = new System.Windows.Forms.PictureBox();
            this.textBoxAgregarPrecio = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonImportarImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAgregarImg)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAceptar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.Location = new System.Drawing.Point(97, 350);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(105, 31);
            this.buttonAceptar.TabIndex = 7;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(267, 350);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(105, 31);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxAgregarNombre
            // 
            this.textBoxAgregarNombre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxAgregarNombre.Location = new System.Drawing.Point(95, 58);
            this.textBoxAgregarNombre.Name = "textBoxAgregarNombre";
            this.textBoxAgregarNombre.Size = new System.Drawing.Size(125, 20);
            this.textBoxAgregarNombre.TabIndex = 0;
            // 
            // textBoxAgregarCodigo
            // 
            this.textBoxAgregarCodigo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxAgregarCodigo.Location = new System.Drawing.Point(95, 95);
            this.textBoxAgregarCodigo.Name = "textBoxAgregarCodigo";
            this.textBoxAgregarCodigo.Size = new System.Drawing.Size(125, 20);
            this.textBoxAgregarCodigo.TabIndex = 1;
            // 
            // textBoxAgregarDescripcion
            // 
            this.textBoxAgregarDescripcion.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxAgregarDescripcion.Location = new System.Drawing.Point(95, 130);
            this.textBoxAgregarDescripcion.Name = "textBoxAgregarDescripcion";
            this.textBoxAgregarDescripcion.Size = new System.Drawing.Size(125, 20);
            this.textBoxAgregarDescripcion.TabIndex = 2;
            // 
            // textBoxAgregarUrlImagen
            // 
            this.textBoxAgregarUrlImagen.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxAgregarUrlImagen.Location = new System.Drawing.Point(95, 167);
            this.textBoxAgregarUrlImagen.Name = "textBoxAgregarUrlImagen";
            this.textBoxAgregarUrlImagen.Size = new System.Drawing.Size(125, 20);
            this.textBoxAgregarUrlImagen.TabIndex = 3;
            this.textBoxAgregarUrlImagen.Leave += new System.EventHandler(this.textBoxAgregarUrlImagen_Leave);
            // 
            // labelAgregarDescripcion
            // 
            this.labelAgregarDescripcion.AutoSize = true;
            this.labelAgregarDescripcion.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgregarDescripcion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelAgregarDescripcion.Location = new System.Drawing.Point(10, 128);
            this.labelAgregarDescripcion.Margin = new System.Windows.Forms.Padding(3, 6, 3, 9);
            this.labelAgregarDescripcion.Name = "labelAgregarDescripcion";
            this.labelAgregarDescripcion.Padding = new System.Windows.Forms.Padding(4, 2, 2, 4);
            this.labelAgregarDescripcion.Size = new System.Drawing.Size(78, 28);
            this.labelAgregarDescripcion.TabIndex = 2;
            this.labelAgregarDescripcion.Text = "Descripcion";
            // 
            // labelAgregarMarca
            // 
            this.labelAgregarMarca.AutoSize = true;
            this.labelAgregarMarca.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgregarMarca.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelAgregarMarca.Location = new System.Drawing.Point(36, 225);
            this.labelAgregarMarca.Margin = new System.Windows.Forms.Padding(3, 6, 3, 9);
            this.labelAgregarMarca.Name = "labelAgregarMarca";
            this.labelAgregarMarca.Padding = new System.Windows.Forms.Padding(4, 2, 2, 4);
            this.labelAgregarMarca.Size = new System.Drawing.Size(49, 28);
            this.labelAgregarMarca.TabIndex = 2;
            this.labelAgregarMarca.Text = "Marca";
            // 
            // labelAgregarNombre
            // 
            this.labelAgregarNombre.AutoSize = true;
            this.labelAgregarNombre.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgregarNombre.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelAgregarNombre.Location = new System.Drawing.Point(29, 57);
            this.labelAgregarNombre.Margin = new System.Windows.Forms.Padding(3, 6, 3, 9);
            this.labelAgregarNombre.Name = "labelAgregarNombre";
            this.labelAgregarNombre.Padding = new System.Windows.Forms.Padding(4, 2, 2, 4);
            this.labelAgregarNombre.Size = new System.Drawing.Size(60, 28);
            this.labelAgregarNombre.TabIndex = 2;
            this.labelAgregarNombre.Text = "Nombre";
            // 
            // labelAgregarCodigo
            // 
            this.labelAgregarCodigo.AutoSize = true;
            this.labelAgregarCodigo.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgregarCodigo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelAgregarCodigo.Location = new System.Drawing.Point(33, 94);
            this.labelAgregarCodigo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 9);
            this.labelAgregarCodigo.Name = "labelAgregarCodigo";
            this.labelAgregarCodigo.Padding = new System.Windows.Forms.Padding(4, 2, 2, 4);
            this.labelAgregarCodigo.Size = new System.Drawing.Size(53, 28);
            this.labelAgregarCodigo.TabIndex = 2;
            this.labelAgregarCodigo.Text = "Codigo";
            // 
            // labelAgregarTecnologia
            // 
            this.labelAgregarTecnologia.AutoSize = true;
            this.labelAgregarTecnologia.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgregarTecnologia.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelAgregarTecnologia.Location = new System.Drawing.Point(21, 260);
            this.labelAgregarTecnologia.Margin = new System.Windows.Forms.Padding(3, 6, 3, 9);
            this.labelAgregarTecnologia.Name = "labelAgregarTecnologia";
            this.labelAgregarTecnologia.Padding = new System.Windows.Forms.Padding(4, 2, 2, 4);
            this.labelAgregarTecnologia.Size = new System.Drawing.Size(67, 28);
            this.labelAgregarTecnologia.TabIndex = 2;
            this.labelAgregarTecnologia.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(15, 164);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 6, 3, 9);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(4, 2, 2, 4);
            this.label6.Size = new System.Drawing.Size(74, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Url Imagen";
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(95, 226);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(125, 21);
            this.comboBoxMarca.TabIndex = 4;
            // 
            // comboBoxTecnologia
            // 
            this.comboBoxTecnologia.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBoxTecnologia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTecnologia.FormattingEnabled = true;
            this.comboBoxTecnologia.Location = new System.Drawing.Point(95, 261);
            this.comboBoxTecnologia.Name = "comboBoxTecnologia";
            this.comboBoxTecnologia.Size = new System.Drawing.Size(125, 21);
            this.comboBoxTecnologia.TabIndex = 5;
            // 
            // pictureBoxAgregarImg
            // 
            this.pictureBoxAgregarImg.Location = new System.Drawing.Point(256, 58);
            this.pictureBoxAgregarImg.Name = "pictureBoxAgregarImg";
            this.pictureBoxAgregarImg.Size = new System.Drawing.Size(168, 261);
            this.pictureBoxAgregarImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAgregarImg.TabIndex = 5;
            this.pictureBoxAgregarImg.TabStop = false;
            // 
            // textBoxAgregarPrecio
            // 
            this.textBoxAgregarPrecio.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxAgregarPrecio.Location = new System.Drawing.Point(95, 299);
            this.textBoxAgregarPrecio.Name = "textBoxAgregarPrecio";
            this.textBoxAgregarPrecio.Size = new System.Drawing.Size(125, 20);
            this.textBoxAgregarPrecio.TabIndex = 6;
            this.textBoxAgregarPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAgregarPrecio_KeyPress);
            this.textBoxAgregarPrecio.Leave += new System.EventHandler(this.textBoxAgregarUrlImagen_Leave);
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelPrecio.Location = new System.Drawing.Point(33, 298);
            this.labelPrecio.Margin = new System.Windows.Forms.Padding(3, 6, 3, 9);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Padding = new System.Windows.Forms.Padding(4, 2, 2, 4);
            this.labelPrecio.Size = new System.Drawing.Size(49, 28);
            this.labelPrecio.TabIndex = 2;
            this.labelPrecio.Text = "Precio";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.CadetBlue;
            this.labelTitulo.Location = new System.Drawing.Point(3, 3);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Padding = new System.Windows.Forms.Padding(100, 10, 100, 10);
            this.labelTitulo.Size = new System.Drawing.Size(489, 52);
            this.labelTitulo.TabIndex = 9;
            this.labelTitulo.Text = "Agregar Nuevo Articulo";
            // 
            // buttonImportarImagen
            // 
            this.buttonImportarImagen.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonImportarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonImportarImagen.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImportarImagen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonImportarImagen.Location = new System.Drawing.Point(95, 192);
            this.buttonImportarImagen.Name = "buttonImportarImagen";
            this.buttonImportarImagen.Size = new System.Drawing.Size(125, 28);
            this.buttonImportarImagen.TabIndex = 10;
            this.buttonImportarImagen.Text = "Importar Imagen";
            this.buttonImportarImagen.UseVisualStyleBackColor = false;
            this.buttonImportarImagen.Click += new System.EventHandler(this.buttonImportarImagen_Click);
            this.buttonImportarImagen.MouseLeave += new System.EventHandler(this.buttonImportarImagen_MouseLeave);
            this.buttonImportarImagen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonImportarImagen_MouseMove);
            // 
            // FrmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(447, 402);
            this.Controls.Add(this.buttonImportarImagen);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.pictureBoxAgregarImg);
            this.Controls.Add(this.comboBoxTecnologia);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.labelAgregarCodigo);
            this.Controls.Add(this.labelAgregarNombre);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelAgregarMarca);
            this.Controls.Add(this.labelAgregarTecnologia);
            this.Controls.Add(this.labelAgregarDescripcion);
            this.Controls.Add(this.textBoxAgregarPrecio);
            this.Controls.Add(this.textBoxAgregarUrlImagen);
            this.Controls.Add(this.textBoxAgregarDescripcion);
            this.Controls.Add(this.textBoxAgregarCodigo);
            this.Controls.Add(this.textBoxAgregarNombre);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Name = "FrmAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Articulo";
            this.Load += new System.EventHandler(this.FrmAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAgregarImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxAgregarNombre;
        private System.Windows.Forms.TextBox textBoxAgregarCodigo;
        private System.Windows.Forms.TextBox textBoxAgregarDescripcion;
        private System.Windows.Forms.TextBox textBoxAgregarUrlImagen;
        private System.Windows.Forms.Label labelAgregarDescripcion;
        private System.Windows.Forms.Label labelAgregarMarca;
        private System.Windows.Forms.Label labelAgregarNombre;
        private System.Windows.Forms.Label labelAgregarCodigo;
        private System.Windows.Forms.Label labelAgregarTecnologia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.ComboBox comboBoxTecnologia;
        private System.Windows.Forms.PictureBox pictureBoxAgregarImg;
        private System.Windows.Forms.TextBox textBoxAgregarPrecio;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonImportarImagen;
    }
}