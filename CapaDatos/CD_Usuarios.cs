using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Usuarios
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();

        public bool Login(string usuario, string pass)
        {
            //storeprocedure Login
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "LoginUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Usuario", usuario);
            comando.Parameters.AddWithValue("@Clave", pass);
            int respuestaQuery = (int)comando.ExecuteScalar();
            comando.Parameters.Clear();
            return respuestaQuery > 0;

        }
    }
}
