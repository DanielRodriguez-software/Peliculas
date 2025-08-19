using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Reflection.Emit;


namespace Modelo
{
    public class Conexion
    {
        private static string servidor = "LAPTOP-EB3ITU8A\\SQLEXPRESS";
        private static string baseDatos = "Ver";

        public static SqlConnection Conectar()
        {
            string cadena = $"Data Source ={servidor};Initial Catalog ={baseDatos};Integrated Security = true;";
            SqlConnection con = new SqlConnection(cadena);
            con.Open();
            return con;
        }
    }
}
