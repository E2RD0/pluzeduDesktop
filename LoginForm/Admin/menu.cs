﻿using System;
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
            try
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
            catch (Exception e1)
            {
                MessageBox.Show("Error: " + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public menu()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.btnInicio,"Inicio");
            this.ttMensaje.SetToolTip(this.btnNivel,"Niveles");
            this.ttMensaje.SetToolTip(this.btnConfigurarUsuarios,"Configurar usuarios");
            this.ttMensaje.SetToolTip(this.btnConfiguracion,"Configuración");
            this.ttMensaje.SetToolTip(this.btnSignout,"Cerrar sesión");
        }
        public void cargarImagenPerfil()
        {
            try
            {
                var result = Database.archivos.recibirImg(Database.DBfunciones.urlImagenPerfil(Database.usuarioActual.idUsuario));
                result.ContinueWith(task =>
                {
                    cpbxFoto.Image = task.Result;
                });
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error: " + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barra_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error: " + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            try
            {
                this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
                this.btnNivel.BackColor = System.Drawing.Color.Transparent;
                this.btnConfigurarUsuarios.BackColor = System.Drawing.Color.Transparent;
                this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
                abrirFormEnPanel(new Admin.principal());
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error: " + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNivel_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnInicio.BackColor = System.Drawing.Color.Transparent;
                this.btnNivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
                this.btnConfigurarUsuarios.BackColor = System.Drawing.Color.Transparent;
                this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
                abrirFormEnPanel(new Admin.niveles());
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error: " + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfigurarUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnInicio.BackColor = System.Drawing.Color.Transparent;
                this.btnNivel.BackColor = System.Drawing.Color.Transparent;
                this.btnConfigurarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
                this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
                Admin.usuarios usuarios = new Admin.usuarios();
                usuarios.tipo = 0;
                abrirFormEnPanel(usuarios);
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error: " + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menu_Load(object sender, EventArgs e)
        {
            try
            {
                cargarImagenPerfil();
                this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
                this.btnNivel.BackColor = System.Drawing.Color.Transparent;
                this.btnConfigurarUsuarios.BackColor = System.Drawing.Color.Transparent;
                this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
                abrirFormEnPanel(new Admin.principal());

                btnInicio.Font = btnConfiguracion.Font = btnConfigurarUsuarios.Font = btnNivel.Font = btnSignout.Font = Tipografia.fonts.fontawesome20;
                btnMin.Font = btnClose.Font = Tipografia.fonts.fontawesome12;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error: " + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                th = new Thread(opennewform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error: " + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void opennewform(object obj)
        {
            Application.Run(new Form1());
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnInicio.BackColor = System.Drawing.Color.Transparent;
                this.btnNivel.BackColor = System.Drawing.Color.Transparent;
                this.btnConfigurarUsuarios.BackColor = System.Drawing.Color.Transparent;
                this.btnConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
                abrirFormEnPanel(new Admin.configuracion());
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error: " + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
