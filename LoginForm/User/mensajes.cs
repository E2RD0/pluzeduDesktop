using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LoginForm.User
{
    public partial class mensajes : Form
    {
        public static int idUsuarioActual { get; set; }
        public static int idConversacionActual { get; set; }
        public mensajes()
        {
            InitializeComponent();
        }

        private void mostrarConversaciones()
        {
            flpConversaciones.Controls.Clear();

            DataTable conversaciones = Database.funcionesCRUD.mostrarConversaciones(idUsuarioActual);
            for (int i = 0; i < conversaciones.Rows.Count; i++)
            {
                int idConversacion;
                bool esGrupoConversacion;
                string tituloConversacion = "";
                string ultimoMensaje;
                Panel pnlConversacion = new Panel();
                PictureBox pbxFotoPerfil = new PictureBox();
                Label lblTiempo = new Label();
                Label lblUltimoMensaje = new Label();
                Label lblNombre = new Label();

                idConversacion = Convert.ToInt32(conversaciones.Rows[i].ItemArray[0]);
                esGrupoConversacion = Convert.ToBoolean(conversaciones.Rows[i].ItemArray[2]);

                if (esGrupoConversacion)
                {
                    tituloConversacion = Convert.ToString(conversaciones.Rows[i].ItemArray[1]);
                }

                else if (!esGrupoConversacion)
                {
                    DataTable nombreConversacion = new DataTable();
                    MySqlCommand command = new MySqlCommand("SELECT u.id, u.nombres, u.apellidos FROM usuario u INNER JOIN conversacionintegrantes ci ON ci.id_usuario = u.id WHERE ci.id_conversacion = @idConversacion;", Database.conexion.obtenerconexion());
                    command.Parameters.Add("@idConversacion", MySqlDbType.Int32).Value = Convert.ToInt32(conversaciones.Rows[i].ItemArray[0]);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(nombreConversacion);
                    for (int j = 0; j < nombreConversacion.Rows.Count; j++)
                    {
                        int idUsuarioConversacion = Convert.ToInt32(nombreConversacion.Rows[j].ItemArray[0]);
                        if (idUsuarioConversacion != idUsuarioActual)
                        {
                            tituloConversacion = Convert.ToString(nombreConversacion.Rows[j].ItemArray[1]);
                        }
                    }
                }

                // 
                // pnlConversacion
                // 
                //pnlConversacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
                pnlConversacion.Controls.Add(pbxFotoPerfil);
                pnlConversacion.Controls.Add(lblTiempo);
                pnlConversacion.Controls.Add(lblUltimoMensaje);
                pnlConversacion.Controls.Add(lblNombre);
                pnlConversacion.Cursor = System.Windows.Forms.Cursors.Hand;
                pnlConversacion.ForeColor = System.Drawing.SystemColors.ControlText;
                pnlConversacion.Location = new System.Drawing.Point(0, 0);
                pnlConversacion.Margin = new System.Windows.Forms.Padding(0);
                pnlConversacion.Name = "pnlConversacion";
                pnlConversacion.Size = new System.Drawing.Size(280, 80);
                pnlConversacion.TabIndex = 17;
                // 
                // pbxFotoPerfil
                // 
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mensajes));
                //((System.ComponentModel.ISupportInitialize)(pictureBox3)).BeginInit();
                pbxFotoPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                pbxFotoPerfil.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
                pbxFotoPerfil.Location = new System.Drawing.Point(5, 15);
                pbxFotoPerfil.Name = "pbxFotoPerfil";
                pbxFotoPerfil.Size = new System.Drawing.Size(50, 50);
                pbxFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pbxFotoPerfil.TabIndex = 15;
                pbxFotoPerfil.TabStop = false;
                // 
                // lblTiempo
                // 
                lblTiempo.AutoSize = true;
                lblTiempo.Font = new System.Drawing.Font("Work Sans Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblTiempo.ForeColor = System.Drawing.Color.DimGray;
                lblTiempo.Location = new System.Drawing.Point(215, 24);
                lblTiempo.Name = "lblTiempo";
                lblTiempo.Size = new System.Drawing.Size(55, 13);
                lblTiempo.TabIndex = 14;
                lblTiempo.Text = "5:13 pm";
                // 
                // lblUltimoMensaje
                // 
                lblUltimoMensaje.AutoSize = true;
                lblUltimoMensaje.Font = new System.Drawing.Font("Work Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblUltimoMensaje.ForeColor = System.Drawing.Color.DimGray;
                lblUltimoMensaje.Location = new System.Drawing.Point(62, 44);
                lblUltimoMensaje.Name = "lblUltimoMensaje";
                lblUltimoMensaje.Size = new System.Drawing.Size(204, 15);
                lblUltimoMensaje.TabIndex = 1;
                lblUltimoMensaje.Text = "Lorem ipsum dolor sit amet, co";
                // 
                // lblNombre
                // 
                lblNombre.AutoSize = true;
                lblNombre.Font = new System.Drawing.Font("Work Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblNombre.Location = new System.Drawing.Point(62, 19);
                lblNombre.Name = "lblNombre";
                lblNombre.Size = new System.Drawing.Size(141, 19);
                lblNombre.TabIndex = 0;
                lblNombre.Text = tituloConversacion;

                flpConversaciones.Controls.Add(pnlConversacion);
                void pnlConversacionMostrar(object sender, EventArgs e)
                {
                    idConversacionActual = idConversacion;
                    mostrarMensajes(idConversacion);
                    foreach(Control conversacion in flpConversaciones.Controls)
                    {
                        conversacion.BackColor = Color.Transparent;
                    }
                    pnlConversacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
                }
                pnlConversacion.Click += pnlConversacionMostrar;
                lblNombre.Click += pnlConversacionMostrar;
                lblTiempo.Click += pnlConversacionMostrar;
                lblUltimoMensaje.Click += pnlConversacionMostrar;
                pbxFotoPerfil.Click += pnlConversacionMostrar;

            }
        }

        private void mostrarMensajes(int idConversacion)
        {
            pnlMensajes.Controls.Clear();

            int alturaMensaje = 40;

            DataTable mensajes = Database.funcionesCRUD.mostrarMensajes(idConversacion);
            for (int i = 0; i < mensajes.Rows.Count; i++)
            {
                string texto = Convert.ToString(mensajes.Rows[i].ItemArray[0]);
                DateTimeOffset fechaEnviado = new DateTimeOffset(Convert.ToDateTime(mensajes.Rows[i].ItemArray[1]), new TimeSpan(-6, 0, 0));
                fechaEnviado.ToLocalTime();
                int idAutor = Convert.ToInt32(mensajes.Rows[i].ItemArray[2]);
                string fechaMensaje = fechaEnviado.ToString("h:mm tt");
                TableLayoutPanel tlpMensaje = new TableLayoutPanel();
                Label lblMensaje = new Label();
                Label lblTiempoMensaje = new Label();

                if (idAutor != idUsuarioActual)
                {
                    // 
                    // tlpMensaje
                    // 
                    tlpMensaje.AutoSize = true;
                    tlpMensaje.ColumnCount = 1;
                    tlpMensaje.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                    tlpMensaje.Controls.Add(lblTiempoMensaje, 0, 1);
                    tlpMensaje.Controls.Add(lblMensaje, 0, 0);
                    if (i == 0)
                    {
                        tlpMensaje.Location = new System.Drawing.Point(20, 40);
                    }
                    else
                    {
                        tlpMensaje.Location = new System.Drawing.Point(20, alturaMensaje);
                    }
                    tlpMensaje.Name = "tlpMensaje";
                    tlpMensaje.RowCount = 2;
                    tlpMensaje.RowStyles.Add(new System.Windows.Forms.RowStyle());
                    tlpMensaje.RowStyles.Add(new System.Windows.Forms.RowStyle());
                    tlpMensaje.Size = new System.Drawing.Size(420, 40);
                    tlpMensaje.TabIndex = 8;
                    // 
                    // lblMensaje
                    // 
                    lblMensaje.AutoSize = true;
                    lblMensaje.BackColor = System.Drawing.SystemColors.AppWorkspace;
                    lblMensaje.Location = new System.Drawing.Point(3, 0);
                    lblMensaje.MaximumSize = new System.Drawing.Size(420, 0);
                    lblMensaje.Name = "lblMensaje";
                    lblMensaje.Padding = new System.Windows.Forms.Padding(3);
                    lblMensaje.Size = new System.Drawing.Size(70, 25);
                    lblMensaje.TabIndex = 9;
                    lblMensaje.Text = texto;
                    // 
                    // lblTiempoMensaje
                    // 
                    lblTiempoMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                    lblTiempoMensaje.AutoSize = true;
                    lblTiempoMensaje.Font = new System.Drawing.Font("Work Sans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblTiempoMensaje.Location = new System.Drawing.Point(0, 26);
                    lblTiempoMensaje.Margin = new System.Windows.Forms.Padding(0);
                    lblTiempoMensaje.Name = "lblTiempoMensaje";
                    lblTiempoMensaje.Size = new System.Drawing.Size(49, 14);
                    lblTiempoMensaje.TabIndex = 6;
                    lblTiempoMensaje.Text = fechaMensaje;
                    lblTiempoMensaje.TextAlign = System.Drawing.ContentAlignment.BottomRight;

                    pnlMensajes.Controls.Add(tlpMensaje);
                    alturaMensaje += tlpMensaje.Size.Height + 20;
                }
                else
                {
                    // 
                    // tlpMensaje
                    // 
                    tlpMensaje.AutoSize = true;
                    tlpMensaje.ColumnCount = 1;
                    tlpMensaje.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
                    tlpMensaje.Controls.Add(lblTiempoMensaje, 0, 1);
                    tlpMensaje.Controls.Add(lblMensaje, 0, 0);
                    if (i == 0)
                    {
                        tlpMensaje.Location = new System.Drawing.Point(170, 40);
                    }
                    else
                    {
                        tlpMensaje.Location = new System.Drawing.Point(170, alturaMensaje);
                    }
                    tlpMensaje.Name = "tlpMensaje";
                    tlpMensaje.RowCount = 2;
                    tlpMensaje.RowStyles.Add(new System.Windows.Forms.RowStyle());
                    tlpMensaje.RowStyles.Add(new System.Windows.Forms.RowStyle());
                    tlpMensaje.Size = new System.Drawing.Size(420, 40);
                    tlpMensaje.TabIndex = 9;
                    // 
                    // lblTiempoMensaje
                    // 
                    lblTiempoMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                    lblTiempoMensaje.AutoSize = true;
                    lblTiempoMensaje.Font = new System.Drawing.Font("Work Sans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblTiempoMensaje.Location = new System.Drawing.Point(371, 26);
                    lblTiempoMensaje.Margin = new System.Windows.Forms.Padding(0);
                    lblTiempoMensaje.Name = "lblTiempoMensaje";
                    lblTiempoMensaje.Size = new System.Drawing.Size(49, 14);
                    lblTiempoMensaje.TabIndex = 6;
                    lblTiempoMensaje.Text = fechaMensaje;
                    lblTiempoMensaje.TextAlign = System.Drawing.ContentAlignment.BottomRight;
                    // 
                    // lblMensaje
                    // 
                    lblMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                    lblMensaje.AutoSize = true;
                    lblMensaje.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    lblMensaje.Location = new System.Drawing.Point(347, 0);
                    lblMensaje.MaximumSize = new System.Drawing.Size(420, 0);
                    lblMensaje.Name = "lblMensaje";
                    lblMensaje.Padding = new System.Windows.Forms.Padding(3);
                    lblMensaje.Size = new System.Drawing.Size(70, 25);
                    lblMensaje.TabIndex = 9;
                    lblMensaje.Text = texto;
                    pnlMensajes.Controls.Add(tlpMensaje);
                    alturaMensaje += tlpMensaje.Size.Height + 20;
                }
            }
        }

        private void mensajes_Load(object sender, EventArgs e)
        {
            mostrarConversaciones();
            //mostrarMensajes();

            lblIconArchivos.Font = lblIconEmojis.Font = Tipografia.fonts.fontawesome20;
        }

        private void lblEnviar_Click(object sender, EventArgs e)
        {
            if (txtMensaje.Text.Trim() != null && txtMensaje.Text.Trim() != "")
            {
                Database.funcionesCRUD.enviarMensaje(idConversacionActual, txtMensaje.Text, idUsuarioActual);
                mostrarMensajes(idConversacionActual);
                txtMensaje.Text = "";
            }
        }
    }
}
