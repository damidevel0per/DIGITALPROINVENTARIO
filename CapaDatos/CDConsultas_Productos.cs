using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CDConsultas_Productos
    {

        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            //storeprocedure MostrarProductos
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string nombre, string descripcion, string marca, double precio, int stock, string url)
        {
            //storeprocedure InsertarProducto
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@desc", descripcion);
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@ImagenUrl", url);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(string nombre, string descripcion, string marca, double precio, int stock, int id, string url)
        {
            //storeprocedure EditarProductos
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@desc", descripcion);
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@ImagenUrl", url);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idproducto", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
