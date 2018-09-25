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

namespace LoginForm.Admin
{
    public partial class niveles_nuevo : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public void agregarNivel()
        {
            Database.constructor nivel = new Database.constructor();
            nivel.nombreNivel = txtNombreNivel.Text;
            try
            {
                int retorno = Database.funcionesCRUD.agregarNivel(nivel);
                if (retorno < 1)
                {
                    MessageBox.Show("El nivel no pudo ser agregado");
                }
            }
            catch(Exception eAgregar)
            {
                MessageBox.Show("Error al ingresar nivel: " + eAgregar.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public niveles_nuevo()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombreNivel, "Escriba un nombre");
            this.ttMensaje.SetToolTip(this.btnAgregar, "Agregar nuevo nivel");
            this.ttMensaje.SetToolTip(this.btnCancelar, "Cancelar");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarNivel();
            this.Close();
        }

        private void barra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void niveles_nuevo_Load(object sender, EventArgs e)
        {
            btnMin.Font = btnClose.Font = Tipografia.fonts.fontawesome12;
        }
    }
}
