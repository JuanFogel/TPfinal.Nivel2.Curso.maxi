namespace TpFinalNivel2
{
    partial class FrmDescripcion
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Dubai Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNombre.Location = new System.Drawing.Point(202, 37);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(62, 21);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre: ";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Dubai Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPrecio.Location = new System.Drawing.Point(202, 64);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(54, 21);
            this.labelPrecio.TabIndex = 0;
            this.labelPrecio.Text = "Precio: ";
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.Location = new System.Drawing.Point(12, 25);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(154, 252);
            this.pictureBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagen.TabIndex = 1;
            this.pictureBoxImagen.TabStop = false;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Dubai Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDescripcion.Location = new System.Drawing.Point(202, 96);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(81, 21);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "Descripcion:";
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSalir.Location = new System.Drawing.Point(261, 160);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(87, 24);
            this.buttonSalir.TabIndex = 4;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // FrmDescripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(449, 298);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.pictureBoxImagen);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelNombre);
            this.Name = "FrmDescripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles";
            this.Load += new System.EventHandler(this.FrmDescripcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Button buttonSalir;
    }
}