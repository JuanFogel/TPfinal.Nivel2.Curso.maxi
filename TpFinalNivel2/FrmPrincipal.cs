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
using negocio;


namespace TpFinalNivel2
{
    public partial class FrmPrincipal : Form
    {

        private List<Articulo> listaArticulos;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ButtonDetalles_MouseLeave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregar ventanaAgregar = new FrmAgregar();
            ventanaAgregar.ShowDialog();
            cargar();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dataGridViewCatalogo.CurrentRow.DataBoundItem;
            FrmAgregar ventanaModificar = new FrmAgregar(seleccionado);
            ventanaModificar.ShowDialog();
            cargar();
        }

        private void buttonDetalles_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            if (dataGridViewCatalogo.CurrentRow != null && dataGridViewCatalogo.CurrentRow.DataBoundItem != null)
            {
                seleccionado = (Articulo)dataGridViewCatalogo.CurrentRow.DataBoundItem;
                FrmDescripcion descripcion = new FrmDescripcion(seleccionado);
                descripcion.ShowDialog();
                cargar();
            }
            else
            {
                cargar();
                dataGridViewCatalogo.Columns[0].Selected = true;

            }

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            cargar();
            comboBoxCampo.Items.Add("Nombre");
            comboBoxCampo.Items.Add("Marca");
            comboBoxCampo.Items.Add("Precio");
            comboBoxCampo.Items.Add("Categoria");
            bienvenida();

            ConfigurarBoton(buttonAgregar);
            ConfigurarBoton(buttonDetalles);
            ConfigurarBoton(buttonEliminar);
            ConfigurarBoton(buttonModificar);


        }

        private void dataGridViewCatalogo_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCatalogo.CurrentRow != null)
            {
                Articulo articuloselected = (Articulo)dataGridViewCatalogo.CurrentRow.DataBoundItem;
                cargarImagen(articuloselected.ImagenUrl);
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxArticuloprinci.Load(imagen);
            }
            catch (Exception)
            {
                pictureBoxArticuloprinci.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");
            }
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listArticulos();
                dataGridViewCatalogo.DataSource = listaArticulos;
                ocultarColumnas();
                cargarImagen(listaArticulos[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dataGridViewCatalogo.Columns["ImagenUrl"].Visible = false;
            dataGridViewCatalogo.Columns["IdArticulo"].Visible = false;
            dataGridViewCatalogo.Columns["Descripcion"].Visible = false;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Esta seguro que quiere eliminar este articulo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dataGridViewCatalogo.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.IdArticulo);
                    cargar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonBuscarNorm_Click(object sender, EventArgs e)
        {

        }

        private void textBoxBuscarNorm_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = textBoxBuscarNorm.Text;

            if (filtro.Length >= 2)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()) || x.Marca.DescripcionMarca.ToLower().Contains(filtro.ToLower()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            dataGridViewCatalogo.DataSource = null;
            dataGridViewCatalogo.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void comboBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = comboBoxCampo.SelectedItem.ToString();

            if (opcion == "Precio")
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Mayor a");
                comboBoxCriterio.Items.Add("Menor a");
                comboBoxCriterio.Items.Add("Igual a");
            }
            else
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Empieza con");
                comboBoxCriterio.Items.Add("Termina con");
                comboBoxCriterio.Items.Add("Contiene");
            }
        }

        private bool validarFiltro()
        {
            if (comboBoxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione el campo para filtrar");
                return true;
            }
            if (comboBoxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione el criterio para filtrar");
                return true;
            }
            if (comboBoxCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(textBoxBusquedaAvanzada.Text))
                {
                    MessageBox.Show("Ingrese un precio para continuar");
                    return true;

                }
                if (!(soloNumeros(textBoxBusquedaAvanzada.Text)))
                {
                    MessageBox.Show("Ingrese solo numeros");
                    return true;
                }

            }
            return false;
        }


        private bool soloNumeros(string cadena)
        {

            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }
            }
            return true;
        }

        private void buttonBuscarAvanzada_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (validarFiltro())
                    return;

                string campo = comboBoxCampo.SelectedItem.ToString();
                string criterio = comboBoxCriterio.SelectedItem.ToString();
                string filtro = textBoxBusquedaAvanzada.Text;
                dataGridViewCatalogo.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void bienvenida()
        {

            string arbolito =
            "         ʌ\n" +
            "        ʌʌ\n" +
            "       ʌʌʌ\n" +
            "      ʌʌʌʌ\n" +
            "     ʌʌʌʌʌ\n" +
            "    ʌʌʌʌʌʌ\n" +
            "  ʌʌʌʌʌʌʌʌ\n" +
            "       |||\n" +
            " ----------------------\n" +
            "   FELIZ NAVIDAD\n" +
            " -----------------------\n";

            string mensajeBienvenida = "Feliz Navidad & Próspero Año Nuevo!\n\n" + arbolito;
            MessageBox.Show(mensajeBienvenida);
        }

        private void buttonAgregar_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackColor = Color.MidnightBlue;
        }

        private void buttonAgregar_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.SlateBlue;
        }

        private void ConfigurarBoton(Button boton)
        {
            boton.MouseMove += buttonAgregar_MouseMove;
            boton.MouseLeave += buttonAgregar_MouseLeave;
        }

        
    }
}




