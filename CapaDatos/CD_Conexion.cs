using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;

namespace CapaDatos
{
    public class CD_Conexion
    {
        string cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
        private SqlConnection Conexion; // = new SqlConnection("Server=(local);Database=PRODUCTOSDIGITALPRO;Integrated Security=true;Encrypt=false");

        public CD_Conexion()
        {
            Conexion = new SqlConnection(cadenaConexion);
        }
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion;
        }
    }
}

