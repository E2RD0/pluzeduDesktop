using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace LoginForm.Database
{
    class funcionesCRUD
    {
        //NIVELES
        public static DataTable mostrarNiveles()
        {
            DataTable datos = new DataTable();
            string instrucciones = "SELECT * FROM nivel";
            MySqlCommand comando = new MySqlCommand(instrucciones, conexion.obtenerconexion());
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            adapter.Fill(datos);
            return datos;
        }
        public static int agregarNivel(constructor nivel)
        {
            int retorno;
            MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO nivel(id, nombre) VALUES('{0}', '{1}')", nivel.idNivel, nivel.nombreNivel), conexion.obtenerconexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static int actualizarNivel(constructor nivel, int id)
        {
            int retorno;
            MySqlCommand comando = new MySqlCommand(String.Format("UPDATE nivel SET nombre = '{0}' WHERE id={1}", nivel.nombreNivel, id), conexion.obtenerconexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static int eliminarNivel(int id)
        {
            int retorno;
            MySqlCommand comando = new MySqlCommand(String.Format("DELETE FROM nivel WHERE id={0}", id), conexion.obtenerconexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static DataTable mostrarUsuariosNivel(int tipo, int nivel)
        {
            DataTable datos = new DataTable();
            //string instrucciones = "SELECT u.id AS ID, u.nombres AS Nombres, u.apellidos AS Apellidos, u.username AS Usuario, u.email AS Email, u.clave AS Clave, u.codigo AS Codigo, t.nombre AS Tipo, e.nombre AS Estado FROM usuario u, usuarioestado e, usuariotipo t WHERE u.id_usuariotipo=t.id AND u.id_usuarioestado=e.id";
            string instrucciones = String.Format("SELECT u.id AS ID, u.nombres AS Nombres, u.apellidos AS Apellidos, u.username AS Usuario, u.email AS Email, u.clave AS Clave, u.codigo AS Codigo, t.nombre AS Tipo, e.nombre AS Estado FROM usuario u INNER JOIN usuarioestado e ON u.id_usuarioestado = e.id INNER JOIN usuariotipo t ON u.id_usuariotipo = t.id INNER JOIN nivelesusuario n ON u.id = n.id_usuario WHERE u.id_usuariotipo = {0} AND n.id_nivel = {1};", tipo, nivel);
            MySqlCommand comando = new MySqlCommand(instrucciones, conexion.obtenerconexion());
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            adapter.Fill(datos);
            return datos;
        }
        public static DataTable mostrarTipoUsuarioNivel()
        {
            DataTable datos = new DataTable();
            string instrucciones = "SELECT * FROM usuariotipo WHERE id=2 OR id=3";
            MySqlCommand comando = new MySqlCommand(instrucciones, conexion.obtenerconexion());
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            adapter.Fill(datos);
            return datos;
        }
        //FIN NIVELES

        //USUARIOS
        public static DataTable mostrarUsuarios(int tipo)
        {
            DataTable datos = new DataTable();
            //string instrucciones = "SELECT u.id AS ID, u.nombres AS Nombres, u.apellidos AS Apellidos, u.username AS Usuario, u.email AS Email, u.clave AS Clave, u.codigo AS Codigo, t.nombre AS Tipo, e.nombre AS Estado FROM usuario u, usuarioestado e, usuariotipo t WHERE u.id_usuariotipo=t.id AND u.id_usuarioestado=e.id";
            string instrucciones = "SELECT u.id AS ID, u.nombres AS Nombres, u.apellidos AS Apellidos, u.username AS Usuario, u.email AS Email, u.clave AS Clave, u.codigo AS Codigo, t.nombre AS Tipo, e.nombre AS Estado FROM ((usuario u INNER JOIN usuarioestado e ON u.id_usuarioestado = e.id) INNER JOIN usuariotipo t ON u.id_usuariotipo = t.id) WHERE u.id_usuariotipo = " + tipo;
            MySqlCommand comando = new MySqlCommand(instrucciones, conexion.obtenerconexion());
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            adapter.Fill(datos);
            return datos;
        }
        public DataTable mostrarTipoUsuario()
        {
            DataTable datos = new DataTable();
            string instrucciones = "SELECT * FROM usuariotipo";
            MySqlCommand comando = new MySqlCommand(instrucciones, conexion.obtenerconexion());
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            adapter.Fill(datos);
            return datos;
        }
        public DataTable mostrarEstadoUsuario()
        {
            DataTable datos = new DataTable();
            string instrucciones = "SELECT * FROM usuarioestado WHERE id <> 3";
            MySqlCommand comando = new MySqlCommand(instrucciones, conexion.obtenerconexion());
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            adapter.Fill(datos);
            return datos;
        }
        public static int agregarUsuarios(constructor agregar)
        {
            int retorno = 0;
            MySqlCommand command = new MySqlCommand(string.Format("INSERT INTO usuario(nombres, apellidos, username, email, clave, codigo, id_usuariotipo, id_usuarioestado) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", agregar.nombresUsuario, agregar.apellidosUsuario, agregar.usernameUsuario, agregar.emailUsuario, agregar.claveUsuario, agregar.codigoUsuario, agregar.id_usuariotipoUsuario, agregar.id_usuarioestadoUsuario), conexion.obtenerconexion());
            retorno = command.ExecuteNonQuery();
            return retorno;
        }
        public static int eliminarUsuarios(int id)
        {
            int retorno = 0;
            MySqlCommand command = new MySqlCommand(string.Format("DELETE FROM usuario WHERE id='{0}'", id), conexion.obtenerconexion());
            retorno = command.ExecuteNonQuery();
            return retorno;
        }
        public static int update(constructor actu)
        {
            int retorno = 0;
            MySqlCommand command = new MySqlCommand(string.Format("UPDATE usuario SET nombres='{0}', apellidos='{1}', username='{2}', email='{3}', clave='{4}', codigo='{5}', id_usuariotipo='{6}', id_usuarioestado='{7}' WHERE id='{8}'", actu.nombresUsuario, actu.apellidosUsuario, actu.usernameUsuario, actu.emailUsuario, actu.claveUsuario, actu.codigoUsuario, actu.id_usuariotipoUsuario, actu.id_usuarioestadoUsuario, actu.idUsuario), conexion.obtenerconexion());
            retorno = command.ExecuteNonQuery();
            return retorno;
        }
    }
}