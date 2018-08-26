using System;
using System.Windows.Forms;
using LoginForm.Database;
using System.Drawing;

namespace LoginForm.Admin
{
    public partial class configuracion : Form
    {
        public static int idUserActual { get; set; }
        string hash;
        public void Datos()
        {
            txtUsuario.Text = Convert.ToString(funcionesCRUD.infoUsuarios(idUserActual).Rows[0].ItemArray[0]);
            txtEmail.Text = Convert.ToString(funcionesCRUD.infoUsuarios(idUserActual).Rows[0].ItemArray[1]);
            hash = Convert.ToString(funcionesCRUD.infoUsuarios(idUserActual).Rows[0].ItemArray[2]);
        }
        public void Reload()
        {
            configuracion config = new configuracion();
            config.StartPosition = FormStartPosition.CenterParent;
            this.Close();
            (Application.OpenForms["inicio"] as Inicio).abrirFormEnPanel(config);
        }
        public configuracion()
        {
            InitializeComponent();
        }
        private void configuracion_Load(object sender, EventArgs e)
        {
            Datos();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtEmail.ForeColor = Color.Black;
            txtEmail.BackColor = Color.White;
            txtEmail.ReadOnly = false;
        }
        private void btnEditar2_Click(object sender, EventArgs e)
        {
            txtConstraseña.Text = "";
            txtConstraseña.ReadOnly = false;
            lblContr.Text = "Contraseña Actual";
            lblNueva.Visible = true;
            lblRepe.Visible = true;
            txtContraNueva.Visible = true;
            txtContraRepetir.Visible = true;
            txtConstraseña.ForeColor = Color.Black;
            txtConstraseña.BackColor = Color.White;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string email = null;
                string contra = null;
                if (txtEmail.ReadOnly == false && txtConstraseña.ReadOnly == true)
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
                else if (txtEmail.ReadOnly == true && txtConstraseña.ReadOnly == false)
                {
                    if (string.IsNullOrEmpty(txtConstraseña.Text.Trim()) || string.IsNullOrEmpty(txtContraNueva.Text.Trim()) || string.IsNullOrEmpty(txtContraRepetir.Text.Trim()))
                    {
                        MessageBox.Show("Uno de los campos requeridos esta vacio, por favor verifique los campos ingresados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        bool si = hashing.ValidatePassword(txtConstraseña.Text, hash);
                        if (si == true)
                        {
                            if (txtContraNueva.Text == txtContraRepetir.Text)
                            {
                                contra = hashing.HashPassword(txtContraNueva.Text);
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
                else if (txtEmail.ReadOnly == false && txtConstraseña.ReadOnly == false)
                {
                    if (string.IsNullOrWhiteSpace(txtConstraseña.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
                    {
                        MessageBox.Show("Uno de los campos requeridos esta vacio, por favor verifique los campos ingresados.", "Advertencía", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (hashing.ValidatePassword(txtConstraseña.Text, hash))
                    {
                        if (txtContraNueva.Text != txtContraRepetir.Text && string.IsNullOrEmpty(txtEmail.Text.Trim()))
                        {
                            MessageBox.Show("Uno de los campos requeridos esta erroneo, por favor verifique los campos ingresados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            contra = hashing.HashPassword(txtContraNueva.Text);
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
            Reload();
        }
    }
}