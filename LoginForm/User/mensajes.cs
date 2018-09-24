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
using LoginForm.Database;
using System.IO;
using System.Threading;
using System.Net;

namespace LoginForm.User
{
    public partial class mensajes : Form
    {
        //VARIABLES
        private int idUsuarioActual = Database.usuarioActual.idUsuario;
        private static int idConversacionActual { get; set; }
        int id2;
        //INICIALIZAR FORM
        public mensajes()
        {
            InitializeComponent();
        }
        private void mensajes_Load(object sender, EventArgs e)
        {
            mostrarConversaciones();
            //mostrarMensajes();
            lblIconArchivos.Font = lblIconEmojis.Font = lblIconInfo.Font = Tipografia.fonts.fontawesome20;
            lblIconPlus.Font = lblIconSearch.Font = btnIconRegresar.Font = Tipografia.fonts.fontawesome14;
            lblBusqueda1.Font = lblBusqueda2.Font = Tipografia.fonts.fontawesome16;
            lblContinuar.Font = Tipografia.fonts.fontawesome24;
            txtMensaje.Focus();
            idConversacionActual = 0;
            //DataTable busqueda = funcionesCRUD.buscarContactos(3, 1, 10, "b");
            //MessageBox.Show((string)(busqueda.Rows[0].ItemArray[0]));
        }
        //MOSTRAR CONVERSACIONES
        private void mostrarConversaciones()
        {
            flpConversaciones.Controls.Clear();

            DataTable conversaciones = Database.funcionesCRUD.mostrarConversaciones(idUsuarioActual);
            for (int i = 0; i < conversaciones.Rows.Count; i++)
            {
                int idConversacion;
                bool esGrupoConversacion;
                string nombreUsuarioConversacion = "";
                string tituloConversacion = "";
                string ultimoMensaje;
                string fechaUltimo;
                Panel pnlConversacion = new Panel();
                circlepbx fotoPerfil = new circlepbx();
                Label lblTiempo = new Label();
                Label lblUltimoMensaje = new Label();
                Label lblNombre = new Label();

                idConversacion = Convert.ToInt32(conversaciones.Rows[i].ItemArray[0]);
                esGrupoConversacion = Convert.ToBoolean(conversaciones.Rows[i].ItemArray[2]);

                if (esGrupoConversacion)
                {
                    tituloConversacion = nombreUsuarioConversacion = Convert.ToString(conversaciones.Rows[i].ItemArray[1]);
                }
                else if (!esGrupoConversacion)
                {
                    DataTable nombreConversacion = Database.funcionesCRUD.datosUsuarioConversacion(idConversacion);
                    for (int j = 0; j < nombreConversacion.Rows.Count; j++)
                    {
                        int idUsuarioConversacion = Convert.ToInt32(nombreConversacion.Rows[j].ItemArray[0]);
                        if (idUsuarioConversacion != idUsuarioActual)
                        {
                            tituloConversacion = Convert.ToString(nombreConversacion.Rows[j].ItemArray[1]);
                            nombreUsuarioConversacion = Convert.ToString(nombreConversacion.Rows[j].ItemArray[1]) +" " + Convert.ToString(nombreConversacion.Rows[j].ItemArray[2]);
                            fotoPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                            var result = Database.archivos.recibirImg(Database.DBfunciones.urlImagenPerfil(idUsuarioConversacion));
                            result.ContinueWith(task =>
                            {
                                fotoPerfil.Image = task.Result;
                            });
                            fotoPerfil.Location = new System.Drawing.Point(5, 15);
                            fotoPerfil.Name = "fotoPerfil";
                            fotoPerfil.Size = new System.Drawing.Size(50, 50);
                            fotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                            fotoPerfil.TabIndex = 15;
                            fotoPerfil.TabStop = false;
                            pnlConversacion.Controls.Add(fotoPerfil);
                        }
                    }
                }
                DataTable ultimo = Database.funcionesCRUD.ultimoMensaje(idConversacion);
                if (ultimo.Rows.Count > 0)
                {
                    bool es_archivo = Convert.ToBoolean(ultimo.Rows[0].ItemArray[2]);
                    if (es_archivo)
                    {
                        ultimoMensaje = archivos.nombreOriginalArchivo(Convert.ToString(ultimo.Rows[0].ItemArray[0]));
                    }
                    else
                    {
                        ultimoMensaje = Convert.ToString(ultimo.Rows[0].ItemArray[0]);
                    }
                    DateTimeOffset fechaUltimoDate = new DateTimeOffset(Convert.ToDateTime(ultimo.Rows[0].ItemArray[1]), new TimeSpan(-6, 0, 0));
                    fechaUltimoDate.ToLocalTime();
                    fechaUltimo = fechaUltimoDate.ToString("h:mm tt");
                }
                else
                {
                    ultimoMensaje = "¡Envía tu primer mensaje!";
                    fechaUltimo = "";
                }
                
                // 
                // pnlConversacion
                // 
                //pnlConversacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
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
                pnlConversacion.MouseEnter += new System.EventHandler(MouseEnter);
                pnlConversacion.MouseLeave += new System.EventHandler(MouseLeave);
                // 
                // pbxFotoPerfil
                // 
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mensajes));
                // 
                // lblTiempo
                // 
                lblTiempo.AutoSize = true;
                lblTiempo.Font = new System.Drawing.Font("Work Sans Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblTiempo.ForeColor = System.Drawing.Color.DimGray;
                lblTiempo.BackColor = System.Drawing.Color.Transparent;
                lblTiempo.Location = new System.Drawing.Point(215, 24);
                lblTiempo.Name = "lblTiempo";
                lblTiempo.Size = new System.Drawing.Size(55, 13);
                lblTiempo.TabIndex = 14;
                lblTiempo.Text = fechaUltimo;
                lblTiempo.MouseEnter += new System.EventHandler(MouseEnter);
                lblTiempo.MouseLeave += new System.EventHandler(MouseLeave);
                // 
                // lblUltimoMensaje
                // 
                lblUltimoMensaje.AutoSize = true;
                lblUltimoMensaje.Font = new System.Drawing.Font("Work Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblUltimoMensaje.ForeColor = System.Drawing.Color.DimGray;
                lblUltimoMensaje.BackColor = System.Drawing.Color.Transparent;
                lblUltimoMensaje.Location = new System.Drawing.Point(62, 44);
                lblUltimoMensaje.Name = "lblUltimoMensaje";
                lblUltimoMensaje.Size = new System.Drawing.Size(204, 15);
                lblUltimoMensaje.TabIndex = 1;
                lblUltimoMensaje.Text = ultimoMensaje;
                lblUltimoMensaje.MouseEnter += new System.EventHandler(MouseEnter);
                lblUltimoMensaje.MouseLeave += new System.EventHandler(MouseLeave);
                // 
                // lblNombre
                // 
                lblNombre.AutoSize = true;
                lblNombre.Font = new System.Drawing.Font("Work Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblNombre.Location = new System.Drawing.Point(62, 19);
                lblNombre.BackColor = System.Drawing.Color.Transparent;
                lblNombre.Name = "lblNombre";
                lblNombre.Size = new System.Drawing.Size(141, 19);
                lblNombre.TabIndex = 0;
                lblNombre.Text = tituloConversacion;
                lblNombre.MouseEnter += new System.EventHandler(MouseEnter);
                lblNombre.MouseLeave += new System.EventHandler(MouseLeave);

                flpConversaciones.Controls.Add(pnlConversacion);
                void pnlConversacionMostrar(object sender, EventArgs e)
                {
                    idConversacionActual = idConversacion;
                    mostrarMensajes(idConversacion);
                    foreach(Control conversacion in flpConversaciones.Controls)
                    {
                        conversacion.BackColor = Color.Transparent;
                    }
                    lblNombreInfo.Text = nombreUsuarioConversacion;
                    lblNombreConversacion.Text = nombreUsuarioConversacion;
                    pnlConversacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
                    txtMensaje.Focus();
                }
                pnlConversacion.Click += pnlConversacionMostrar;
                lblNombre.Click += pnlConversacionMostrar;
                lblTiempo.Click += pnlConversacionMostrar;
                lblUltimoMensaje.Click += pnlConversacionMostrar;
                fotoPerfil.Click += pnlConversacionMostrar;
                void MouseEnter(object sender, EventArgs e)
                {
                    if (!(pnlConversacion.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))))))
                        pnlConversacion.BackColor = System.Drawing.SystemColors.Control;
                }
                void MouseLeave(object sender, EventArgs e)
                {
                    if (!(pnlConversacion.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))))))
                        pnlConversacion.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
                }
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
                bool es_archivo = Convert.ToBoolean(mensajes.Rows[i].ItemArray[3]);
                string fechaMensaje = fechaEnviado.ToString("h:mm tt");
                TableLayoutPanel tlpMensaje = new TableLayoutPanel();
                Label lblTiempoMensaje = new Label();
                if(es_archivo == false)
                {
                    Label lblMensaje = new Label();
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
                else
                {
                    string nombreOriginalArchivo = archivos.nombreOriginalArchivo(texto);
                    string urlDescarga = Uri.UnescapeDataString("https://pluzedu.com/files" + texto);
                    Panel pnlArchivo = new Panel();
                    Button btnDescargar = new Button();
                    Label lblNombreArchivo = new Label();
                    ProgressBar barraProgreso = new ProgressBar();
                    Label lblProgreso = new Label();
                    void descargarArchivo(object sender, EventArgs e)
                    {
                        string nombreArchivo = nombreOriginalArchivo;
                        string extencion = Path.GetExtension(nombreArchivo);
                        var dialog = new SaveFileDialog();
                        dialog.Filter = "Archivos " + "(*" + extencion + ")|*" + extencion + "|Todos los archivos (*.*)|*.*";
                        dialog.FileName = @nombreArchivo;

                        var result = dialog.ShowDialog(); //shows save file dialog
                        if (result == DialogResult.OK)
                        {
                            startDownload(urlDescarga, dialog.FileName);
                            barraProgreso.Visible = true;
                            lblProgreso.Text = "";
                        }
                    }
                    void startDownload(string uri, string filePath)
                    {
                        Thread thread = new Thread(() => {
                            WebClient client = new WebClient();
                            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                            client.DownloadFileAsync(new Uri(uri), @filePath);
                        });
                        thread.Start();
                    }
                    void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
                    {
                        this.BeginInvoke((MethodInvoker)delegate {
                            double bytesIn = double.Parse(e.BytesReceived.ToString());
                            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                            double percentage = bytesIn / totalBytes * 100;
                            //lblProgreso.Text = "Downloaded " + e.BytesReceived + " of " + e.TotalBytesToReceive;
                            barraProgreso.Value = int.Parse(Math.Truncate(percentage).ToString());
                        });
                    }
                    void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
                    {
                        this.BeginInvoke((MethodInvoker)delegate {
                            lblProgreso.Text = "Descarga Completada!";
                            lblProgreso.Location = new System.Drawing.Point((pnlArchivo.Width - lblProgreso.Width) / 2, 4);
                            barraProgreso.Visible = false;
                            barraProgreso.Value = 0;
                        });
                    }
                    pnlArchivo.Click += descargarArchivo;
                    btnDescargar.Click += descargarArchivo;
                    lblNombreArchivo.Click += descargarArchivo;
                        if (idAutor != idUsuarioActual)
                    {
                        // 
                        // tlpMensaje
                        // 
                        tlpMensaje.AutoSize = true;
                        tlpMensaje.ColumnCount = 1;
                        tlpMensaje.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                        tlpMensaje.Controls.Add(lblTiempoMensaje, 0, 1);
                        tlpMensaje.Controls.Add(pnlArchivo, 0, 0);
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
                        // pnlArchivo
                        //
                        pnlArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        pnlArchivo.BackColor = System.Drawing.SystemColors.AppWorkspace;
                        pnlArchivo.Controls.Add(btnDescargar);
                        pnlArchivo.Controls.Add(lblNombreArchivo);
                        pnlArchivo.Controls.Add(barraProgreso);
                        pnlArchivo.Controls.Add(lblProgreso);
                        pnlArchivo.Location = new System.Drawing.Point(3, 0);
                        pnlArchivo.Name = "pnlArchivo";
                        pnlArchivo.Size = new System.Drawing.Size(180, 150);
                        // 
                        // btnDescargar
                        // 
                        btnDescargar.Font = Tipografia.fonts.fontawesome30;
                        btnDescargar.Location = new System.Drawing.Point(40, 34);
                        btnDescargar.Name = "btnDescargar";
                        btnDescargar.Size = new System.Drawing.Size(100, 65);
                        btnDescargar.TabIndex = 1;
                        btnDescargar.Text = "";
                        btnDescargar.UseVisualStyleBackColor = true;
                        // 
                        // lblNombreArchivo
                        // 
                        lblNombreArchivo.Text = nombreOriginalArchivo;
                        lblNombreArchivo.AutoSize = true;
                        lblNombreArchivo.Location = new System.Drawing.Point((pnlArchivo.Width - lblNombreArchivo.Width) / 2, 102);
                        lblNombreArchivo.MaximumSize = new System.Drawing.Size(150, 0);
                        lblNombreArchivo.Name = "lblNombreArchivo";
                        lblNombreArchivo.Font = new System.Drawing.Font("Work Sans", 10.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblNombreArchivo.TabIndex = 0;
                        // 
                        // barraProgreso
                        // 
                        barraProgreso.Location = new System.Drawing.Point(40, 20);
                        barraProgreso.Name = "barraProgreso";
                        barraProgreso.Size = new System.Drawing.Size(100, 15);
                        barraProgreso.Visible = false;
                        // 
                        // lblProgreso
                        // 
                        lblProgreso.AutoSize = true;
                        lblProgreso.ForeColor = System.Drawing.Color.DarkGreen;
                        lblProgreso.Location = new System.Drawing.Point((pnlArchivo.Width - lblProgreso.Width) / 2, 4);
                        lblProgreso.Name = "lblProgreso";
                        lblProgreso.Size = new System.Drawing.Size(115, 13);
                        lblProgreso.TabIndex = 10;
                        lblProgreso.Text = "";
                        lblProgreso.Font = new System.Drawing.Font("Work Sans", 10.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
                        tlpMensaje.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                        tlpMensaje.Controls.Add(lblTiempoMensaje, 0, 1);
                        tlpMensaje.Controls.Add(pnlArchivo, 0, 0);
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
                        tlpMensaje.TabIndex = 8;
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
                        // pnlArchivo
                        //
                        pnlArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        pnlArchivo.BackColor = System.Drawing.SystemColors.AppWorkspace;
                        pnlArchivo.Controls.Add(btnDescargar);
                        pnlArchivo.Controls.Add(lblNombreArchivo);
                        pnlArchivo.Controls.Add(barraProgreso);
                        pnlArchivo.Controls.Add(lblProgreso);
                        pnlArchivo.Location = new System.Drawing.Point(347, 0);
                        pnlArchivo.Name = "pnlArchivo";
                        pnlArchivo.Size = new System.Drawing.Size(180, 150);
                        // 
                        // btnDescargar
                        // 
                        btnDescargar.Font = Tipografia.fonts.fontawesome30;
                        btnDescargar.Location = new System.Drawing.Point(40, 34);
                        btnDescargar.Name = "btnDescargar";
                        btnDescargar.Size = new System.Drawing.Size(100, 65);
                        btnDescargar.TabIndex = 1;
                        btnDescargar.Text = "";
                        btnDescargar.UseVisualStyleBackColor = true;
                        // 
                        // lblNombreArchivo
                        // 
                        lblNombreArchivo.Text = nombreOriginalArchivo;
                        lblNombreArchivo.AutoSize = true;
                        lblNombreArchivo.Location = new System.Drawing.Point((pnlArchivo.Width - lblNombreArchivo.Width) / 2, 102);
                        lblNombreArchivo.MaximumSize = new System.Drawing.Size(150, 0);
                        lblNombreArchivo.Font = new System.Drawing.Font("Work Sans", 10.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblNombreArchivo.Name = "lblNombreArchivo";
                        lblNombreArchivo.TabIndex = 0;
                        // 
                        // barraProgreso
                        // 
                        barraProgreso.Location = new System.Drawing.Point(40, 20);
                        barraProgreso.Name = "barraProgreso";
                        barraProgreso.Size = new System.Drawing.Size(100, 15);
                        barraProgreso.Visible = false;
                        // 
                        // lblProgreso
                        // 
                        lblProgreso.AutoSize = true;
                        lblProgreso.ForeColor = System.Drawing.Color.DarkGreen;
                        lblProgreso.Location = new System.Drawing.Point((pnlArchivo.Width - lblProgreso.Width) / 2, 4);
                        lblProgreso.Name = "lblProgreso";
                        lblProgreso.Size = new System.Drawing.Size(115, 13);
                        lblProgreso.Font = new System.Drawing.Font("Work Sans", 10.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblProgreso.TabIndex = 10;
                        lblProgreso.Text = "";

                        pnlMensajes.Controls.Add(tlpMensaje);
                        alturaMensaje += tlpMensaje.Size.Height + 20;
                    }

                }
            }
            pnlMensajes.AutoScrollPosition = new Point(0, pnlMensajes.DisplayRectangle.Height);
        }
        public void EnviarMensaje()
        {
            if (idConversacionActual > 0)
            {
                try
                {
                    if (txtMensaje.Text.Trim() != null && txtMensaje.Text.Trim() != "")
                    {
                        Database.funcionesCRUD.enviarMensaje(idConversacionActual, txtMensaje.Text, idUsuarioActual);
                        mostrarMensajes(idConversacionActual);
                        txtMensaje.Text = "";
                    }
                }
                catch(Exception eEnviar)
                {
                    MessageBox.Show("Error al enviar mensaje." + eEnviar.Message, "Advertencía", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No has seleccionado ninguna conversacion.", "Advertencía", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void lblEnviar_Click(object sender, EventArgs e) //ENVIAR MENSAJE
        {
            EnviarMensaje();
        }
        public void Conversacion(int idSegundo)
        {
            //deletethis m = new deletethis();
            //m.dataGridView1.DataSource = funcionesCRUD.conversacionIndivExiste(idUsuarioActual, idSegundo);
            //m.Show();
            int idConInd = funcionesCRUD.conversacionIndivExiste(idUsuarioActual, idSegundo);
            if (idConInd == 0)
            {
                int CCI = funcionesCRUD.crearConversacionIndividual(idUsuarioActual, idSegundo);
                mostrarConversaciones();
                if (CCI > 0)
                {
                    idConInd = funcionesCRUD.conversacionIndivExiste(idUsuarioActual, idSegundo);
                    DataTable nombreConversacion = Database.funcionesCRUD.datosUsuarioConversacion(idConInd);
                    for (int j = 0; j < nombreConversacion.Rows.Count; j++)
                    {
                        int idUsuarioConversacion = Convert.ToInt32(nombreConversacion.Rows[j].ItemArray[0]);
                        if (idUsuarioConversacion != idUsuarioActual)
                        {
                            string nombreUsuarioConversacion = Convert.ToString(nombreConversacion.Rows[j].ItemArray[1]) + " " + Convert.ToString(nombreConversacion.Rows[j].ItemArray[2]);
                            lblNombreInfo.Text = nombreUsuarioConversacion;
                            lblNombreConversacion.Text = nombreUsuarioConversacion;
                        }

                    }
                    mostrarMensajes(idConInd);
                    idConversacionActual = idConInd;
                    foreach (Control conversacion in flpConversaciones.Controls)
                    {
                        conversacion.BackColor = Color.Transparent;
                    }
                    //pnlConversacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
                    txtMensaje.Focus();
                }
                else
                {
                    MessageBox.Show("La conversación no se ha podido crear.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (idConInd > 0)
            {
                mostrarMensajes(idConInd);
                DataTable nombreConversacion = Database.funcionesCRUD.datosUsuarioConversacion(idConInd);
                for (int j = 0; j < nombreConversacion.Rows.Count; j++)
                {
                    int idUsuarioConversacion = Convert.ToInt32(nombreConversacion.Rows[j].ItemArray[0]);
                    if (idUsuarioConversacion != idUsuarioActual)
                    {
                        string nombreUsuarioConversacion = Convert.ToString(nombreConversacion.Rows[j].ItemArray[1]) + " " + Convert.ToString(nombreConversacion.Rows[j].ItemArray[2]);
                        lblNombreInfo.Text = nombreUsuarioConversacion;
                        lblNombreConversacion.Text = nombreUsuarioConversacion;
                    }

                }
                mostrarMensajes(idConInd);
                idConversacionActual = idConInd;
                foreach (Control conversacion in flpConversaciones.Controls)
                {
                    conversacion.BackColor = Color.Transparent;
                }
                //pnlConversacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
                txtMensaje.Focus();
            }
            if (pnlBuscar.Visible == true && pnlAgregar.Visible == false)
            {
                pnlBuscar.Visible = false;
                txtBuscar.Clear();
            }
            else
            {
                pnlAgregar.Visible = false;
                txtAgregar.Clear();
            }
            txtMensaje.Focus();
        }
        //INTERACCIÓN USUARIO-FORMS
        private void lblIconInfo_Click(object sender, EventArgs e)
        {
            pnlInfo.Visible = true;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            pnlInfo.Visible = false;
        }
        private void lblIconSearch_Click(object sender, EventArgs e)
        {
            pnlBuscar.Visible = true;
            Buscar();
            txtBuscar.Focus();
        }
        private void lblIconPlus_Click(object sender, EventArgs e)
        {
            pnlAgregar.Visible = true;
            Buscar();
            txtAgregar.Focus();
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            pnlBuscar.Visible = false;
            flpBusqueda.Controls.Clear();
            txtMensaje.Focus();
        }
        private void btnRetorno_Click(object sender, EventArgs e)
        {
            txtAgregar.Clear();
            pnlAgregar.Visible = false;
            flpBusqueda.Controls.Clear();

            pnlNuevoGrupo.Visible = true;
            pnlIntegrantes.Visible = false;
            pnlContinuar.Visible = false;
            flpAgregar.Size = new Size(266, 402);

            txtMensaje.Focus();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        private void txtAgregar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        private void txtAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch { }
        }
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch { }
        }
        private void txtMensaje_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnviarMensaje();
            }
        }
        private void pnlNuevoGrupo_MouseDown(object sender, MouseEventArgs e)
        {

            pnlNuevoGrupo.Visible = false;
            pnlIntegrantes.Visible = true;
            pnlContinuar.Visible = true;
            flpAgregar.Size = new Size(266, 348);
        }
        private void pnlNuevoGrupo_MouseEnter(object sender, EventArgs e)
        {
            pnlNuevoGrupo.BackColor = System.Drawing.SystemColors.Control;
        }
        private void pnlNuevoGrupo_MouseLeave(object sender, EventArgs e)
        {
            pnlNuevoGrupo.BackColor = System.Drawing.Color.White;
        }
        private void pnlNuevoGrupo_MouseUp(object sender, MouseEventArgs e)
        {
            pnlNuevoGrupo.BackColor = System.Drawing.SystemColors.Control;
        }
        //BUSCAR USUARIOS
        private void Buscar()
        {
            string busquedatxt;
            if (pnlBuscar.Visible == true && pnlAgregar.Visible == false) { flpBusqueda.Controls.Clear(); busquedatxt = txtBuscar.Text; } else { flpAgregar.Controls.Clear(); busquedatxt = txtAgregar.Text; }
            if (!string.IsNullOrEmpty(busquedatxt.Trim()))
            {
                DataTable niveles = Database.funcionesCRUD.nivelUsuario(idUsuarioActual);
                for (int o = 0; o < niveles.Rows.Count; o++)
                {
                    Label lblNivel = new Label();
                    string nombreNivel = Convert.ToString(niveles.Rows[o].ItemArray[2]);
                    lblNivel.AutoSize = true;
                    lblNivel.BackColor = System.Drawing.Color.Transparent;
                    lblNivel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblNivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
                    lblNivel.Location = new System.Drawing.Point(14, 8);
                    /*lblNivel.Margin = new System.Windows.Forms.Padding(0, 0, 700, 0);*/
                    lblNivel.Name = "lblNivel" + o;
                    lblNivel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
                    lblNivel.TabIndex = 0 + o;
                    //lblNivel.Text = nombreNivel;

                    if (pnlBuscar.Visible == true && pnlAgregar.Visible == false) { flpBusqueda.Controls.Add(lblNivel); } else { flpAgregar.Controls.Add(lblNivel); }

                    int Nivel = Convert.ToInt32(niveles.Rows[o].ItemArray[0]);
                    DataTable busqueda = funcionesCRUD.buscarContactos(Nivel, idUsuarioActual, busquedatxt);
                    for (int i = 0; i < busqueda.Rows.Count; i++)
                    {
                        {
                            if (busqueda.Rows.Count > 0)
                            {
                                //deletethis n = new deletethis();
                                //n.dataGridView1.DataSource = busqueda;
                                //n.Show();
                                id2 = Convert.ToInt32(busqueda.Rows[i].ItemArray[2]);
                                string nombre = Convert.ToString(busqueda.Rows[i].ItemArray[0]) + " " + Convert.ToString(busqueda.Rows[i].ItemArray[1]);
                                Panel pnlName = new System.Windows.Forms.Panel();
                                circlepbx fotoPerfil = new circlepbx();
                                Label lblName = new System.Windows.Forms.Label();
                                Label lblNameIdentificador = new System.Windows.Forms.Label();
                                Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
                                Microsoft.VisualBasic.PowerPacks.LineShape lsName = new Microsoft.VisualBasic.PowerPacks.LineShape();
                                // 
                                // pnlName
                                // 
                                pnlName.BackColor = System.Drawing.Color.Transparent;
                                pnlName.Controls.Add(fotoPerfil);
                                pnlName.Controls.Add(lblName);
                                pnlName.Controls.Add(shapeContainer2);
                                pnlName.Controls.Add(lblNameIdentificador);
                                pnlName.Location = new System.Drawing.Point(0, 215);
                                pnlName.Margin = new System.Windows.Forms.Padding(0);
                                pnlName.Name = "pnlName" + i;
                                pnlName.Size = new System.Drawing.Size(263, 63);
                                pnlName.TabIndex = 0;
                                pnlName.MouseDown += new System.Windows.Forms.MouseEventHandler(pnlName_MouseDown);
                                pnlName.MouseEnter += new System.EventHandler(pnlName_MouseEnter);
                                pnlName.MouseLeave += new System.EventHandler(pnlName_MouseLeave);
                                pnlName.MouseUp += new System.Windows.Forms.MouseEventHandler(pnlName_MouseUp);
                                // 
                                // pbName
                                // 
                                var result = Database.archivos.recibirImg(Database.DBfunciones.urlImagenPerfil(id2));
                                result.ContinueWith(task =>
                                {
                                    fotoPerfil.Image = task.Result;
                                });
                                fotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
                                fotoPerfil.BackColor = System.Drawing.SystemColors.Control;
                                fotoPerfil.Location = new System.Drawing.Point(11, 8);
                                fotoPerfil.Name = "pbName" + i;
                                fotoPerfil.Size = new System.Drawing.Size(50, 50);
                                fotoPerfil.TabIndex = 0;
                                fotoPerfil.TabStop = false;
                                fotoPerfil.MouseDown += new System.Windows.Forms.MouseEventHandler(pnlName_MouseDown);
                                fotoPerfil.MouseEnter += new System.EventHandler(pnlName_MouseEnter);
                                fotoPerfil.MouseLeave += new System.EventHandler(pnlName_MouseLeave);
                                fotoPerfil.MouseUp += new System.Windows.Forms.MouseEventHandler(pnlName_MouseUp);
                                // 
                                // lblName
                                // 
                                lblName.AutoSize = true;
                                lblName.BackColor = System.Drawing.Color.Transparent;
                                lblName.Location = new System.Drawing.Point(81, 12);
                                lblName.MaximumSize = new System.Drawing.Size(175, 0);
                                lblName.Name = "lblName" + i;
                                lblName.Size = new System.Drawing.Size(153, 38);
                                lblName.TabIndex = 0;
                                lblName.Text = nombre;
                                lblName.MouseDown += new System.Windows.Forms.MouseEventHandler(pnlName_MouseDown);
                                lblName.MouseEnter += new System.EventHandler(pnlName_MouseEnter);
                                lblName.MouseLeave += new System.EventHandler(pnlName_MouseLeave);
                                lblName.MouseUp += new System.Windows.Forms.MouseEventHandler(pnlName_MouseUp);
                                // 
                                // shapeContainer2
                                // 
                                shapeContainer2.Location = new System.Drawing.Point(0, 0);
                                shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
                                shapeContainer2.Name = "shapeContainer2" + i;
                                shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] { lsName });
                                shapeContainer2.Size = new System.Drawing.Size(266, 63);
                                shapeContainer2.TabIndex = 1;
                                shapeContainer2.TabStop = false;
                                // 
                                // lsName
                                // 
                                lsName.BorderColor = System.Drawing.Color.DarkGray;
                                lsName.Name = "lsName" + i;
                                lsName.SelectionColor = System.Drawing.Color.Transparent;
                                lsName.X1 = 0;
                                lsName.X2 = 266;
                                lsName.Y1 = 62;
                                lsName.Y2 = 62;
                                if (Convert.ToString(busqueda.Rows[i].ItemArray[3]) == "Maestro")
                                {
                                    // 
                                    // lblNameIdentificador
                                    // 
                                    lblNameIdentificador.Font = Tipografia.fonts.fontawesome12;
                                    lblNameIdentificador.BackColor = System.Drawing.Color.Transparent;
                                    lblNameIdentificador.Name = "lblNameIdentificador" + i;
                                    lblNameIdentificador.Location = new Point(235, 10);
                                    lblNameIdentificador.Size = new System.Drawing.Size(23, 24);
                                    lblNameIdentificador.TabIndex = 0;
                                    lblNameIdentificador.Text = "";
                                    lblNameIdentificador.MouseDown += new System.Windows.Forms.MouseEventHandler(pnlName_MouseDown);
                                    lblNameIdentificador.MouseEnter += new System.EventHandler(pnlName_MouseEnter);
                                    lblNameIdentificador.MouseLeave += new System.EventHandler(pnlName_MouseLeave);
                                    lblNameIdentificador.MouseUp += new System.Windows.Forms.MouseEventHandler(pnlName_MouseUp);
                                }
                                void pnlName_MouseEnter(object sender, EventArgs e)
                                {
                                    pnlName.BackColor = System.Drawing.SystemColors.Control;
                                }
                                void pnlName_MouseLeave(object sender, EventArgs e)
                                {
                                    pnlName.BackColor = System.Drawing.Color.White;
                                }
                                void pnlName_MouseDown(object sender, MouseEventArgs e)
                                {
                                    pnlName.BackColor = System.Drawing.Color.LightGray;
                                    if ((pnlAgregar.Visible == true && pnlBuscar.Visible == false) && pnlIntegrantes.Visible == true)
                                    {
                                    }
                                    Conversacion(id2);
                                }
                                void pnlName_MouseUp(object sender, MouseEventArgs e)
                                {
                                    pnlName.BackColor = System.Drawing.SystemColors.Control;
                                }
                                if (pnlBuscar.Visible == true && pnlAgregar.Visible == false) { flpBusqueda.Controls.Add(pnlName); } else { flpAgregar.Controls.Add(pnlName); }
                            }
                            else { }
                        }
                    }
                }
            }
            else
            {
                DataTable niveles = Database.funcionesCRUD.nivelUsuario(idUsuarioActual);
                for (int o = 0; o < niveles.Rows.Count; o++)
                {
                    Label lblNivel = new Label();
                    string nombreNivel = Convert.ToString(niveles.Rows[o].ItemArray[2]);
                    lblNivel.AutoSize = false;
                    lblNivel.BackColor = System.Drawing.Color.Transparent;
                    lblNivel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblNivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
                    lblNivel.Location = new System.Drawing.Point(0, 0);
                    /*lblNivel.Margin = new System.Windows.Forms.Padding(0, 0, 700, 0);*/
                    lblNivel.Name = "lblNivel" + o;
                    lblNivel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
                    lblNivel.TabIndex = 0 + o;
                    //lblNivel.Text = nombreNivel;

                    if (pnlBuscar.Visible == true && pnlAgregar.Visible == false) { flpBusqueda.Controls.Add(lblNivel); } else { flpAgregar.Controls.Add(lblNivel); }

                    int Nivel = Convert.ToInt32(niveles.Rows[o].ItemArray[0]);
                    DataTable Default = funcionesCRUD.mostrarContactosBuscar(Nivel, idUsuarioActual);
                    for (int i = 0; i < Default.Rows.Count; i++)
                {
                    int id2 = Convert.ToInt32(Default.Rows[i].ItemArray[0]);
                    string nombre = Convert.ToString(Default.Rows[i].ItemArray[1]) + " " + Convert.ToString(Default.Rows[i].ItemArray[2]);
                    Panel pnlName = new System.Windows.Forms.Panel();
                    circlepbx fotoPerfilBusqueda = new circlepbx();
                    Label lblName = new System.Windows.Forms.Label();
                    Label lblNameIdentificador = new Label();
                    Label lblid2 = new Label();
                    Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
                    Microsoft.VisualBasic.PowerPacks.LineShape lsName = new Microsoft.VisualBasic.PowerPacks.LineShape();
                    // 
                    // pnlName
                    // 
                    pnlName.BackColor = System.Drawing.Color.Transparent;
                    pnlName.Controls.Add(fotoPerfilBusqueda);
                    pnlName.Controls.Add(lblName);
                    pnlName.Controls.Add(shapeContainer2);
                    pnlName.Controls.Add(lblNameIdentificador);
                    pnlName.Location = new System.Drawing.Point(0, 215);
                    pnlName.Margin = new System.Windows.Forms.Padding(0);
                    pnlName.Name = "pnlName" + i;
                    pnlName.Size = new System.Drawing.Size(263, 63);
                    pnlName.TabIndex = 0;
                    pnlName.MouseDown += new System.Windows.Forms.MouseEventHandler(pnlName_MouseDown);
                    pnlName.MouseEnter += new System.EventHandler(pnlName_MouseEnter);
                    pnlName.MouseLeave += new System.EventHandler(pnlName_MouseLeave);
                    pnlName.MouseUp += new System.Windows.Forms.MouseEventHandler(pnlName_MouseUp);
                    // 
                    // pbName
                    //
                    var result = Database.archivos.recibirImg(Database.DBfunciones.urlImagenPerfil(id2));
                    result.ContinueWith(task =>
                    {
                        fotoPerfilBusqueda.Image = task.Result;
                    });
                    fotoPerfilBusqueda.BackColor = System.Drawing.SystemColors.Control;
                    fotoPerfilBusqueda.SizeMode = PictureBoxSizeMode.StretchImage;
                    fotoPerfilBusqueda.Location = new System.Drawing.Point(11, 8);
                    fotoPerfilBusqueda.Name = "pbName" + i;
                    fotoPerfilBusqueda.Size = new System.Drawing.Size(50, 50);
                    fotoPerfilBusqueda.TabIndex = 0;
                    fotoPerfilBusqueda.TabStop = false;
                    fotoPerfilBusqueda.MouseDown += new System.Windows.Forms.MouseEventHandler(pnlName_MouseDown);
                    fotoPerfilBusqueda.MouseEnter += new System.EventHandler(pnlName_MouseEnter);
                    fotoPerfilBusqueda.MouseLeave += new System.EventHandler(pnlName_MouseLeave);
                    fotoPerfilBusqueda.MouseUp += new System.Windows.Forms.MouseEventHandler(pnlName_MouseUp);
                    // 
                    // lblName
                    // 
                    lblName.AutoSize = true;
                    lblName.BackColor = System.Drawing.Color.Transparent;
                    lblName.Location = new System.Drawing.Point(81, 12);
                    lblName.MaximumSize = new System.Drawing.Size(175, 0);
                    lblName.Name = "lblName" + i;
                    lblName.Size = new System.Drawing.Size(153, 38);
                    lblName.TabIndex = 0;
                    lblName.Text = nombre;
                    lblName.MouseDown += new System.Windows.Forms.MouseEventHandler(pnlName_MouseDown);
                    lblName.MouseEnter += new System.EventHandler(pnlName_MouseEnter);
                    lblName.MouseLeave += new System.EventHandler(pnlName_MouseLeave);
                    lblName.MouseUp += new System.Windows.Forms.MouseEventHandler(pnlName_MouseUp);
                    // 
                    // shapeContainer2
                    // 
                    shapeContainer2.Location = new System.Drawing.Point(0, 0);
                    shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
                    shapeContainer2.Name = "shapeContainer2" + i;
                    shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
                    lsName});
                    shapeContainer2.Size = new System.Drawing.Size(266, 63);
                    shapeContainer2.TabIndex = 1;
                    shapeContainer2.TabStop = false;
                    // 
                    // lsName
                    // 
                    lsName.BorderColor = System.Drawing.Color.DarkGray;
                    lsName.Name = "lsName" + i;
                    lsName.SelectionColor = System.Drawing.Color.Transparent;
                    lsName.X1 = 0;
                    lsName.X2 = 266;
                    lsName.Y1 = 62;
                    lsName.Y2 = 62;
                    if (Convert.ToString(Default.Rows[i].ItemArray[3]) == "Maestro")
                    {
                        // 
                        // lblNameIdentificador
                        // 
                        lblNameIdentificador.Font = Tipografia.fonts.fontawesome12;
                        lblNameIdentificador.BackColor = System.Drawing.Color.Transparent;
                        lblNameIdentificador.Name = "lblNameIdentificador" + i;
                        lblNameIdentificador.Location = new Point(235, 10);
                        lblNameIdentificador.Size = new System.Drawing.Size(23, 24);
                        lblNameIdentificador.TabIndex = 0;
                        lblNameIdentificador.Text = "";
                        lblNameIdentificador.MouseDown += new System.Windows.Forms.MouseEventHandler(pnlName_MouseDown);
                        lblNameIdentificador.MouseEnter += new System.EventHandler(pnlName_MouseEnter);
                        lblNameIdentificador.MouseLeave += new System.EventHandler(pnlName_MouseLeave);
                        lblNameIdentificador.MouseUp += new System.Windows.Forms.MouseEventHandler(pnlName_MouseUp);
                    }
                    void pnlName_MouseEnter(object sender, EventArgs e)
                    {
                        pnlName.BackColor = System.Drawing.SystemColors.Control;
                    }
                    void pnlName_MouseLeave(object sender, EventArgs e)
                    {
                        pnlName.BackColor = System.Drawing.Color.White;
                    }
                    void pnlName_MouseDown(object sender, MouseEventArgs e)
                    {
                        pnlName.BackColor = System.Drawing.Color.LightGray;
                        Conversacion(id2);
                    }
                    void pnlName_MouseUp(object sender, MouseEventArgs e)
                    {
                        pnlName.BackColor = System.Drawing.SystemColors.Control;
                    }
                    if (pnlBuscar.Visible == true && pnlAgregar.Visible == false) { flpBusqueda.Controls.Add(pnlName); } else { flpAgregar.Controls.Add(pnlName); }
                    }
                }
            }
        }

        private void lblIconArchivos_Click(object sender, EventArgs e)
        {
            if (idConversacionActual > 0)
            {
                try
                {
                    OpenFileDialog open = new OpenFileDialog();
                    if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        string fileLocation = open.FileName;
                        long fileSize = new FileInfo(open.FileName).Length;
                        if (fileSize > 16000000)
                        {
                            MessageBox.Show("El archivo es muy pesado, intentalo de nuevo.");
                        }
                        else
                        {
                            archivos.subirArchivo(fileLocation, idConversacionActual, Database.usuarioActual.idUsuario);
                            mostrarMensajes(idConversacionActual);

                        }


                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(Convert.ToString(error.Message));
                }
            }
            else
            {
                MessageBox.Show("No has seleccionado ninguna conversación.", "Advertencía", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
