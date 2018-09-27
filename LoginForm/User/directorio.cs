using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm.User
{
    public partial class directorio : Form
    {
        int Tipo = 3;
        public directorio()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.btnEstudiantes, "Estudiantes");
            this.ttMensaje.SetToolTip(this.btnMaestros, "Maestros");
        }

        private void mostrarContacts()
        {
            int idUser = Database.usuarioActual.idUsuario;
            flowLayoutPanel1.Controls.Clear();
            DataTable niveles = Database.funcionesCRUD.nivelUsuario(idUser);
            for (int o = 0; o < niveles.Rows.Count; o++)
            {
                ToolTip ttMensaje = new ToolTip();
                Label lblNivel = new Label();
                string nombreNivel = Convert.ToString(niveles.Rows[o].ItemArray[2]);
                lblNivel.AutoSize = false;
                lblNivel.BackColor = System.Drawing.Color.Transparent;
                lblNivel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblNivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
                lblNivel.Location = new System.Drawing.Point(0, 0);
                /*lblNivel.Margin = new System.Windows.Forms.Padding(0, 0, 700, 0);*/
                lblNivel.Name = "lblNivel" + o;
                ttMensaje.SetToolTip(lblNivel, nombreNivel);
                lblNivel.Padding = new System.Windows.Forms.Padding(15, 15, 25, 0);
                lblNivel.Size = new System.Drawing.Size(895, 45);
                lblNivel.TabIndex = 0 + o;
                lblNivel.Text = nombreNivel;

                int Nivel = Convert.ToInt32(niveles.Rows[o].ItemArray[0]);
                DataTable contactos = Database.funcionesCRUD.mostrarContactos(Tipo, Nivel, idUser);
                for (int i = 0; i < contactos.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        flowLayoutPanel1.Controls.Add(lblNivel);
                    }
                    int id = Convert.ToInt32(contactos.Rows[i].ItemArray[0]);
                    string nombres = Convert.ToString(contactos.Rows[i].ItemArray[1]);
                    string apellidos = Convert.ToString(contactos.Rows[i].ItemArray[2]);
                    Panel pnlContacto = new System.Windows.Forms.Panel();
                    Panel pnlNombres = new System.Windows.Forms.Panel();
                    Label lblNombres = new Label();
                    PictureBox pbxFoto = new PictureBox();
                    Label lblIconChat = new Label();
                    // 
                    // pnlContacto
                    // 
                    pnlContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
                    pnlContacto.Controls.Add(pnlNombres);
                    pnlContacto.Controls.Add(pbxFoto);
                    pnlContacto.Location = new System.Drawing.Point(0 + i * 25, 25);
                    pnlContacto.Margin = new System.Windows.Forms.Padding(25, 25, 25, 15);
                    pnlContacto.Name = "pnlContacto" + i;
                    pnlContacto.Size = new System.Drawing.Size(175, 195);
                    pnlContacto.TabIndex = 1 + i;
                    // 
                    // pnlNombres
                    // 
                    pnlNombres.Controls.Add(lblNombres);
                    pnlNombres.Controls.Add(lblIconChat);
                    pnlNombres.Dock = System.Windows.Forms.DockStyle.Bottom;
                    pnlNombres.Location = new System.Drawing.Point(0, 145);
                    pnlNombres.Name = "pnlNombres" + i;
                    pnlNombres.Size = new System.Drawing.Size(175, 50);
                    pnlNombres.TabIndex = 0 + i;
                    // 
                    // lblNombres
                    // 
                    lblNombres.AutoSize = true;
                    lblNombres.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblNombres.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                    lblNombres.Location = new System.Drawing.Point(0, 0);
                    lblNombres.Name = "lblNombres" + i;
                    lblNombres.Size = new System.Drawing.Size(175, 50);
                    lblNombres.TabIndex = 0 + i;
                    lblNombres.Text = nombres + "\n" + apellidos;
                    ttMensaje.SetToolTip(lblNombres, nombres + " " + apellidos);
                    lblNombres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    lblNombres.Left = (pnlNombres.Width - lblNombres.Width) / 2;
                    lblNombres.Top = (pnlNombres.Height - lblNombres.Height) / 2;
                    // 
                    // pbxFoto
                    // 
                    pbxFoto.BackColor = System.Drawing.Color.White;
                    pbxFoto.Location = new System.Drawing.Point(0, 0);
                    pbxFoto.Name = "pbxFoto" + i;
                    pbxFoto.Size = new System.Drawing.Size(175, 175);
                    pbxFoto.TabIndex = 1 + i;
                    pbxFoto.TabStop = false;
                    pbxFoto.SizeMode = PictureBoxSizeMode.Zoom;
                    var result = Database.archivos.recibirImg(Database.DBfunciones.urlImagenPerfil(id));
                    result.ContinueWith(task =>
                    {
                        pbxFoto.Image = task.Result;
                    });
                    // 
                    // lblIconChat
                    //
                    lblIconChat.BringToFront();
                    lblIconChat.AutoSize = true;
                    lblIconChat.Cursor = Cursors.Hand;
                    lblIconChat.Font = Tipografia.fonts.fontawesome12;
                    lblIconChat.Location = new System.Drawing.Point(137, 11);
                    lblIconChat.Name = "lblIconChat" + i;
                    lblIconChat.Size = new System.Drawing.Size(13, 13);
                    lblIconChat.TabIndex = 1 + i;
                    lblIconChat.Text = "";
                    lblIconChat.Click += (s, ev) =>
                    {
                        mensajes a = new mensajes();
                        (Application.OpenForms["menuUsuario"] as menuUsuario).abrirFormEnPanel(a);
                        a.Conversacion(id);
                    };
                    ttMensaje.SetToolTip(lblIconChat,"Chat");
                    flowLayoutPanel1.Controls.Add(pnlContacto);

                }
            }

        }

        private void directorio_Load(object sender, EventArgs e)
        {
            mostrarContacts();
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            Tipo = 3;
            mostrarContacts();
            btnEstudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
            btnMaestros.BackColor = System.Drawing.Color.Transparent;
            btnMaestros.ForeColor = System.Drawing.Color.Black;
            btnEstudiantes.ForeColor = System.Drawing.Color.White;
        }

        private void btnMaestros_Click(object sender, EventArgs e)
        {
            Tipo = 2;
            mostrarContacts();
            btnMaestros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
            btnEstudiantes.BackColor = System.Drawing.Color.Transparent;
            btnEstudiantes.ForeColor = System.Drawing.Color.Black;
            btnMaestros.ForeColor = System.Drawing.Color.White;
        }

    }
}
