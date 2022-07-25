using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccesoDatos
    {
        private string cadConexion;
        private SqlConnection conexGlobal = null;

        public AccesoDatos(string cadenaBD)
        {
            cadConexion = cadenaBD;
            conexGlobal = new SqlConnection();
        }
        private string AbrirConexion()
        {
            string msj = "";
            conexGlobal.ConnectionString = cadConexion;
            try
            {
                conexGlobal.Open();
                msj = "Conexión abierta CORRECTAMENTE";
            }
            catch (Exception f)
            {
                conexGlobal = null;
                msj = "Error: " + f.Message;
            }
            return msj;
        }
        private void CerrarConexion()
        {
            if (conexGlobal != null)
            {
                if (conexGlobal.State == ConnectionState.Open)
                {
                    conexGlobal.Close();
                    conexGlobal.Dispose();
                }
            }
        }
        public SqlDataReader ConsultarReaderconParametros(string querySql, ref string mensaje, List<SqlParameter> listaParametros)
        {
            SqlCommand carrito = null;
            SqlDataReader contenedor = null;

            mensaje = AbrirConexion();

            if (conexGlobal == null)
            {
                mensaje = "No hay conexion a la BD";
                contenedor = null;
            }
            else
            {
                carrito = new SqlCommand();
                carrito.CommandText = querySql;
                carrito.Connection = conexGlobal;
                foreach (SqlParameter p in listaParametros)
                {
                    carrito.Parameters.Add(p);
                }

                try
                {
                    contenedor = carrito.ExecuteReader();
                    mensaje = "Consulta Correcta DataReader";
                }
                catch (Exception a)
                {
                    contenedor = null;
                    mensaje = "Error!" + a.Message;
                }
            }
            return contenedor;
        }
        public Boolean modificacionSegura(string senteniciaSql, ref string mensaje, List<SqlParameter> listaParametros)
        {
            Boolean salida = false;
            SqlCommand carrito = null;
            mensaje = AbrirConexion();

            if (conexGlobal != null)
            {
                carrito = new SqlCommand();
                carrito.CommandText = senteniciaSql;
                carrito.Connection = conexGlobal;

                foreach (SqlParameter p in listaParametros)
                {
                    carrito.Parameters.Add(p);
                }

                try
                {
                    carrito.ExecuteNonQuery();
                    salida = true;
                    mensaje = "Modificación correcta.";
                }
                catch (Exception f)
                {
                    salida = false;
                    mensaje = "ERROR: " + f.Message;
                }
            }
            else
            {
                salida = false;
                mensaje = "No hay conexión a la BD.";
            }
            return salida;
        }

    }
}
