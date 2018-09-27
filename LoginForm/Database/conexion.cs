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
            //string server = "138.68.15.62";
            //string database = "pluzedu";
            //string Uid = "app";
            //string pwd = "PLuz3d7MYsq!";
            string server = "127.0.0.1";
            string database = "pluzeduv2.0";
            string Uid = "root";
            string pwd = "";
            MySqlConnection con = new MySqlConnection("server=" + server + "; database=" + database + "; Uid=" + Uid + "; pwd=" + pwd+";CharSet=utf8");
            try
            {
                con.Open();
            }
            catch
            {
                MessageBox.Show("No se ha podido conectar con el servidor. Revisa tu conexión de internet." , "Error de conexión");
            }
            return con;
        }
    }
}
