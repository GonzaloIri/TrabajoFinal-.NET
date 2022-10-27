﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominioo;
namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> Listar()
        {

            List<Marca> Lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Select Id, Descripcion from MARCAS");
                datos.ejecutarLectura();
                while (datos.Lector.Read())

                {

                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    Lista.Add(aux);
                }
                return Lista;
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

    }
}

