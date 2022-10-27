using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominioo;
using System.Data.SqlClient;
using Negocio;
using System.Configuration;
using System.IO;


namespace trabaajooo
{
    public partial class FrmDetalle : Form
    {
        private Articulos seleccionado;
        public FrmDetalle()
        {
            InitializeComponent();
        }
        public FrmDetalle(Articulos seleccionado)
        {
            InitializeComponent();
            this.seleccionado = seleccionado;
            Text = "Detalle del Articulo";

        }
        private void CargarImagen(string imagen)
        {

            try
            {
                PtbImagen.Load(imagen);
            }
            catch (Exception)
            {
                PtbImagen.Load("https://wpdirecto.com/wp-content/uploads/2017/08/alt-de-una-imagen.png");

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                CargarImagen(seleccionado.ImagenUrl);
                TxtCodigo.Text = seleccionado.Codigo;
                TxtNombre.Text = seleccionado.Nombre;
                TxtDescripcion.Text = seleccionado.Descripcion;
                TxtMarca.Text = seleccionado.Marcas.ToString();
                TxtCategoria.Text = seleccionado.Categoria.ToString();
                TxtPrecio.Text = seleccionado.Precio.ToString();

              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
   
}
