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
using System.Net.Mail;
using LoginForm.Database;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        //VARIABLES
        Thread th;
        string pin;
        string correo;
        string pinuser;
        string clave;
        //ARRASTRAR MENÚ
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void barra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //ABRIR FORM
        public Form1()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtUser, "Escriba su usuario");
            this.ttMensaje.SetToolTip(this.txtCorreo, "Escriba su correo electrónico");
            this.ttMensaje.SetToolTip(this.txtContrarep, "Repita su contraseña");
            this.ttMensaje.SetToolTip(this.txtPassword, "Escriba su contraseña");
            this.ttMensaje.SetToolTip(this.linkLabel1, "¿Has olvidado tu contraseña?");
            this.ttMensaje.SetToolTip(this.button1, "Ir al sitio web de Pluzedu");
            this.ttMensaje.SetToolTip(this.btnIngresar, "Iniciar sesión");
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            txtUser.Text = "Usuario" + Convert.ToChar(0x00002063).ToString();
            txtPassword.Text = "Contraseña" + Convert.ToChar(0x00002063).ToString();
            btnMin.Font = btnClose.Font = Tipografia.fonts.fontawesome12;
            lblIconUser.Font = lblIconLock.Font = lblIconFolder.Font = lblIconGroup.Font = lblIconSend.Font = Tipografia.fonts.fontawesome14;
        }
        //CAMPOS DE TEXTOS DINÁMICOS
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
        //ABRIR FORMS
        private void abrirAdmin(object obj)
        {
            Application.Run(new Admin.menu());
        }
        private void abrirUsuario(object obj)
        {

           Application.Run(new User.menuUsuario());
        }
        //INICIO DE SESIÓN
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
                            MessageBox.Show("Tu contraseña es la predeterminada, por motivos de seguridad debes de cambiarla.");
                            cambiarClave cambiarClave = new cambiarClave();
                            cambiarClave.StartPosition = FormStartPosition.CenterScreen;
                            if (cambiarClave.ShowDialog(this) == DialogResult.OK)
                            {
                                funcionesCRUD.actualizarClave(idUsuario, hashing.HashPassword(cambiarClave.txtClave.Text));
                            }
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
                        Database.funcionesCRUD.datosUsuarioActual(idUsuario);
                        if (Database.usuarioActual.id_usuarioestadoUsuario == 1)
                        {
                            if (Database.usuarioActual.id_usuariotipoUsuario == 1)
                            {
                                this.Close();
                                th = new Thread(abrirAdmin);
                                th.SetApartmentState(ApartmentState.STA);
                                th.Start();
                            }
                            else if (Database.usuarioActual.id_usuariotipoUsuario == 2 || Database.usuarioActual.id_usuariotipoUsuario == 3)
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
                        MessageBox.Show("Usuario o contraseña incorrectos, intenta de nuevo", "Datos erróneos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos, intenta de nuevo", "Datos erróneos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        //ABRIR PÁGINA WEB
        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.pluzedu.com");
            Process.Start(sInfo);
        }
        //MINIMIZAR Y CERRAR FORM
        private void btnMin_Click(object sender, EventArgs e) //MINIMIZAR
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnClose_Click(object sender, EventArgs e) //CERRAR
        {
            this.Close();
        }
        //RECUPERAR CONTRASEÑA
        private bool emailEsValido(string ver)
        {
            try
            {
                MailAddress m = new MailAddress(ver);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private void Pin()
        {
            int Inicio = 33;
            int Fin = 126;
            int Caracteres = 10;
            Random random = new Random(DateTime.Now.Millisecond);
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < Caracteres; i++)
            {
                builder.Append((char)(random.Next(Inicio, Fin + 1) % 255));
            }
            pin = builder.ToString();
        }
        public void SendMail(string email)
        {
            try
            {
                MailMessage mail = new MailMessage("pluzedu@gmail.com", email);
                mail.BodyEncoding = UTF8Encoding.UTF8;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                SmtpClient client = new SmtpClient();
                client.EnableSsl = true;
                client.Port = 25;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Timeout = 10000;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("pluzedu@gmail.com", "H23UY!Y9h9sk$");
                client.Host = "smtp.gmail.com";
                mail.Subject = "Recuperación de contraseña.";
                mail.Body = "Parece que has solicitado una recuperación de contraseña, tu codigo de recuperación es el siguiente: " + pin + "\nSi no has solicitado un codigo de recuperación de contraseña, puedes ignorar este mensaje.";
                client.Send(mail);
            }
            catch
            {
                MessageBox.Show("No se ha podido enviar el correo electrónico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //ABRIR RECUPERAR CONTRASEÑA
        {
            recovery.Visible = true;
        }
        private void btnCancelRecovery_Click(object sender, EventArgs e) //RESET RECUPERAR CONTRASEÑA
        {
            recovery.Visible = false;
            lblCorreo.Text = "Ingresa tu correo electrónico: ";
            lblIcon.Text = "";
            txtCorreo.Text = "";
            btnSendRec.Visible = true;
            lblEmailValidacion.Text = "";
            btnComprobar.Location = new Point(169, 323);
            btnComprobar.Visible = false;
            btnCancelRecovery.Location = new Point(67, 282);
        }
        private void btnSendRec_Click(object sender, EventArgs e) //INGRESAR CORREO
        {
            try {
                correo = txtCorreo.Text;
                if (!string.IsNullOrEmpty(correo.Trim()))
                {
                    if (emailEsValido(correo) && funcionesCRUD.verificarCorreo(correo).Rows.Count == 1)
                    {
                        if (funcionesCRUD.verificarReContra(pin).Rows.Count == 0)
                        {
                            Pin();
                            SendMail(correo);
                            funcionesCRUD.subirPin(pin, correo);

                            lblCorreo.Text = "Ingresa tu código de acceso: ";
                            lblIcon.Text = "";
                            lblEmailValidacion.Text = "";

                            txtCorreo.Text = "";
                            txtCorreo.Focus();

                            btnSendRec.Visible = false;

                            btnComprobar.Location = new Point(169, 282);
                            btnComprobar.Visible = true;

                            btnCancelRecovery.Location = new Point(41, 282);
                        }
                        else
                        {
                            MessageBox.Show("Se ha solicitado un cambio de contraseña hace poco. Por favor espera.", "Por favor espere", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        lblEmailValidacion.Text = "El correo electrónico no es valido.";
                    }
                }
                else
                {
                    lblEmailValidacion.Text = "El campo esta vacío.";
                }
            } catch
            {
                MessageBox.Show("Ha ocurrido un error al realizar el procedimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnComprobar_Click(object sender, EventArgs e) //COMPROBAR PIN
        {
            try
            {
                pinuser = txtCorreo.Text;
                if (!string.IsNullOrEmpty(pinuser.Trim()))
                {
                    if (funcionesCRUD.verificarPin(pinuser).Rows.Count == 1)
                    {
                        btnCancelRecovery.Visible = false;
                        btnComprobar.Visible = false;

                        lblEmailValidacion.Text = "";
                        txtCorreo.Text = "";
                        lblIcon.Text = "";
                        lblCorreo.Text = "Ingresa tu nueva contraseña: ";

                        lblRepite.Visible = true;
                        pnlContra.Visible = true;
                        txtContrarep.Visible = true;
                        lblIcon2.Visible = true;
                        lblContraseñaConfirmacion.Visible = true;

                        btnCambiar.Visible = true;
                    }
                    else
                    {
                        lblEmailValidacion.Text = "El código de acceso no es valido.";
                    }
                }
                else
                {
                    lblEmailValidacion.Text = "El campo esta vacío.";
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al realizar el procedimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCambiar_Click(object sender, EventArgs e) //COMPROBAR Y CAMBIAR CONTRASEÑA
        {
            try
            {
                clave = txtCorreo.Text;
                if (!string.IsNullOrEmpty(clave.Trim()))
                {
                    if (!string.IsNullOrEmpty(txtContrarep.Text.Trim()))
                    {
                        if (clave == txtContrarep.Text)
                        {
                            int ifa = funcionesCRUD.cambiarClave(correo, Database.hashing.HashPassword(clave));
                            if (ifa == 1)
                            {
                                MessageBox.Show("La contraseña se ha actualizado exitosamente.", "Contraseña actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                funcionesCRUD.eliminarPin(pinuser);
                            }
                            else
                            {
                                MessageBox.Show("Error al actualizar la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            pnlContra.Visible = false;
                            txtContrarep.Visible = false;
                            lblIcon2.Visible = false;
                            lblContraseñaConfirmacion.Visible = false;
                            lblRepite.Visible = false;

                            lblCorreo.Text = "Ingresa tu correo electrónico: ";
                            lblIcon.Text = "";
                            txtCorreo.Text = "";
                            btnSendRec.Visible = true;
                            lblEmailValidacion.Text = "";
                            btnComprobar.Location = new Point(169, 323);
                            btnComprobar.Visible = false;
                            btnCancelRecovery.Location = new Point(67, 282);
                            recovery.Visible = false;
                        }
                        else
                        {
                            lblEmailValidacion.Text = "Las contraseñas no coinciden.";
                        }
                    }
                    else
                    {
                        lblEmailValidacion.Text = "El campo esta vacío.";
                    }
                }
                else
                {
                    lblEmailValidacion.Text = "El campo esta vacío.";
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al realizar el procedimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}