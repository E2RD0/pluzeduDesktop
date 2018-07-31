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
    public partial class niveles_editar : Form
    {
        public int id { get; set; }
        public string nombre { get; set; }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public void actualizarNivel()
        {
            Database.constructor nivel = new Database.constructor();
            nivel.nombreNivel = txtNombreNivel.Text;
            try
            {
                int retorno = Database.funcionesCRUD.actualizarNivel(nivel, id);
                if (retorno < 1)
                {
                    MessageBox.Show("El nivel no pudo ser actualizado");
                }
            }
            catch(Exception eActualizar)
            {
                if (MessageBox.Show("Error al actualizar nivel: " + eActualizar.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    actualizarNivel();
                };
            }
        }
        public niveles_editar()
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
            txtNombreNivel.Text = nombre;
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            actualizarNivel();
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void barra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
