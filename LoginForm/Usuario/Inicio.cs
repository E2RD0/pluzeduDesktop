using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using LoginForm.Database;
using LoginForm.Admin;

namespace LoginForm
{
    public partial class Inicio : Form
    {
        Thread th;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public Inicio()
        {
            InitializeComponent();
        }
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
        private void Inicio_Load(object sender, EventArgs e)
        {
            this.btnMensajes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
            this.btnDirectorio.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            abrirFormEnPanel(new Mensajes());

            btnConfiguracion.Font = btnDirectorio.Font = btnMensajes.Font = btnSignout.Font = Tipografia.fonts.fontawesome20;
        }
        private void barra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
        private void btnMensajes_Click(object sender, EventArgs e)
        {
            this.btnMensajes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
            this.btnDirectorio.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            abrirFormEnPanel(new Mensajes());
        }
        private void btnDirectorio_Click(object sender, EventArgs e)
        {
            //this.btnMensajes.BackColor = System.Drawing.Color.Transparent;
            //this.btnDirectorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
            //this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            //abrirFormEnPanel(new Directorio());
        }
        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            this.btnMensajes.BackColor = System.Drawing.Color.Transparent;
            this.btnDirectorio.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
            abrirFormEnPanel(new configuracion());
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
