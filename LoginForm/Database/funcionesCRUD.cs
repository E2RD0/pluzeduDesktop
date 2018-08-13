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
            MySqlCommand comando = new MySqlCommand("INSERT INTO nivel(nombre) VALUES(@nombreNivel)", conexion.obtenerconexion());
            comando.Parameters.Add("@nombreNivel", MySqlDbType.VarChar).Value = nivel.nombreNivel;
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static int actualizarNivel(constructor nivel, int id)
        {
            int retorno;
            MySqlCommand comando = new MySqlCommand("UPDATE nivel SET nombre=@nombreNivel WHERE id=@idNivel", conexion.obtenerconexion());
            comando.Parameters.Add("@nombreNivel", MySqlDbType.VarChar).Value = nivel.nombreNivel;
            comando.Parameters.Add("@idNivel", MySqlDbType.Int32).Value = id;
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
        public static int agregarUsuarios(constructor usuario)
        {
            int retorno;
            MySqlCommand command = new MySqlCommand("INSERT INTO usuario(nombres, apellidos, username, email, clave, codigo, id_usuariotipo, id_usuarioestado) VALUES (@nombresUsuario, @apellidosUsuario, @usernameUsuario, @emailUsuario, @claveUsuario, @codigoUsuario, @idTipoUsuario, @idEstadoUsuario)", conexion.obtenerconexion());
            command.Parameters.Add("@nombresUsuario", MySqlDbType.VarChar).Value = usuario.nombresUsuario;
            command.Parameters.Add("@apellidosUsuario", MySqlDbType.VarChar).Value = usuario.apellidosUsuario;
            command.Parameters.Add("@usernameUsuario", MySqlDbType.VarChar).Value = usuario.usernameUsuario;
            command.Parameters.Add("@emailUsuario", MySqlDbType.VarChar).Value = usuario.emailUsuario;
            command.Parameters.Add("@claveUsuario", MySqlDbType.VarChar).Value = usuario.claveUsuario;
            command.Parameters.Add("@codigoUsuario", MySqlDbType.Int32).Value = usuario.codigoUsuario;
            command.Parameters.Add("@idTipoUsuario", MySqlDbType.Int32).Value = usuario.id_usuariotipoUsuario;
            command.Parameters.Add("@idEstadoUsuario", MySqlDbType.Int32).Value = usuario.id_usuarioestadoUsuario;
            retorno = command.ExecuteNonQuery();
            return retorno;
        }
        public static int eliminarUsuarios(int id)
        {
            int retorno;
            MySqlCommand command = new MySqlCommand(string.Format("DELETE FROM usuario WHERE id='{0}'", id), conexion.obtenerconexion());
            retorno = command.ExecuteNonQuery();
            return retorno;
        }
        public static int update(constructor usuario)
        {
            int retorno;
            MySqlCommand command = new MySqlCommand("UPDATE usuario SET nombres=@nombresUsuario, apellidos=@apellidosUsuario, username=@usernameUsuario, email=@emailUsuario, clave=@claveUsuario, codigo=@codigoUsuario, id_usuariotipo=@idTipoUsuario, id_usuarioestado=@idEstadoUsuario WHERE id=@idUsuario", conexion.obtenerconexion());
            command.Parameters.Add("@nombresUsuario", MySqlDbType.VarChar).Value = usuario.nombresUsuario;
            command.Parameters.Add("@apellidosUsuario", MySqlDbType.VarChar).Value = usuario.apellidosUsuario;
            command.Parameters.Add("@usernameUsuario", MySqlDbType.VarChar).Value = usuario.usernameUsuario;
            command.Parameters.Add("@emailUsuario", MySqlDbType.VarChar).Value = usuario.emailUsuario;
            command.Parameters.Add("@claveUsuario", MySqlDbType.VarChar).Value = usuario.claveUsuario;
            command.Parameters.Add("@codigoUsuario", MySqlDbType.Int32).Value = usuario.codigoUsuario;
            command.Parameters.Add("@idTipoUsuario", MySqlDbType.Int32).Value = usuario.id_usuariotipoUsuario;
            command.Parameters.Add("@idEstadoUsuario", MySqlDbType.Int32).Value = usuario.id_usuarioestadoUsuario;
            command.Parameters.Add("@idUsuario", MySqlDbType.Int32).Value = usuario.idUsuario;
            retorno = command.ExecuteNonQuery();
            return retorno;
        }

        //FIN USUARIOS

        //MENSAJES

        public static DataTable mostrarConversaciones(int idUsuario)
        {
            DataTable datos = new DataTable();
            MySqlCommand comando = new MySqlCommand("SELECT c.id, c.titulo, c.es_grupo FROM conversacion c INNER JOIN conversacionintegrantes ci ON ci.id_conversacion = c.id WHERE ci.id_usuario = @idUsuario;", conexion.obtenerconexion());
            comando.Parameters.Add("@idUsuario", MySqlDbType.Int32).Value = idUsuario;
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            adapter.Fill(datos);
            return datos;
        }
        public static DataTable mostrarMensajes(int idConversacion)
        {            
            DataTable datos = new DataTable();
            MySqlCommand comando = new MySqlCommand("SELECT texto, fechaenviado, id_autor FROM mensaje WHERE id_conversacion = @idConversacion ORDER BY fechaenviado ASC;", conexion.obtenerconexion());
            comando.Parameters.Add("@idConversacion", MySqlDbType.Int32).Value = idConversacion;
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            adapter.Fill(datos);
            return datos;
        }
        public static int enviarMensaje(int idConversacion, string texto, int idAutor)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO mensaje(id_conversacion, texto, id_autor, fechaenviado) VALUES(@id_conversacion, @texto, @id_autor, SYSDATE() );", conexion.obtenerconexion());
            command.Parameters.Add("@id_conversacion", MySqlDbType.Int32).Value = idConversacion;
            command.Parameters.Add("@texto", MySqlDbType.Text).Value = texto;
            command.Parameters.Add("@id_autor", MySqlDbType.Int32).Value = idAutor;
            return command.ExecuteNonQuery();
        }
    }
}