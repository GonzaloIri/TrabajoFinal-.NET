using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dominioo;
using Negocio;

namespace trabaajooo

{
    public partial class Lista : Form
    {
        private List<Articulos> ListaArticulos;

        public Lista()
        {
            InitializeComponent();
        }



        private void Lista_Load(object sender, EventArgs e)
        {
            Cargar();
        }



        private void Cargar()
        {
            ProductosNegocio negocio = new ProductosNegocio();
            try
            {

                ListaArticulos = negocio.Listar();
                DGVArticulos.DataSource = ListaArticulos;
                OcultarColumnas();
                CargarImagen(ListaArticulos[0].ImagenUrl);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void OcultarColumnas()
        {
            DGVArticulos.Columns["ImagenUrl"].Visible = false;
            DGVArticulos.Columns["Id"].Visible = false;
        }

        private void CargarImagen(string imagen)
        {

            try
            {
                PBPArticulos.Load(imagen);
            }
            catch (Exception)
            {
                PBPArticulos.Load("https://wpdirecto.com/wp-content/uploads/2017/08/alt-de-una-imagen.png");

            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarArticulo alta = new AgregarArticulo();
            alta.ShowDialog();
            Cargar();
        }

        private void BtnModificar_Click_1(object sender, EventArgs e)
        {
            Articulos seleccionado;
            seleccionado = (Articulos)DGVArticulos.CurrentRow.DataBoundItem;
            AgregarArticulo modificar = new AgregarArticulo(seleccionado);
            modificar.ShowDialog();
            Cargar();
        }


        private void DGVArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVArticulos.CurrentRow != null)
            {
                Articulos seleccionado = (Articulos)DGVArticulos.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.ImagenUrl);
                Marca Elem = new Marca();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ProductosNegocio negocio = new ProductosNegocio();
            Articulos seleccionado;
            try
            {
                DialogResult repuesta = MessageBox.Show("¿Seguro queres eliminar?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (repuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulos)DGVArticulos.CurrentRow.DataBoundItem;
                    negocio.Eliminar(seleccionado.Id);
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void Detalle_Click(object sender, EventArgs e)
        {
            if (DGVArticulos.CurrentRow != null)

            {
                Articulos seleccionado = (Articulos)DGVArticulos.CurrentRow.DataBoundItem;
                
                FrmDetalle detalle = new FrmDetalle(seleccionado);
                
                detalle.ShowDialog();
            }
            else
                MessageBox.Show("Seleccione un articulo para ver el detalle");
        }

        private void Btnbuscar_Click(object sender, EventArgs e)
        {
     
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> listaFiltrada;

            string filtro = TxtBuscar.Text;
            if (filtro.Length >= 2)
            {
                listaFiltrada = ListaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Codigo.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.ToString().ToUpper().Contains(filtro.ToUpper()) || x.Precio.ToString().ToUpper().Contains(filtro.ToUpper()) || x.Marcas.ToString().ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {
                listaFiltrada = ListaArticulos;
                
            }
            DGVArticulos.DataSource = null;
            DGVArticulos.DataSource = listaFiltrada;
            OcultarColumnas();
        }
    }
}
        

