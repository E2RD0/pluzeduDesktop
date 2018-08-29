using System;
using System.Windows.Forms;
using LoginForm.Database;
using System.Drawing;
using System.Net.Mail;

namespace LoginForm.Admin
{
    public partial class configuracion : Form
    {
        int idUsuario = Database.usuarioActual.idUsuario;
        string usernameUsuario;
        string emailUsuario;
        string hashUsuario;
        bool validacionCorreo = false;
        bool validacionUsuario = false;
        bool validacionClave = false;
        string hashNuevo;

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
        }
        public configuracion()
        {
            InitializeComponent();
        }
        private void configuracion_Load(object sender, EventArgs e)
        {
            Datos();
            txtUsuario.Text = usernameUsuario;
            txtEmail.Text = emailUsuario;
        }
        private bool emailEsValido(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
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

            if(emailUsuario == emailNuevo)
            {
                validacionCorreo = true;
            }
            if(usernameUsuario == usernameNuevo)
            {
                validacionUsuario = true;
            }
            if (validacionUsuario == true && validacionCorreo == true && validacionClave == true)
            {
                if(emailUsuario != emailNuevo) { }
                if (usernameUsuario != usernameNuevo) { }
            }
            else
            {
                MessageBox.Show("Alguno de los campos no tiene el formato adecuado.");
            }
            
            //Reload();
        }

        /*private void btnGuardar_Click(object sender, EventArgs e)
        {
            


           /* string hashNuevo;
            string usuarioNuevo;
            try
            {
                string email = null;
                string contra = null;
                if (txtEmail.ReadOnly == false && txtClaveNueva.ReadOnly == true)
                {
                    if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
                    {
                        MessageBox.Show("Uno de los campos requeridos esta vacio, por favor verifique los campos ingresados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (txtEmail.Text.EndsWith("@gmail.com") || txtEmail.Text.EndsWith("@yahoo.com") || txtEmail.Text.EndsWith("@hotmail.com") || txtEmail.Text.EndsWith("@outlook.com"))
                        {
                            email = txtEmail.Text;
                            constructor acorreo = new constructor();
                            acorreo.idUsuario = idUserActual;
                            acorreo.emailUsuario = email;
                            int cor = funcionesCRUD.updateemail(acorreo);
                            if (cor > 0)
                            {
                                MessageBox.Show("El correo se actualizo correctamente.", "Usuario actualizado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("El correo no se actualizo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("La direccion de correo no es valida, por favor ingrese una correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (txtEmail.ReadOnly == true && txtClaveNueva.ReadOnly == false)
                {
                    if (string.IsNullOrEmpty(txtClaveNueva.Text.Trim()) || string.IsNullOrEmpty(txtClaveRepetir.Text.Trim()) || string.IsNullOrEmpty(txtContraRepetir.Text.Trim()))
                    {
                        MessageBox.Show("Uno de los campos requeridos esta vacio, por favor verifique los campos ingresados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        bool si = hashing.ValidatePassword(txtClaveNueva.Text, hash);
                        if (si == true)
                        {
                            if (txtClaveRepetir.Text == txtContraRepetir.Text)
                            {
                                contra = hashing.HashPassword(txtClaveRepetir.Text);
                                constructor acontra = new constructor();
                                acontra.idUsuario = idUserActual;
                                acontra.claveUsuario = contra;
                                int contr = funcionesCRUD.updatecontra(acontra);
                                if (contr > 0)
                                {
                                    MessageBox.Show("La contraseña se actualizo correctamente.", "Usuario actualizado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("La contraseña no se actualizo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Las contraseñas ingresadas no son iguales, por favor verifiquelas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("La contraseña ingresada es errónea, por favor verifíque la contraseña.", "Advertencía", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (txtEmail.ReadOnly == false && txtClaveNueva.ReadOnly == false)
                {
                    if (string.IsNullOrWhiteSpace(txtClaveNueva.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
                    {
                        MessageBox.Show("Uno de los campos requeridos esta vacio, por favor verifique los campos ingresados.", "Advertencía", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (hashing.ValidatePassword(txtClaveNueva.Text, hash))
                    {
                        if (txtClaveRepetir.Text != txtContraRepetir.Text && string.IsNullOrEmpty(txtEmail.Text.Trim()))
                        {
                            MessageBox.Show("Uno de los campos requeridos esta erroneo, por favor verifique los campos ingresados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            contra = hashing.HashPassword(txtClaveRepetir.Text);
                            if (txtEmail.Text.EndsWith("@gmail.com") || txtEmail.Text.EndsWith("@yahoo.com") || txtEmail.Text.EndsWith("@hotmail.com") || txtEmail.Text.EndsWith("@outlook.com"))
                            {
                                email = txtEmail.Text;
                                constructor send = new constructor();
                                send.idUsuario = idUserActual;
                                send.emailUsuario = email;
                                send.claveUsuario = contra;
                                int actualizar = funcionesCRUD.updateconfig(send);
                                if (actualizar > 0)
                                {
                                    MessageBox.Show("El usuario se actualizo correctamente.", "Usuario actualizado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("El usuario no se actualizo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("La direccion de correo no es valida, por favor ingrese una correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception eActu)
            {
                MessageBox.Show("El usuario no se actualizo: " + eActu.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }*/

        private void btnEditarEmail_Click(object sender, EventArgs e)
        {
            txtEmail.ForeColor = Color.Black;
            txtEmail.BackColor = Color.White;
            txtEmail.ReadOnly = false;
            txtEmail.Focus();
        }
        private void btnEditarClave_Click(object sender, EventArgs e)
        {
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

        }

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                if (emailEsValido(txtEmail.Text))
                {
                    validacionCorreo = true;
                    lblEmailValidacion.Text = "";
                }
                else
                {
                    validacionCorreo = false;
                    lblEmailValidacion.Text = "El correo electronico no es valido.";
                }
            }
            else
            {
                lblEmailValidacion.Text = "El correo electronico no puede estar vacio";
                validacionCorreo = false;
            }
        }

        private void txtClaveRepetir_KeyUp(object sender, KeyEventArgs e)
        {
            string claveNueva = txtClaveNueva.Text;
            string claveRepetir = txtClaveRepetir.Text;
            if (!string.IsNullOrEmpty(claveNueva.Trim()) && !string.IsNullOrEmpty(claveRepetir.Trim()))
            {
                if (claveNueva == claveRepetir)
                {
                    lblValidacionClave.Text = "";
                    validacionClave = true;
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

        private void txtClaveNueva_KeyUp(object sender, KeyEventArgs e)
        {
            string claveNueva = txtClaveNueva.Text;
            string claveRepetir = txtClaveRepetir.Text;
            if (!string.IsNullOrEmpty(claveNueva.Trim()) && !string.IsNullOrEmpty(claveRepetir.Trim()))
            {
                if (claveNueva == claveRepetir)
                {
                    lblValidacionClave.Text = "";
                    validacionClave = true;
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
}