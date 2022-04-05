using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Repositorios
{
    class Conexion
    {
        public static string ObtenerStringConexion()
        {
            string strCone = "";

            ConfigurationBuilder cb = new ConfigurationBuilder();
            cb.AddJsonFile("appsettings.json");
            IConfiguration configuracion = cb.Build();

            strCone = configuracion.GetConnectionString("Conexion1");

            return strCone;
        }

        public static SqlConnection ObtenerConexion()
        {
            string strCon = ObtenerStringConexion();
            return new SqlConnection(strCon);
        }

        public static void AbrirConexion(SqlConnection con)
        {
            if (con != null && con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        public static void CerrarYDisposeConexion(SqlConnection con)
        {
            CerrarConexion(con);
            con.Dispose();
        }

        public static void CerrarConexion(SqlConnection con)
        {
            if (con != null && con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }
    }
}
