using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominioo;
using System.Data.SqlClient;

namespace Negocio
{
    public class ProductosNegocio
    {
        

        public List<Articulos> Listar()
        {

            List<Articulos> Lista = new List<Articulos>();

            SqlConnection conexion = new SqlConnection();

            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server =.\\SQLEXPRESS; database = CATALOGO_DB; integrated security = true";

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion Marcas, A.IdMarca,C.Descripcion Categoria, A.IdCategoria,ImagenUrl,Precio from ARTICULOS A, MARCAS M, CATEGORIAS C where M.Id = A.IdMarca and C.Id = A.IdCategoria";

                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())

                {
                    Articulos aux = new Articulos();
                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                 
                 if (!(lector["ImagenUrl"] is DBNull))
                    aux.ImagenUrl = (string)lector["ImagenUrl"];
                    aux.Marcas = new Marca();
                    aux.Marcas.Id = (int)lector["IdMarca"];
                    aux.Marcas.Descripcion = (string)lector["Marcas"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)lector["Categoria"];
                    if(!(lector["Precio"] is DBNull))
                    aux.Precio = Math.Round((Decimal)lector["Precio"],2);

                    Lista.Add(aux);
                }

                conexion.Close();
                return Lista;
            }

            catch (Exception ex)
            {

                throw ex;

            }
        }
        public void Agregar (Articulos arti)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta ("INSERT INTO [ARTICULOS] ([Codigo], [Nombre], [Descripcion], [Precio], [IdMarca], [IdCategoria], [ImagenUrl] ) VALUES (@codigo, @nombre, @descripcion,@precio, @idMarca, @idCategoria,@imagenUrl)");
                datos.setearParametro("@codigo", arti.Codigo);
                datos.setearParametro("@nombre", arti.Nombre);
                datos.setearParametro("@descripcion", arti.Descripcion);
                datos.setearParametro("@idMarca", arti.Marcas.Id);
                datos.setearParametro("@idCategoria", arti.Categoria.Id);
                datos.setearParametro("@imagenUrl", arti.ImagenUrl);
                datos.setearParametro("@precio", arti.Precio);
          

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
      

        }

       public void Modificar (Articulos arti)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @idCategoria, ImagenUrl = @imagenUrl, Precio = @precio where Id = @id");
                datos.setearParametro("@codigo", arti.Codigo);
                datos.setearParametro("@nombre", arti.Nombre);
                datos.setearParametro("@descripcion", arti.Descripcion);
                datos.setearParametro("@idMarca", arti.Marcas.Id);
                datos.setearParametro("@idCategoria", arti.Categoria.Id);
                datos.setearParametro("@imagenUrl", arti.ImagenUrl);
                datos.setearParametro("@precio", arti.Precio);
                datos.setearParametro("@id", arti.Id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        
    }
        public void Eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();

                datos.setearConsulta("delete from ARTICULOS where  id = @id ");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
