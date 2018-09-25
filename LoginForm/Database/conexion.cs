using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace LoginForm.Database
{
    class conexion
    {
        public static MySqlConnection obtenerconexion()
        {
            string server = "127.0.0.1";
            string database = "pluzeduv2.0";
            string Uid = "root";
            string pwd = "";
            MySqlConnection con = new MySqlConnection("server=" + server + "; database=" + database + "; Uid=" + Uid + "; pwd=" + pwd+";CharSet=utf8");
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido conectar a la base de datos: " + ex.Message, "Error de conexión");
            }
            return con;
        }
    }
}
