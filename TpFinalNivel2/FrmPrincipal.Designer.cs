namespace TpFinalNivel2
{
    partial class FrmPrincipal
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
            System.Windows.Forms.Label labelTitulo;
            this.dataGridViewCatalogo = new System.Windows.Forms.DataGridView();
            this.pictureBoxArticuloprinci = new System.Windows.Forms.PictureBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonDetalles = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.textBoxBuscarNorm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscarAvanzada = new System.Windows.Forms.Button();
            this.Campo = new System.Windows.Forms.Label();
            this.comboBoxCampo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCriterio = new System.Windows.Forms.ComboBox();
            this.textBoxBusquedaAvanzada = new System.Windows.Forms.TextBox();
            this.Busqueda = new System.Windows.Forms.Label();
            labelTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticuloprinci)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelTitulo.ForeColor = System.Drawing.Color.CadetBlue;
            labelTitulo.Location = new System.Drawing.Point(341, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new System.Drawing.Size(206, 47);
            labelTitulo.TabIndex = 3;
            labelTitulo.Text = "CATÁLOGO";
            // 
            // dataGridViewCatalogo
            // 
            this.dataGridViewCatalogo.AllowUserToResizeColumns = false;
            this.dataGridViewCatalogo.AllowUserToResizeRows = false;
            this.dataGridViewCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCatalogo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewCatalogo.Location = new System.Drawing.Point(37, 102);
            this.dataGridViewCatalogo.MultiSelect = false;
            this.dataGridViewCatalogo.Name = "dataGridViewCatalogo";
            this.dataGridViewCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCatalogo.Size = new System.Drawing.Size(545, 166);
            this.dataGridViewCatalogo.TabIndex = 0;
            this.dataGridViewCatalogo.SelectionChanged += new System.EventHandler(this.dataGridViewCatalogo_SelectionChanged);
            // 
            // pictureBoxArticuloprinci
            // 
            this.pictureBoxArticuloprinci.Location = new System.Drawing.Point(622, 102);
            this.pictureBoxArticuloprinci.Name = "pictureBoxArticuloprinci";
            this.pictureBoxArticuloprinci.Size = new System.Drawing.Size(215, 293);
            this.pictureBoxArticuloprinci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArticuloprinci.TabIndex = 1;
            this.pictureBoxArticuloprinci.TabStop = false;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAgregar.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAgregar.Location = new System.Drawing.Point(89, 282);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(93, 29);
            this.buttonAgregar.TabIndex = 2;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            this.buttonAgregar.MouseLeave += new System.EventHandler(this.buttonAgregar_MouseLeave);
            this.buttonAgregar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonAgregar_MouseMove);
            // 
            // buttonDetalles
            // 
            this.buttonDetalles.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDetalles.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetalles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDetalles.Location = new System.Drawing.Point(208, 282);
            this.buttonDetalles.Name = "buttonDetalles";
            this.buttonDetalles.Size = new System.Drawing.Size(93, 29);
            this.buttonDetalles.TabIndex = 2;
            this.buttonDetalles.Text = "Detalles";
            this.buttonDetalles.UseVisualStyleBackColor = false;
            this.buttonDetalles.Click += new System.EventHandler(this.buttonDetalles_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonModificar.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonModificar.Location = new System.Drawing.Point(327, 282);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(93, 29);
            this.buttonModificar.TabIndex = 2;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEliminar.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEliminar.Location = new System.Drawing.Point(440, 282);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(93, 29);
            this.buttonEliminar.TabIndex = 2;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // textBoxBuscarNorm
            // 
            this.textBoxBuscarNorm.BackColor = System.Drawing.Color.GhostWhite;
            this.textBoxBuscarNorm.Location = new System.Drawing.Point(89, 71);
            this.textBoxBuscarNorm.Name = "textBoxBuscarNorm";
            this.textBoxBuscarNorm.Size = new System.Drawing.Size(226, 20);
            this.textBoxBuscarNorm.TabIndex = 5;
            this.textBoxBuscarNorm.TextChanged += new System.EventHandler(this.textBoxBuscarNorm_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(40, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar :";
            // 
            // buttonBuscarAvanzada
            // 
            this.buttonBuscarAvanzada.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarAvanzada.Location = new System.Drawing.Point(398, 370);
            this.buttonBuscarAvanzada.Name = "buttonBuscarAvanzada";
            this.buttonBuscarAvanzada.Size = new System.Drawing.Size(135, 30);
            this.buttonBuscarAvanzada.TabIndex = 4;
            this.buttonBuscarAvanzada.Text = "Ejecutar Busqueda";
            this.buttonBuscarAvanzada.UseVisualStyleBackColor = true;
            this.buttonBuscarAvanzada.Click += new System.EventHandler(this.buttonBuscarAvanzada_Click);
            // 
            // Campo
            // 
            this.Campo.AutoSize = true;
            this.Campo.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Campo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Campo.Location = new System.Drawing.Point(71, 333);
            this.Campo.Name = "Campo";
            this.Campo.Size = new System.Drawing.Size(49, 21);
            this.Campo.TabIndex = 7;
            this.Campo.Text = "Campo :";
            // 
            // comboBoxCampo
            // 
            this.comboBoxCampo.BackColor = System.Drawing.Color.GhostWhite;
            this.comboBoxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCampo.FormattingEnabled = true;
            this.comboBoxCampo.Location = new System.Drawing.Point(127, 333);
            this.comboBoxCampo.Name = "comboBoxCampo";
            this.comboBoxCampo.Size = new System.Drawing.Size(163, 21);
            this.comboBoxCampo.TabIndex = 8;
            this.comboBoxCampo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCampo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(330, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Criterio :";
            // 
            // comboBoxCriterio
            // 
            this.comboBoxCriterio.BackColor = System.Drawing.Color.GhostWhite;
            this.comboBoxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCriterio.FormattingEnabled = true;
            this.comboBoxCriterio.Location = new System.Drawing.Point(383, 333);
            this.comboBoxCriterio.Name = "comboBoxCriterio";
            this.comboBoxCriterio.Size = new System.Drawing.Size(163, 21);
            this.comboBoxCriterio.TabIndex = 10;
            // 
            // textBoxBusquedaAvanzada
            // 
            this.textBoxBusquedaAvanzada.BackColor = System.Drawing.Color.GhostWhite;
            this.textBoxBusquedaAvanzada.Location = new System.Drawing.Point(127, 375);
            this.textBoxBusquedaAvanzada.Name = "textBoxBusquedaAvanzada";
            this.textBoxBusquedaAvanzada.Size = new System.Drawing.Size(163, 20);
            this.textBoxBusquedaAvanzada.TabIndex = 11;
            // 
            // Busqueda
            // 
            this.Busqueda.AutoSize = true;
            this.Busqueda.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Busqueda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Busqueda.Location = new System.Drawing.Point(58, 374);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(63, 21);
            this.Busqueda.TabIndex = 12;
            this.Busqueda.Text = "Busqueda :";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(877, 416);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.textBoxBusquedaAvanzada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCriterio);
            this.Controls.Add(this.textBoxBuscarNorm);
            this.Controls.Add(this.label3);
            this.Controls.Add(labelTitulo);
            this.Controls.Add(this.comboBoxCampo);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.Campo);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonBuscarAvanzada);
            this.Controls.Add(this.buttonDetalles);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.pictureBoxArticuloprinci);
            this.Controls.Add(this.dataGridViewCatalogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo de Articulos";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticuloprinci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCatalogo;
        private System.Windows.Forms.PictureBox pictureBoxArticuloprinci;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonDetalles;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.TextBox textBoxBuscarNorm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscarAvanzada;
        private System.Windows.Forms.Label Campo;
        private System.Windows.Forms.ComboBox comboBoxCampo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCriterio;
        private System.Windows.Forms.TextBox textBoxBusquedaAvanzada;
        private System.Windows.Forms.Label Busqueda;
    }
}

