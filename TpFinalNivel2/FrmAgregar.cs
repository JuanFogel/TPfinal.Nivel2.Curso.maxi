using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using accesodatos;
using negocio;
using System.IO;
using System.Configuration;

namespace TpFinalNivel2
{
    public partial class FrmAgregar : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
            

        public FrmAgregar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            labelTitulo.Text = "Modificar Articulo";
        }
        public FrmAgregar()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
           
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();
                
                articulo.Descripcion = textBoxAgregarDescripcion.Text;
                articulo.Nombre = textBoxAgregarNombre.Text;
                articulo.Codigo = textBoxAgregarCodigo.Text;
                articulo.ImagenUrl = textBoxAgregarUrlImagen.Text;
                
                articulo.Marca = (Marca)comboBoxMarca.SelectedItem;
                articulo.Categoria = (Categoria)comboBoxTecnologia.SelectedItem;

                seleccionarCbo();
                completarCampos();
                if (textBoxAgregarCodigo.Text != "" && textBoxAgregarNombre.Text != "" && textBoxAgregarPrecio.Text != "")
                {                   
                    
                    if (articulo.IdArticulo != 0)
                    {
                        DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea modificar este Articulo?", "Modificando", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (respuesta == DialogResult.OK)
                        {
                            negocio.modificarArticulo(articulo);
                            MessageBox.Show("El Articulo se modifico correctamente");
                        }
                    }
                    else
                    {
                        negocio.agregarArticulo(articulo);
                        MessageBox.Show("El Articulo se agrego correctamente");
                    }

                    if (archivo != null && (textBoxAgregarUrlImagen.Text.ToLower().Contains("http")))
                    {
                        File.Copy(archivo.FileName, ConfigurationManager.AppSettings["imagenes-catalogo"] + archivo.SafeFileName);
                    }     

                    Close();
                }              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmAgregar_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            
            try
            {
                
                comboBoxMarca.DataSource = marcaNegocio.listar();
                comboBoxMarca.ValueMember = "IdMarca";
                comboBoxMarca.DisplayMember = "DescripcionMarca";
                comboBoxMarca.SelectedIndex = -1;

                comboBoxTecnologia.DataSource = categoriaNegocio.listar();
                comboBoxTecnologia.ValueMember = "IdCategoria";
                comboBoxTecnologia.DisplayMember = "DescripcionCategoria";
                comboBoxTecnologia.SelectedIndex = -1;


                if (articulo != null)
                {
                    textBoxAgregarCodigo.Text = articulo.Codigo;
                    textBoxAgregarDescripcion.Text = articulo.Descripcion;
                    textBoxAgregarNombre.Text = articulo.Nombre;
                    textBoxAgregarPrecio.Text = articulo.Precio.ToString();
                    cargarImagen(articulo.ImagenUrl);
                    comboBoxMarca.SelectedValue = articulo.Marca.IdMarca;
                    comboBoxTecnologia.SelectedValue = articulo.Categoria.IdCategoria;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBoxAgregarUrlImagen_Leave(object sender, EventArgs e)
        {
           cargarImagen(textBoxAgregarUrlImagen.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxAgregarImg.Load(imagen);
            }
            catch (Exception)
            {

                pictureBoxAgregarImg.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonImportarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();

            archivo.Filter = "JPG|*.jpg| PNG|*.png| JPEG|*.jpeg";

            if (archivo.ShowDialog() == DialogResult.OK)
            {
                textBoxAgregarUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);


                //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["imagenes-catalogo"] + archivo.SafeFileName);

            }



        }

        private void completarCampos()
        {
            if (textBoxAgregarCodigo.Text == "")
            { textBoxAgregarCodigo.BackColor = Color.Red; }
            else
            { textBoxAgregarCodigo.BackColor = System.Drawing.SystemColors.Control; }

            if (textBoxAgregarNombre.Text == "")
            { textBoxAgregarNombre.BackColor = Color.Red; }
            else
            { textBoxAgregarNombre.BackColor = System.Drawing.SystemColors.Control; }

            if (textBoxAgregarPrecio.Text == "")
            { textBoxAgregarPrecio.BackColor = Color.Red;}
            else {textBoxAgregarPrecio.BackColor = System.Drawing.SystemColors.Control; }

        }

        private void textBoxAgregarPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                e.Handled = true;
                return;
            }
        }

        private bool seleccionarCbo()
        {
            if (comboBoxMarca.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una Marca", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxTecnologia.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una Categoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void buttonImportarImagen_MouseMove(object sender, MouseEventArgs e)
        {
            buttonImportarImagen.BackColor = Color.MidnightBlue;
        }

        private void buttonImportarImagen_MouseLeave(object sender, EventArgs e)
        {
            buttonImportarImagen.BackColor = Color.SlateBlue;
        }
    }
}
