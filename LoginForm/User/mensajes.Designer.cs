namespace LoginForm.User
{
    partial class mensajes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mensajes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEnviar = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.lblIconEmojis = new System.Windows.Forms.Label();
            this.lblIconArchivos = new System.Windows.Forms.Label();
            this.flpConversaciones = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlMensajes = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.flpConversaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.lblEnviar);
            this.panel1.Controls.Add(this.txtMensaje);
            this.panel1.Controls.Add(this.lblIconEmojis);
            this.panel1.Controls.Add(this.lblIconArchivos);
            this.panel1.Location = new System.Drawing.Point(280, 480);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 40);
            this.panel1.TabIndex = 15;
            // 
            // lblEnviar
            // 
            this.lblEnviar.AutoSize = true;
            this.lblEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEnviar.Font = new System.Drawing.Font("Work Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnviar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
            this.lblEnviar.Location = new System.Drawing.Point(559, 11);
            this.lblEnviar.Name = "lblEnviar";
            this.lblEnviar.Size = new System.Drawing.Size(75, 19);
            this.lblEnviar.TabIndex = 20;
            this.lblEnviar.Text = "ENVIAR";
            this.lblEnviar.Click += new System.EventHandler(this.lblEnviar_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensaje.Location = new System.Drawing.Point(123, 11);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(429, 19);
            this.txtMensaje.TabIndex = 19;
            // 
            // lblIconEmojis
            // 
            this.lblIconEmojis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIconEmojis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIconEmojis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconEmojis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.lblIconEmojis.Location = new System.Drawing.Point(70, 0);
            this.lblIconEmojis.Margin = new System.Windows.Forms.Padding(0);
            this.lblIconEmojis.Name = "lblIconEmojis";
            this.lblIconEmojis.Size = new System.Drawing.Size(45, 40);
            this.lblIconEmojis.TabIndex = 18;
            this.lblIconEmojis.Text = "";
            this.lblIconEmojis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIconArchivos
            // 
            this.lblIconArchivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIconArchivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIconArchivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconArchivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.lblIconArchivos.Location = new System.Drawing.Point(20, 0);
            this.lblIconArchivos.Margin = new System.Windows.Forms.Padding(0);
            this.lblIconArchivos.Name = "lblIconArchivos";
            this.lblIconArchivos.Size = new System.Drawing.Size(45, 40);
            this.lblIconArchivos.TabIndex = 17;
            this.lblIconArchivos.Text = "";
            this.lblIconArchivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpConversaciones
            // 
            this.flpConversaciones.AutoScroll = true;
            this.flpConversaciones.Controls.Add(this.pictureBox3);
            this.flpConversaciones.Location = new System.Drawing.Point(0, 40);
            this.flpConversaciones.Margin = new System.Windows.Forms.Padding(0);
            this.flpConversaciones.Name = "flpConversaciones";
            this.flpConversaciones.Size = new System.Drawing.Size(300, 480);
            this.flpConversaciones.TabIndex = 17;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pnlMensajes
            // 
            this.pnlMensajes.AutoScroll = true;
            this.pnlMensajes.Location = new System.Drawing.Point(300, 40);
            this.pnlMensajes.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMensajes.Name = "pnlMensajes";
            this.pnlMensajes.Size = new System.Drawing.Size(620, 437);
            this.pnlMensajes.TabIndex = 19;
            // 
            // mensajes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(920, 520);
            this.Controls.Add(this.pnlMensajes);
            this.Controls.Add(this.flpConversaciones);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Work Sans", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mensajes";
            this.Text = "mensajes";
            this.Load += new System.EventHandler(this.mensajes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flpConversaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEnviar;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label lblIconEmojis;
        private System.Windows.Forms.Label lblIconArchivos;
        private System.Windows.Forms.FlowLayoutPanel flpConversaciones;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlMensajes;
    }
}