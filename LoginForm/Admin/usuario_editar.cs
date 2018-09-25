using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginForm.Admin;
using LoginForm.Database;
using System.Runtime.InteropServices;
using System.Net.Mail;

namespace LoginForm.Admin
{
    public partial class usuario_editar : Form
    {
        bool validacionClave = true;
        bool validacionCorreo = true;
        public int tipo { get; set; }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public usuario_editar()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txt_Nombres, "Nombres del usuario");
            this.ttMensaje.SetToolTip(this.txt_Apellidos, "Apellidos del usuario");
            this.ttMensaje.SetToolTip(this.cbx_Tipo, "Tipo de usuario");
            this.ttMensaje.SetToolTip(this.cbx_Estado, "Estado del usuario");
            this.ttMensaje.SetToolTip(this.txt_Usuario, "Usuario");
            this.ttMensaje.SetToolTip(this.txt_Email, "Correo electrónico del usuario");
            this.ttMensaje.SetToolTip(this.txt_Password, "Contraseña del usuario");
            this.ttMensaje.SetToolTip(this.txt_Codigo, "Código del usuario");
        }
        public void Editar()
        {

            try
            {
                constructor update = new constructor();
                update.idUsuario = Convert.ToInt32(txt_Id.Text);
                update.nombresUsuario = txt_Nombres.Text;
                update.apellidosUsuario = txt_Apellidos.Text;
                update.usernameUsuario = txt_Usuario.Text;
                update.emailUsuario = txt_Email.Text;
                if (string.IsNullOrEmpty(txt_Password.Text.Trim()))
                {
                    update.claveUsuario = Database.usuarioActual.claveUsuario;
                }
                else
                {
                    update.claveUsuario = hashing.HashPassword(txt_Password.Text);
                }
                update.codigoUsuario = Convert.ToInt32(txt_Codigo.Text);
                update.id_usuarioestadoUsuario = Convert.ToInt32(cbx_Estado.SelectedValue);
                update.id_usuariotipoUsuario = Convert.ToInt32(cbx_Tipo.SelectedValue);
                int datos = funcionesCRUD.update(update);
                if (datos > 0)
                {
                    MessageBox.Show("El usuario se actualizo correctamente.", "Usuario actualizado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El usuario no se actualizo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception eActu)
            {
                MessageBox.Show("El usuario no se actualizo: " + eActu.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void Agregar()
        {
            if (string.IsNullOrEmpty(txt_Nombres.Text.Trim()) ||
                string.IsNullOrEmpty(txt_Apellidos.Text.Trim()) ||
                string.IsNullOrEmpty(txt_Usuario.Text.Trim()) ||
                string.IsNullOrEmpty(txt_Email.Text.Trim()) ||
                string.IsNullOrEmpty(txt_Password.Text.Trim()) ||
                string.IsNullOrEmpty(txt_Codigo.Text.Trim()) ||
                string.IsNullOrEmpty(cbx_Estado.Text) ||
                string.IsNullOrEmpty(cbx_Tipo.Text))
            {
                MessageBox.Show("Uno o varios campos requeridos estan vacios.", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    constructor add = new constructor();
                    add.nombresUsuario = txt_Nombres.Text;
                    add.apellidosUsuario = txt_Apellidos.Text;
                    add.usernameUsuario = txt_Usuario.Text;
                    add.emailUsuario = txt_Email.Text;
                    if(txt_Password.Text == "pluzedu")
                    {
                        add.claveUsuario = txt_Password.Text;
                    }
                    else
                    {
                    add.claveUsuario = hashing.HashPassword(txt_Password.Text);
                    }
                    add.codigoUsuario = Convert.ToInt32(txt_Codigo.Text);
                    add.id_usuariotipoUsuario = Convert.ToInt32(cbx_Tipo.SelectedValue);
                    add.id_usuarioestadoUsuario = Convert.ToInt32(cbx_Estado.SelectedValue);
                    int datos = funcionesCRUD.agregarUsuarios(add);
                    if (datos > 0)
                    {
                        MessageBox.Show("El usuario fue agregado correctamente.", "Usuario agregado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El usuario no se agrego.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Close();
                }
                catch (Exception eAgregar)
                {
                    MessageBox.Show("El usuario no se agrego: " + eAgregar.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Password.Text))
            {
                validacionClave = true;
                lblValidacionClave.Text = "";
            }
            if (string.IsNullOrEmpty(txt_Email.Text))
            {
                validacionCorreo = true;
                lblEmailValidacion.Text = "";
            }
            if (txt_Password.Text == "pluzedu")
            {
                validacionClave = true;
                lblValidacionClave.Text = "";
            }
            if (validacionClave && validacionCorreo)
            {
                if (txt_Id.Text == "")
                {
                    Agregar();
                }
                else
                {
                    if (string.IsNullOrEmpty(txt_Nombres.Text.Trim()) ||
                        string.IsNullOrEmpty(txt_Apellidos.Text.Trim()) ||
                        string.IsNullOrEmpty(txt_Usuario.Text.Trim()) ||
                        string.IsNullOrEmpty(txt_Email.Text.Trim()) ||
                        string.IsNullOrEmpty(txt_Codigo.Text.Trim()) ||
                        string.IsNullOrEmpty(cbx_Estado.Text) ||
                        string.IsNullOrEmpty(cbx_Tipo.Text))
                    {
                        MessageBox.Show("Uno o varios campos requeridos estan vacios.", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Editar();
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Uno o varios campos no tienen el formato adecuado.", "Formato inadecuado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void barra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void editar_usuario_Load_1(object sender, EventArgs e)
        {
            lblMostrarClave.Font = Tipografia.fonts.fontawesome12;
        }

        private void txt_Nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch { }
        }
        private void txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch { }
        }
        private void linkClavePredeterminada_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_Password.Text = "pluzedu";
        }

        private void lblMostrarClave_MouseEnter(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = false;
        }

        private void lblMostrarClave_MouseLeave(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = true;
        }

        private void txt_Nombres_TextChanged(object sender, EventArgs e)
        {
            if (txt_Id.Text == "")
            {
                string usuario = txt_Nombres.Text + txt_Apellidos.Text;
                txt_Usuario.Text = usuario.Replace(" ", "").ToLower();
            }
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Email.Text.Trim()))
            {
                string errorMessage;
                if (Database.validaciones.emailEsValido(txt_Email.Text, out errorMessage))
                {
                    validacionCorreo = true;
                    lblEmailValidacion.Text = "";
                }
                else
                {
                    validacionCorreo = false;
                    lblEmailValidacion.Text = errorMessage;
                }
            }
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            string ErrorMessage = "";
            string claveNueva = txt_Password.Text;
            if (!string.IsNullOrEmpty(txt_Password.Text.Trim()))
            {
                if (!Database.validaciones.claveEsValida(claveNueva, out ErrorMessage))
                {
                    validacionClave = false;
                    lblValidacionClave.Text = ErrorMessage;
                }
                else
                {
                    lblValidacionClave.Text = "";
                    validacionClave = true;
                }
            }
        }
    }
}
