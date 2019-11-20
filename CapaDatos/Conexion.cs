using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public static class Conexion
    {
        private static string server = @"(local)\SQLExpress";
        private static string db = @"TPFinalProgra";
        private static string usuario = @"sa";
        private static string clave = @"123";

        public static string DarStrConexion()
        {
            return string.Concat(@"Data Source=", server, ";Initial Catalog=", db,
                ";Persist Security Info=False;User ID=", usuario, ";Password=", clave);
        }
    }
}
