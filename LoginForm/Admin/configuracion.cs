using System;
using System.Windows.Forms;
using LoginForm.Database;
using System.Drawing;
using System.Net.Mail;
using System.IO;
using System.Text.RegularExpressions;

namespace LoginForm.Admin
{
    public partial class configuracion : Form
    {
        int idUsuario = Database.usuarioActual.idUsuario;
        string usernameUsuario;
        string emailUsuario;
        string hashUsuario;
        string nombreCompletoUsuario;
        bool validacionCorreo = true;
        bool validacionUsuario = true;
        bool validacionClave = true;
        string claveDefinitiva = "";
        public void Reload()
        {
            configuracion configuracion = new configuracion();
            configuracion.StartPosition = FormStartPosition.CenterParent;
            this.Close();
            (Application.OpenForms["menu"] as menu).abrirFormEnPanel(configuracion);
        }
        private void Datos()
        {
            Database.funcionesCRUD.datosUsuarioActual(idUsuario);
            usernameUsuario = Database.usuarioActual.usernameUsuario;
            emailUsuario = Database.usuarioActual.emailUsuario;
            hashUsuario = Database.usuarioActual.claveUsuario;
            nombreCompletoUsuario = Database.usuarioActual.nombresUsuario + " " + Database.usuarioActual.apellidosUsuario;
        }
        public configuracion()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.btnEditarFoto, "Cambiar foto de perfil");
            this.ttMensaje.SetToolTip(this.txtUsuario, "Usuario");
            this.ttMensaje.SetToolTip(this.txtEmail, "Correo electrónico");
            this.ttMensaje.SetToolTip(this.txtClaveNueva, "Nueva contraseña");
            this.ttMensaje.SetToolTip(this.txtClaveRepetir, "Repetir contraseña");
            this.ttMensaje.SetToolTip(this.btnEditarUsuario, "Editar usuario");
            this.ttMensaje.SetToolTip(this.btnEditarEmail, "Editar correo electrónico");
            this.ttMensaje.SetToolTip(this.btnEditarClave, "Editar contraseña");
            this.ttMensaje.SetToolTip(this.btnGuardar, "Guardar");
        }
        private void cargarImagenPerfil()
        {
            var result = archivos.recibirImg(DBfunciones.urlImagenPerfil(Database.usuarioActual.idUsuario));
            result.ContinueWith(task =>
            {
                pbxPerfil.Image = task.Result;
            });
            btnEditarFoto.Visible = true;
        }
        private void configuracion_Load(object sender, EventArgs e)
        {
            Datos();
            lblNombreCompleto.Text = Database.usuarioActual.nombresUsuario + " " +  Database.usuarioActual.apellidosUsuario;
            lblNombreCompleto.Location = new Point((this.Width - lblNombreCompleto.Width) / 2, 132);
            txtUsuario.Text = usernameUsuario;
            txtEmail.Text = emailUsuario;
            cargarImagenPerfil();
        }

        private void actualizarClave()
        {
        }

        /*private bool actualizarCorreo(string correo)
        {
            if (string.IsNullOrEmpty(correo.Trim()))
            {
                return "vacio";
            }
            else
            {
                if (emailEsValido(correo))
                {
                    if (funcionesCRUD.actualizarCorreo(idUsuario, correo) > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("La direccion de correo no es valida, por favor ingrese una correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }*/
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Datos();
            string emailNuevo = txtEmail.Text;
            string usernameNuevo = txtUsuario.Text;

            if (emailUsuario == emailNuevo)
            {
                validacionCorreo = true;
            }
            if (usernameUsuario == usernameNuevo)
            {
                validacionUsuario = true;
            }
            if (!string.IsNullOrEmpty(usernameNuevo.Trim()))
            {
                validacionUsuario = true;
            }
            if (validacionUsuario == true && validacionCorreo == true && validacionClave == true)
            {
                if (emailUsuario == emailNuevo && usernameUsuario == usernameNuevo && (hashing.ValidatePassword(claveDefinitiva, hashUsuario) || claveDefinitiva == ""))
                {
                    MessageBox.Show("Debes de cambiar algun dato.");
                }
                else
                {
                    configuracion_autenticacion autenticacion = new Admin.configuracion_autenticacion();
                    autenticacion.StartPosition = FormStartPosition.CenterScreen;
                    if (autenticacion.ShowDialog(this) == DialogResult.OK)
                    {
                        if (hashing.ValidatePassword(autenticacion.txtClave.Text, hashUsuario))
                        {
                            if (emailUsuario != emailNuevo)
                            {
                                funcionesCRUD.actualizarCorreo(idUsuario, emailNuevo);
                            }
                            if (usernameUsuario != usernameNuevo)
                            {
                                funcionesCRUD.actualizarUsername(idUsuario, usernameNuevo);
                            }
                            if (!string.IsNullOrEmpty(claveDefinitiva.Trim()))
                            {
                                funcionesCRUD.actualizarClave(idUsuario, hashing.HashPassword(claveDefinitiva));
                            }
                            MessageBox.Show("Datos actualizados correctamente.");
                            Reload();
                        }
                        else
                        {
                            MessageBox.Show("Clave Incorrecta.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Alguno de los campos no tiene el formato adecuado.");
            }
        }

        private void btnEditarEmail_Click(object sender, EventArgs e)
        {
            validacionCorreo = false;
            txtEmail.ForeColor = Color.Black;
            txtEmail.BackColor = Color.White;
            txtEmail.ReadOnly = false;
            txtEmail.Focus();
        }
        private void btnEditarClave_Click(object sender, EventArgs e)
        {
            validacionClave = false;
            txtClaveNueva.Text = "";
            txtClaveNueva.ReadOnly = false;
            txtClaveNueva.UseSystemPasswordChar = true;
            lblClave.Text = "Contraseña Nueva:";
            lblRepetirClave.Visible = true;
            txtClaveRepetir.Visible = true;
            txtClaveNueva.ForeColor = Color.Black;
            txtClaveNueva.BackColor = Color.White;
            txtClaveNueva.Focus();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (Database.usuarioActual.id_usuariotipoUsuario == 1)
            {
                txtUsuario.ForeColor = Color.Black;
                txtUsuario.BackColor = Color.White;
                txtUsuario.ReadOnly = false;
                txtUsuario.Focus();
                validacionUsuario = false;
            }
            else
            {
                MessageBox.Show("Debes ser un administrador para poder cambiar tu usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Imagenes|*.png;*.jpg;*.jpeg;*.gif;";
                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileLocation = open.FileName;
                    long fileSize = new FileInfo(open.FileName).Length;
                    if (fileSize > 5000000)
                    {
                        MessageBox.Show("La imagen es muy pesada, intentalo de nuevo.");
                    }
                    else
                    {
                        Stream imgStream = ImageResize.Crop(Image.FromFile(@fileLocation), 300, 300, ImageResize.AnchorPosition.Center);
                        archivos.subirImagen(imgStream, Database.usuarioActual.idUsuario);
                        cargarImagenPerfil();
                        (Application.OpenForms["menu"] as menu).cargarImagenPerfil();
                    }


                }
            }
            catch (Exception error)
            {
                MessageBox.Show(Convert.ToString(error.Message));
            }
        }

        private void txtClaveNueva_TextChanged(object sender, EventArgs e)
        {
            string ErrorMessage = "";
            string claveNueva = txtClaveNueva.Text;
            string claveRepetir = txtClaveRepetir.Text;
            if (!string.IsNullOrEmpty(claveNueva.Trim()))
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
                    if (!string.IsNullOrEmpty(claveRepetir.Trim()))
                    {
                        if (claveNueva == claveRepetir)
                        {
                            lblValidacionClave.Text = "";
                            validacionClave = true;
                            claveDefinitiva = claveRepetir;
                        }
                        else
                        {
                            lblValidacionClave.Text = "Las contraseñas no coinciden.";
                            validacionClave = false;
                        }
                    }
                    else
                    {
                        lblValidacionClave.Text = "Debes de completar ambos campos.";
                        validacionClave = false;
                    }
                }
            }
            else
            {
                lblValidacionClave.Text = "La contraseña no puede ser vacía.";
                validacionClave = false;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string errorMessage = "";
            if (!string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                if (Database.validaciones.emailEsValido(txtEmail.Text, out errorMessage))
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
            else
            {
                lblEmailValidacion.Text = "El correo electronico no puede estar vacio";
                validacionCorreo = false;
            }
        }
    }
}