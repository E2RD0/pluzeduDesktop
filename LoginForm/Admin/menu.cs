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
using LoginForm.Tipografia;

namespace LoginForm.Admin
{
    public partial class menu : Form
    {
        Thread th;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public void abrirFormEnPanel(Form fh)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        public menu()
        {
            InitializeComponent();
        }

        private void barra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
            this.btnNivel.BackColor = System.Drawing.Color.Transparent;
            this.btnConfigurarUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            abrirFormEnPanel(new Admin.principal());
        }
        private void btnNivel_Click(object sender, EventArgs e)
        {
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnNivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
            this.btnConfigurarUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            abrirFormEnPanel(new Admin.niveles());
        }

        private void btnConfigurarUsuarios_Click(object sender, EventArgs e)
        {
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnNivel.BackColor = System.Drawing.Color.Transparent;
            this.btnConfigurarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
            this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            Admin.usuarios usuarios = new Admin.usuarios();
            usuarios.tipo = 1;
            abrirFormEnPanel(usuarios);
        }

        private void menu_Load(object sender, EventArgs e)
        {
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
            this.btnNivel.BackColor = System.Drawing.Color.Transparent;
            this.btnConfigurarUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            abrirFormEnPanel(new Admin.principal());

            btnInicio.Font = btnConfiguracion.Font = btnConfigurarUsuarios.Font = btnNivel.Font = btnSignout.Font = Tipografia.fonts.fontawesome20;
            btnMin.Font = btnClose.Font = Tipografia.fonts.fontawesome12;
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform(object obj)
        {
            Application.Run(new Form1());
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnNivel.BackColor = System.Drawing.Color.Transparent;
            this.btnConfigurarUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
            abrirFormEnPanel(new Admin.configuracion());
        }
    }
}
