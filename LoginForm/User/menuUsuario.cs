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

namespace LoginForm.User
{
    public partial class menuUsuario : Form
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
        public void cargarImagenPerfil()
        {
            var result = Database.archivos.recibirImg(Database.DBfunciones.urlImagenPerfil(Database.usuarioActual.idUsuario));
            result.ContinueWith(task =>
            {
                cpbxFoto.Image = task.Result;
            });
        }
        public menuUsuario()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.btnInicio, "Inicio");
            this.ttMensaje.SetToolTip(this.btnDirectorio, "Directorio");
            this.ttMensaje.SetToolTip(this.btnConfiguracion, "Configuración");
            this.ttMensaje.SetToolTip(this.btnSignout,"Cerrar sesión");
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
            this.btnDirectorio.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            abrirFormEnPanel(new User.mensajes());
        }
        private void btnNivel_Click(object sender, EventArgs e)
        {
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnDirectorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
            this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            abrirFormEnPanel(new User.directorio());
        }

        private void menu_Load(object sender, EventArgs e)
        {
            cargarImagenPerfil();
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
            this.btnDirectorio.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            abrirFormEnPanel(new User.mensajes());

            btnInicio.Font = btnConfiguracion.Font = btnDirectorio.Font = btnSignout.Font = Tipografia.fonts.fontawesome20;
            btnMin.Font = btnClose.Font = Tipografia.fonts.fontawesome12;
        }
        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnDirectorio.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
            abrirFormEnPanel(new User.configuracion());
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
    }
}
