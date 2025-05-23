using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Productos
    {
        private CDConsultas_Productos objCD = new CDConsultas_Productos();

        public DataTable MostrarProductos()
        {
            DataTable tabla = new DataTable();
            tabla = objCD.Mostrar();
            return tabla;
        }
        public void InsertarProductos(string nombre, string descripcion, string marca, string precio, string stock, string url)
        {
            objCD.Insertar(nombre, descripcion, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), url);
        }

        public void EditarProductos(string nombre, string descripcion, string marca, string precio, string stock, string id, string url)
        {
            objCD.Editar(nombre, descripcion, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), Convert.ToInt32(id), url);
        }

        public void EliminarProductos(string id)
        {
            objCD.Eliminar(Convert.ToInt32(id));
        }
    }
}
