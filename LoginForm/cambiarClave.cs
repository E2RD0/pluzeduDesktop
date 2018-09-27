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

namespace LoginForm
{
    public partial class cambiarClave : Form
    {
        bool validacionClave = true;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public void auth()
        {
        }
        public cambiarClave()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void niveles_editar_Load(object sender, EventArgs e)
        {
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClave.Text.Trim()))
            {
                MessageBox.Show("Debes de ingresar una contraseña nueva.");
            }
            else
            {
                if (validacionClave)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La contraseña no tiene el formato adecuado.");
                }
            }
        }
        private void barra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            string ErrorMessage = "";
            string claveNueva = txtClave.Text;

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