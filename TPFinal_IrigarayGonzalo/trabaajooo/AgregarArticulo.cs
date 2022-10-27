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
    public partial class AgregarArticulo : Form
    {
        private Articulos articulos = null;
        private OpenFileDialog archivo = null;

       

        public AgregarArticulo()
        {
            InitializeComponent();
        }
        public AgregarArticulo (Articulos articulo)
        {
            InitializeComponent ();
            this.articulos = articulo;
            Text = "Modificar Articulo.";
        }
        private void BtnCancelar_Click(object sender, EventArgs e){

            Close();
        }
 
        private void AgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                
                CboMarca.DataSource    = marcaNegocio.Listar();
                CboCategoria.ValueMember   = "Id";
                CboCategoria.DisplayMember = "Categoria";
                CboCategoria.DataSource    = categoriaNegocio.Listar();
                CboMarca.ValueMember   = "Id";
                CboMarca.DisplayMember = "Descripcion";
               
                if (articulos != null)
                {
                    TxtCodigo.Text  = articulos.Codigo.ToString();
                    TxtNombre.Text  = articulos.Nombre;
                    TxtDescrip.Text = articulos.Descripcion;
                    TxtImagen.Text  = articulos.ImagenUrl;
                    TxtPrecio.Text = articulos.Precio.ToString();
                    CargarImagen(articulos.ImagenUrl);
                   CboMarca.SelectedValue  = articulos.Marcas.ToString();
                    CboMarca.SelectedValue = articulos.Marcas.Id;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void GuardarImagen()
        {
            File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
        }
        private void CargarImagen(string imagen)
        {

            try
            {
                PtbUrlImagen.Load(imagen);
            }
            catch (Exception)
            {

                PtbUrlImagen.Load("https://wpdirecto.com/wp-content/uploads/2017/08/alt-de-una-imagen.png");
            }
        }

        private void BtnAgegarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "jpg| *.jpg;|png|*.png";

            if (archivo.ShowDialog() == DialogResult.OK)
            {

                TxtImagen.Text = archivo.FileName;
                CargarImagen(archivo.FileName);

                //guardar imagen
                //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"]+archivo.SafeFileName);
            }

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            ProductosNegocio Negocio = new ProductosNegocio();
            try
            {
                if (articulos == null)
                  articulos = new Articulos();
               
                
                articulos.Codigo = TxtCodigo.Text;
                articulos.Nombre = TxtNombre.Text;
                articulos.Descripcion = TxtDescrip.Text;
                articulos.ImagenUrl = TxtImagen.Text;
                articulos.Precio = Decimal.Parse(TxtPrecio.Text);
                articulos.Marcas = (Marca) CboMarca.SelectedItem;
                articulos.Categoria = (Categoria)CboCategoria.SelectedItem;

                if (articulos.Id != 0)
                {

                    Negocio.Modificar(articulos);
                    MessageBox.Show("Modificado...");

                }
                else
                {
                    Negocio.Agregar(articulos);
                    MessageBox.Show("Agregado..");
                }
                //si apreta aceptar se guarda la imagen en la carpeta
                if (archivo != null && (TxtImagen.Text.ToUpper().Contains("HTTP")))
                {
                    GuardarImagen();
                }

                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

