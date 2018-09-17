using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using LoginForm.User;

namespace LoginForm.Database
{
    class funcionesCRUD
    {
        //INCIO NIVELES
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
        public static DataTable buscarContactosNivel(int tipo,int nivel, string busqueda)
        {
            DataTable datos = new DataTable();
            //string query = "'CONCAT('%'," + busqueda + ",'%')'";
            //MySqlCommand command = new MySqlCommand("SELECT u.nombres, u.apellidos FROM usuario u INNER JOIN usuarioestado e ON u.id_usuarioestado = e.id INNER JOIN usuariotipo t ON u.id_usuariotipo = t.id INNER JOIN nivelesusuario n ON u.id = n.id_usuario WHERE u.id_usuariotipo = @tipo AND n.id_nivel = @nivel AND u.id <> @id AND (u.nombres LIKE @busqueda OR u.apellidos LIKE @busqueda) ORDER BY u.nombres ASC", conexion.obtenerconexion());
            MySqlCommand command = new MySqlCommand("SELECT u.id AS ID, u.nombres AS Nombres, u.apellidos AS apellidos FROM usuario u INNER JOIN usuarioestado e ON u.id_usuarioestado = e.id INNER JOIN usuariotipo t ON u.id_usuariotipo = t.id INNER JOIN nivelesusuario n ON u.id = n.id_usuario WHERE n.id_nivel = " + nivel + " AND u.id_usuariotipo = " + tipo + " AND (u.nombres LIKE '%" + busqueda + "%' OR u.apellidos LIKE '%" + busqueda + "%') ORDER BY u.nombres ASC", conexion.obtenerconexion());
            //command.Parameters.Add("@tipo", MySqlDbType.Int32).Value = tipo;
            //command.Parameters.Add("@nivel", MySqlDbType.Int32).Value = nivel;
            //command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            //command.Parameters.Add("@busqueda", MySqlDbType.String).Value = query;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(datos);
            return datos;
        }
        //FIN NIVELES - INICIO USUARIOGENERAL (ADMIN Y USUARIO)
        public static void datosUsuarioActual(int idUsuario)
        {
            DataTable datosUsuario = new DataTable();
            string instrucciones = String.Format("SELECT id, nombres, apellidos, username, email, clave, codigo, id_usuariotipo, id_usuarioestado FROM usuario WHERE id = {0}", idUsuario);
            MySqlCommand usuarioComando = new MySqlCommand(instrucciones, Database.conexion.obtenerconexion());
            MySqlDataAdapter usuarioAdapter = new MySqlDataAdapter(usuarioComando);
            usuarioAdapter.Fill(datosUsuario);
            Database.usuarioActual.idUsuario = Convert.ToInt32(datosUsuario.Rows[0].ItemArray[0]);
            Database.usuarioActual.nombresUsuario = Convert.ToString(datosUsuario.Rows[0].ItemArray[1]);
            Database.usuarioActual.apellidosUsuario = Convert.ToString(datosUsuario.Rows[0].ItemArray[2]);
            Database.usuarioActual.usernameUsuario = Convert.ToString(datosUsuario.Rows[0].ItemArray[3]);
            Database.usuarioActual.emailUsuario = Convert.ToString(datosUsuario.Rows[0].ItemArray[4]);
            Database.usuarioActual.claveUsuario = Convert.ToString(datosUsuario.Rows[0].ItemArray[5]);
            if (datosUsuario.Rows[0].ItemArray[6] != System.DBNull.Value)
                Database.usuarioActual.codigoUsuario = Convert.ToInt32(datosUsuario.Rows[0].ItemArray[6]);
            Database.usuarioActual.id_usuariotipoUsuario = Convert.ToInt32(datosUsuario.Rows[0].ItemArray[7]);
            Database.usuarioActual.id_usuarioestadoUsuario = Convert.ToInt32(datosUsuario.Rows[0].ItemArray[8]);
        }
        public static int actualizarCorreo(int idUsuario, string emailUsuario)
        {
            int retorno;
            MySqlCommand command = new MySqlCommand("UPDATE usuario SET email=@emailUsuario WHERE id=@idUsuario", conexion.obtenerconexion());
            command.Parameters.Add("@emailUsuario", MySqlDbType.VarChar).Value = emailUsuario;
            command.Parameters.Add("@idUsuario", MySqlDbType.Int32).Value = idUsuario;
            retorno = command.ExecuteNonQuery();
            return retorno;
        }
        public static int actualizarClave(int idUsuario, string claveUsuario)
        {
            int retorno;
            MySqlCommand command = new MySqlCommand("UPDATE usuario SET clave=@claveUsuario WHERE id=@idUsuario", conexion.obtenerconexion());
            command.Parameters.Add("@claveUsuario", MySqlDbType.VarChar).Value = claveUsuario;
            command.Parameters.Add("@idUsuario", MySqlDbType.Int32).Value = idUsuario;
            retorno = command.ExecuteNonQuery();
            return retorno;
        }
        public static int actualizarUsername(int idUsuario, string userName)
        {
            int retorno;
            MySqlCommand command = new MySqlCommand("UPDATE usuario SET username=@usernameUsuario WHERE id=@idUsuario", conexion.obtenerconexion());
            command.Parameters.Add("@usernameUsuario", MySqlDbType.VarChar).Value = userName;
            command.Parameters.Add("@idUsuario", MySqlDbType.Int32).Value = idUsuario;
            retorno = command.ExecuteNonQuery();
            return retorno;
        }
        //FIN USUARIOGENERAL (ADMIN Y USUARIO) - INICIO ADMINISTRADOR
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
            MySqlCommand command = new MySqlCommand(string.Format("DELETE FROM usuario WHERE id=@id"), conexion.obtenerconexion());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
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
        //FIN ADMINISTRADOR - INICIO USUARIO
        public static DataTable nivelUsuario(int user)
        {
            DataTable datos = new DataTable();
            string instruccion = String.Format("SELECT n.id_nivel, u.id, nombre FROM nivelesusuario n INNER JOIN usuario u ON u.id=n.id_usuario INNER JOIN nivel ni ON ni.id = n.id_nivel WHERE u.id = {0}", user);
            MySqlCommand command = new MySqlCommand(instruccion, conexion.obtenerconexion());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(datos);
            return datos;
        }
        public static DataTable mostrarContactos(int tipo, int nivel, int id)
        {
            DataTable datos = new DataTable();
            string instruccion = String.Format("SELECT u.id, u.nombres, u.apellidos FROM usuario u INNER JOIN usuarioestado e ON u.id_usuarioestado = e.id INNER JOIN usuariotipo t ON u.id_usuariotipo = t.id INNER JOIN nivelesusuario n ON u.id = n.id_usuario WHERE u.id_usuariotipo = {0} AND n.id_nivel = {1} AND u.id <> {2} ORDER BY u.nombres ASC", tipo, nivel, id);
            MySqlCommand command = new MySqlCommand(instruccion, conexion.obtenerconexion());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(datos);
            return datos;
        }
        //FIN USUARIO - INICIO MENSAJES
        public static DataTable mostrarConversaciones(int idUsuario)
        {
            DataTable datos = new DataTable();
            MySqlCommand comando = new MySqlCommand("SELECT c.id, c.titulo, c.es_grupo FROM conversacion c INNER JOIN conversacionintegrantes ci ON ci.id_conversacion = c.id WHERE ci.id_usuario = @idUsuario;", conexion.obtenerconexion());
            comando.Parameters.Add("@idUsuario", MySqlDbType.Int32).Value = idUsuario;
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            adapter.Fill(datos);
            return datos;
        }
        public static DataTable ultimoMensaje(int idConversacion)
        {
            DataTable datos = new DataTable();
            MySqlCommand comando = new MySqlCommand("SELECT texto, fechaenviado, es_archivo FROM mensaje WHERE id_conversacion = @idConversacion ORDER BY fechaenviado DESC LIMIT 1;", conexion.obtenerconexion());
            comando.Parameters.Add("@idConversacion", MySqlDbType.Int32).Value = idConversacion;
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            adapter.Fill(datos);
            return datos;
        }
        public static DataTable mostrarMensajes(int idConversacion)
        {
            DataTable datos = new DataTable();
            MySqlCommand comando = new MySqlCommand("SELECT texto, fechaenviado, id_autor, es_archivo FROM mensaje WHERE id_conversacion = @idConversacion ORDER BY fechaenviado ASC;", conexion.obtenerconexion());
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
        public static int enviarArchivo(int idConversacion, string urlArchivo, int idAutor)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO mensaje(id_conversacion, texto, id_autor, es_archivo, fechaenviado) VALUES(@id_conversacion, @texto, @id_autor, 1, SYSDATE() );", conexion.obtenerconexion());
            command.Parameters.Add("@id_conversacion", MySqlDbType.Int32).Value = idConversacion;
            command.Parameters.Add("@texto", MySqlDbType.Text).Value = urlArchivo;
            command.Parameters.Add("@id_autor", MySqlDbType.Int32).Value = idAutor;
            return command.ExecuteNonQuery();
        }
        public static int crearConversacionIndividual(int id1, int id2)
        {
            int idConv;
            MySqlCommand command = new MySqlCommand("INSERT INTO conversacion(es_grupo) VALUES(0); SELECT LAST_INSERT_ID() FROM conversacion; ", conexion.obtenerconexion());
            idConv = Convert.ToInt32(command.ExecuteScalar());
            MySqlCommand comando = new MySqlCommand("INSERT INTO conversacionintegrantes(id_usuario, id_conversacion) VALUES('" + id1 + "','" + idConv + "'),('" + id2 + "', '" + idConv + "')", conexion.obtenerconexion());
            //MySqlCommand comando = new MySqlCommand("INSERT INTO conversacionintegrantes(id_usuario, id_conversacion) VALUES(@id1, @idConv),(@id2, @idConv)", conexion.obtenerconexion());
            //comando.Parameters.Add("@id1", MySqlDbType.Int32).Value = id1;
            //comando.Parameters.Add("@id2", MySqlDbType.Int32).Value = id2;
            //comando.Parameters.Add("@idConv", MySqlDbType.Int32).Value = idConv;
            return comando.ExecuteNonQuery();
        }
        public static int crearConversacionGrupal(int id1, int[] array, string descripcion, string titulo)
        {
            int idConv;
            MySqlCommand command = new MySqlCommand("INSERT INTO conversacion(id_admin, titulo, descripcion, es_grupo) VALUES(@id1, @titulo, @descripcion, 1); SELECT LAST_INSERT_ID() FROM conversacion; ", conexion.obtenerconexion());
            command.Parameters.Add("@id1", MySqlDbType.Int32).Value = id1;
            command.Parameters.Add("@id1", MySqlDbType.String).Value = titulo;
            command.Parameters.Add("@id1", MySqlDbType.String).Value = descripcion;
            idConv = Convert.ToInt32(command.ExecuteScalar());
            for (int i = 0; i < array.Length ; i++)
            {
                MySqlCommand comando = new MySqlCommand("INSERT INTO conversacionintegrantes(id_usuario, id_conversacion) VALUES('" + array[i] + "','" + idConv + "')", conexion.obtenerconexion());
                comando.ExecuteNonQuery();
            }
            return idConv;
        }
        public static int/*DataTable*/ conversacionIndivExiste(int id1, int id2)
        {
            DataTable dataTable = new DataTable();
            DataTable datos = dataTable;
            MySqlCommand command = new MySqlCommand("SELECT ci.id_conversacion, ci.id_usuario, c.es_grupo FROM conversacionintegrantes ci INNER JOIN conversacion c ON ci.id_conversacion = c.id WHERE ci.id_conversacion IN ( SELECT id_conversacion FROM conversacionintegrantes WHERE id_usuario = @id1 or id_usuario = @id2 GROUP BY id_conversacion HAVING COUNT(*) > 1 ) AND c.es_grupo = 0", conexion.obtenerconexion());
            command.Parameters.Add("@id1", MySqlDbType.Int32).Value = id1;
            command.Parameters.Add("@id2", MySqlDbType.Int32).Value = id2;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(datos);
            //return datos;
            if (datos.Rows.Count >= 2)
            {
                return Convert.ToInt32(datos.Rows[0].ItemArray[0]);
            }
            else
            {
                return 0;
            }
        }
        //COMPROBAR SI CONVERSACION GRUPAL EXISTE //public static int conversacionGrupExite(int id1, int[] array)/
        //{
        //    DataTable dataTable = new DataTable();
        //    DataTable datos = dataTable;
        //    MySqlCommand command = new MySqlCommand("SELECT ci.id_conversacion, ci.id_usuario, c.es_grupo FROM conversacionintegrantes ci INNER JOIN conversacion c ON ci.id_conversacion = c.id WHERE ci.id_conversacion IN ( SELECT id_conversacion FROM conversacionintegrantes WHERE id_usuario = @id1 or id_usuario = @id2 GROUP BY id_conversacion HAVING COUNT(*) > 1 ) AND c.es_grupo = 0", conexion.obtenerconexion());
        //    command.Parameters.Add("@id1", MySqlDbType.Int32).Value = id1;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        List<int> intArray = new List<int>() {array[i]};
        //        command.Parameters.AddWithValue("@id2", string.Join(",", intArray));
        //    }
        //    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
        //    adapter.Fill(datos);
        //    //return datos;
        //    if (datos.Rows.Count == array.Length)
        //    {
        //        return Convert.ToInt32(datos.Rows[0].ItemArray[0]);
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}
        public static int crearConversacionGrupal(int idConversacion, string texto, int idAutor)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO mensaje(id_conversacion, texto, id_autor, fechaenviado) VALUES(@id_conversacion, @texto, @id_autor, SYSDATE() );", conexion.obtenerconexion());
            command.Parameters.Add("@id_conversacion", MySqlDbType.Int32).Value = idConversacion;
            command.Parameters.Add("@texto", MySqlDbType.Text).Value = texto;
            command.Parameters.Add("@id_autor", MySqlDbType.Int32).Value = idAutor;
            return command.ExecuteNonQuery();
        }
        //FIN MENSAJES - INICIO RECUPERAR CONTRASEÑA
        public static DataTable verificarCorreo(string email)
        {
            DataTable datos = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT email FROM usuario WHERE email=@email", conexion.obtenerconexion());
            command.Parameters.Add("@email", MySqlDbType.String).Value = email;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(datos);
            return datos;
        }
        public static DataTable verificarReContra(string email)
        {
            DataTable datos = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT pin FROM recuperarclave WHERE email=@email", conexion.obtenerconexion());
            command.Parameters.Add("@email", MySqlDbType.String).Value = email;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(datos);
            return datos;
        }
        public static int subirPin(string pin, string email)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO recuperarclave(email, pin, fechalimite) VALUES(@email, @pin, NOW() + INTERVAL 15 MINUTE);", conexion.obtenerconexion());
            command.Parameters.Add("@pin", MySqlDbType.String).Value = pin;
            command.Parameters.Add("@email", MySqlDbType.String).Value = email;
            return command.ExecuteNonQuery();
        }
        public static DataTable verificarPin(string pin)
        {
            DataTable datos = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT pin FROM recuperarclave WHERE pin=@pin", conexion.obtenerconexion());
            command.Parameters.Add("@pin", MySqlDbType.String).Value = pin;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(datos);
            return datos;
        }
        public static int cambiarClave(string correoUsuario, string claveUsuario)
        {
            int retorno;
            MySqlCommand command = new MySqlCommand("UPDATE usuario SET clave=@claveUsuario WHERE email=@correo", conexion.obtenerconexion());
            command.Parameters.Add("@claveUsuario", MySqlDbType.VarChar).Value = claveUsuario;
            command.Parameters.Add("@correo", MySqlDbType.String).Value = correoUsuario;
            retorno = command.ExecuteNonQuery();
            return retorno;
        }
        public static int eliminarPin(string pin)
        {
            int retorno;
            MySqlCommand command = new MySqlCommand(string.Format("DELETE FROM recuperarclave WHERE pin=@pin"), conexion.obtenerconexion());
            command.Parameters.Add("@pin", MySqlDbType.String).Value = pin;
            retorno = command.ExecuteNonQuery();
            return retorno;
        }
        //FIN RECUPERAR CONTRASEÑA - INICIO BUSCAR
        public static DataTable buscarContactos(int nivel, int id, string busqueda)
        {
            DataTable datos = new DataTable();
            //string query = "'CONCAT('%'," + busqueda + ",'%')'";
            //MySqlCommand command = new MySqlCommand("SELECT u.nombres, u.apellidos FROM usuario u INNER JOIN usuarioestado e ON u.id_usuarioestado = e.id INNER JOIN usuariotipo t ON u.id_usuariotipo = t.id INNER JOIN nivelesusuario n ON u.id = n.id_usuario WHERE u.id_usuariotipo = @tipo AND n.id_nivel = @nivel AND u.id <> @id AND (u.nombres LIKE @busqueda OR u.apellidos LIKE @busqueda) ORDER BY u.nombres ASC", conexion.obtenerconexion());
            MySqlCommand command = new MySqlCommand("SELECT u.nombres, u.apellidos, u.id , t.nombre FROM usuario u INNER JOIN usuarioestado e ON u.id_usuarioestado = e.id INNER JOIN usuariotipo t ON u.id_usuariotipo = t.id INNER JOIN nivelesusuario n ON u.id = n.id_usuario WHERE (u.id_usuariotipo = 2 OR u.id_usuariotipo = 3) AND n.id_nivel = " + nivel + " AND u.id <> " + id + " AND (u.nombres LIKE '%" + busqueda + "%' OR u.apellidos LIKE '%" + busqueda + "%') ORDER BY u.nombres ASC", conexion.obtenerconexion());
            //command.Parameters.Add("@tipo", MySqlDbType.Int32).Value = tipo;
            //command.Parameters.Add("@nivel", MySqlDbType.Int32).Value = nivel;
            //command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            //command.Parameters.Add("@busqueda", MySqlDbType.String).Value = query;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(datos);
            return datos;
        }
        public static DataTable mostrarContactosBuscar(int nivel, int id)
        {
            DataTable datos = new DataTable();
            string instruccion = String.Format("SELECT u.id, u.nombres, u.apellidos, t.nombre FROM usuario u INNER JOIN usuarioestado e ON u.id_usuarioestado = e.id INNER JOIN usuariotipo t ON u.id_usuariotipo = t.id INNER JOIN nivelesusuario n ON u.id = n.id_usuario WHERE u.id_usuariotipo <> 1 AND n.id_nivel = {0} AND u.id <> {1} ORDER BY u.nombres ASC", nivel, id);
            MySqlCommand command = new MySqlCommand(instruccion, conexion.obtenerconexion());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(datos);
            return datos;
        }
        //FIN BUSCAR
    }
}