using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        Thread th;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public Form1()
        {
            InitializeComponent();
        }
        private void barra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario" + Convert.ToChar(0x00002063).ToString())
            {
                txtUser.Text = "";
            }
        }
        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario" + Convert.ToChar(0x00002063).ToString();
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña" + Convert.ToChar(0x00002063).ToString())
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Contraseña" + Convert.ToChar(0x00002063).ToString();
                txtPassword.UseSystemPasswordChar = false;
            }
        }



        private void abrirAdmin(object obj)
        {
            Application.Run(new Admin.menu());
        }
        private void abrirUsuario(object obj)
        {
            Application.Run(new Inicio());
        }

        private void ingresar()
        {
            try
            {
                DataTable datosClave = new DataTable();
                DataTable datosDefault = new DataTable();
                MySqlCommand comandoHash = new MySqlCommand("SELECT id, clave FROM usuario WHERE username=@User OR email=@User", Database.conexion.obtenerconexion());
                comandoHash.Parameters.Add("@User", MySqlDbType.VarChar).Value = txtUser.Text;

                MySqlDataAdapter adapterHash = new MySqlDataAdapter(comandoHash);
                adapterHash.Fill(datosClave);

                string cmdDefault = "SELECT COLUMN_DEFAULT FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA ='pluzedu' AND TABLE_NAME = 'usuario' AND COLUMN_NAME = 'clave';";
                MySqlCommand comandoDefault = new MySqlCommand(cmdDefault, Database.conexion.obtenerconexion());
                MySqlDataAdapter adapterDefault = new MySqlDataAdapter(comandoDefault);
                adapterDefault.Fill(datosDefault);

                string defaultPassword = Convert.ToString(datosDefault.Rows[0].ItemArray[0]);

                if (datosClave.Rows.Count > 0)
                {
                    int idUsuario = Convert.ToInt32(datosClave.Rows[0].ItemArray[0]);
                    string hashUsuario = Convert.ToString(datosClave.Rows[0].ItemArray[1]);
                    bool ingreso = false;
                    if (hashUsuario == "pluzedu" || hashUsuario == defaultPassword)
                    {
                        if (txtPassword.Text == "pluzedu" && hashUsuario == "pluzedu")
                        {
                            ingreso = true;
                        }
                        else if (txtPassword.Text == defaultPassword && hashUsuario == defaultPassword)
                        {
                            ingreso = true;
                        }
                        else
                        {
                            ingreso = false;
                        }
                    }
                    else
                    {
                        ingreso = Database.hashing.ValidatePassword(txtPassword.Text, hashUsuario);
                    }

                    if (ingreso == true)
                    {
                        DataTable datosUsuario = new DataTable();
                        string instrucciones = String.Format("SELECT id, nombres, apellidos, username, email, clave, codigo, id_usuariotipo, id_usuarioestado FROM usuario WHERE id = {0}", idUsuario);
                        MySqlCommand usuarioComando = new MySqlCommand(instrucciones, Database.conexion.obtenerconexion());
                        MySqlDataAdapter usuarioAdapter = new MySqlDataAdapter(usuarioComando);
                        usuarioAdapter.Fill(datosUsuario);
                        Database.constructor usuario = new Database.constructor();
                        usuario.idUsuario = Convert.ToInt32(datosUsuario.Rows[0].ItemArray[0]);
                        usuario.nombresUsuario = Convert.ToString(datosUsuario.Rows[0].ItemArray[1]);
                        usuario.apellidosUsuario = Convert.ToString(datosUsuario.Rows[0].ItemArray[2]);
                        usuario.usernameUsuario = Convert.ToString(datosUsuario.Rows[0].ItemArray[3]);
                        if (datosUsuario.Rows[0].ItemArray[4] != DBNull.Value)
                            usuario.emailUsuario = Convert.ToString(datosUsuario.Rows[0].ItemArray[4]);
                        if (datosUsuario.Rows[0].ItemArray[5] != DBNull.Value)
                            usuario.claveUsuario = Convert.ToString(datosUsuario.Rows[0].ItemArray[5]);
                        if (datosUsuario.Rows[0].ItemArray[6] != System.DBNull.Value)
                            usuario.codigoUsuario = Convert.ToInt32(datosUsuario.Rows[0].ItemArray[6]);
                        usuario.id_usuariotipoUsuario = Convert.ToInt32(datosUsuario.Rows[0].ItemArray[7]);
                        usuario.id_usuarioestadoUsuario = Convert.ToInt32(datosUsuario.Rows[0].ItemArray[8]);
                        if (usuario.id_usuarioestadoUsuario == 1)
                        {
                            if (usuario.id_usuariotipoUsuario == 1)
                            {
                                this.Close();
                                th = new Thread(abrirAdmin);
                                th.SetApartmentState(ApartmentState.STA);
                                th.Start();
                            }
                            else if (usuario.id_usuariotipoUsuario == 2 || usuario.id_usuariotipoUsuario == 3)
                            {
                                this.Close();
                                th = new Thread(abrirUsuario);
                                th.SetApartmentState(ApartmentState.STA);
                                th.Start();
                            }
                        }
                        else
                        {
                            MessageBox.Show("El usuario esta inhabilitado o eliminado. Comunicate con un administrador", "Estado de usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos, intenta de nuevo", "Datos erroneos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos, intenta de nuevo", "Datos erroneos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception eIngreso)
            {
                MessageBox.Show("Error: " + eIngreso.Message);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ingresar();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            txtUser.Text = "Usuario" + Convert.ToChar(0x00002063).ToString();
            txtPassword.Text = "Contraseña" + Convert.ToChar(0x00002063).ToString();
            btnMin.Font = btnClose.Font = Tipografia.fonts.fontawesome12;
            lblIconUser.Font = lblIconLock.Font = lblIconFolder.Font = lblIconGroup.Font = lblIconSend.Font = Tipografia.fonts.fontawesome14;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.google.com");
            Process.Start(sInfo);
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ingresar();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ingresar();
            }
        }
    }
}

