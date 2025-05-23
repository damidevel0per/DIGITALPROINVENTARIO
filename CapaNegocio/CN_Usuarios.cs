using CapaDatos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Usuarios
    {
        private CD_Usuarios objUsuarios = new CD_Usuarios();
        public bool LoginUsuario(string usuario, string clave)
        {
            if (objUsuarios.Login(usuario, clave))
            {
                return true ;
            }
            else { return false ; }
        }
    }
}
