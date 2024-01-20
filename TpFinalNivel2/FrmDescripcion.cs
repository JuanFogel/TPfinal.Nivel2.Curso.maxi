using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TpFinalNivel2
{
    public partial class FrmDescripcion : Form
    {
        public FrmDescripcion(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private Articulo articulo;

        
        private void FrmDescripcion_Load(object sender, EventArgs e)
        {
            labelNombre.Text += "  " + articulo.Nombre;
            labelPrecio.Text += "  " + articulo.Precio;
            labelDescripcion.Text += "  " + articulo.Descripcion;
            cargarImagen(articulo.ImagenUrl);

        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxImagen.Load(imagen);
            }
            catch (Exception)
            {
                pictureBoxImagen.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
