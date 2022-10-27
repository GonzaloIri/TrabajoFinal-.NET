﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{ 
 public class AccesoDatos
{
    private SqlConnection Conexion;
    private SqlCommand comando;
    private SqlDataReader lector;

    public SqlDataReader Lector
    {
        get { return lector; }
    }

    public AccesoDatos()
    {

        Conexion = new SqlConnection("server =.\\SQLEXPRESS; database = CATALOGO_DB; integrated security = true");
        comando = new SqlCommand();

    }

    public void setearConsulta(string consulta)
    {
        comando.CommandType = System.Data.CommandType.Text;
        comando.CommandText = consulta;

    }
    public void ejecutarLectura()
    {
        comando.Connection = Conexion;
        Conexion.Open();
        lector = comando.ExecuteReader();
        try
        {

        }
        catch (Exception ex)
        {

            throw ex;
        }

    }

    public void ejecutarAccion()
    {
        comando.Connection = Conexion;
        try
        {
            Conexion.Open();
            comando.ExecuteNonQuery();


        }
        catch (Exception ex)
        {


            throw ex;
        }
    }

    public void setearParametro(string nombre, object valor)
    {
        comando.Parameters.AddWithValue(nombre, valor);
    }
    public void cerrarConexion()
    {
        if (lector != null)
            lector.Close();
        Conexion.Close();
    }

        internal void SetearQuery(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        internal void SetearQuery(string v)
        {
            throw new NotImplementedException();
        }
    }
}