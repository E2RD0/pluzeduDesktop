namespace LoginForm
{
    partial class panelMensajes
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
            this.pnlMensajes = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMsj = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblMsj = new System.Windows.Forms.Label();
            this.lblEmisor = new System.Windows.Forms.Label();
            this.pnlMensajes.SuspendLayout();
            this.pnlMsj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMensajes
            // 
            this.pnlMensajes.AutoScroll = true;
            this.pnlMensajes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlMensajes.Controls.Add(this.pnlMsj);
            this.pnlMensajes.Location = new System.Drawing.Point(0, 40);
            this.pnlMensajes.Name = "pnlMensajes";
            this.pnlMensajes.Size = new System.Drawing.Size(300, 480);
            this.pnlMensajes.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 40);
            this.panel1.TabIndex = 1;
            // 
            // pnlMsj
            // 
            this.pnlMsj.Controls.Add(this.lblHora);
            this.pnlMsj.Controls.Add(this.lblMsj);
            this.pnlMsj.Controls.Add(this.lblEmisor);
            this.pnlMsj.Controls.Add(this.pictureBox1);
            this.pnlMsj.Location = new System.Drawing.Point(0, 0);
            this.pnlMsj.Name = "pnlMsj";
            this.pnlMsj.Size = new System.Drawing.Size(280, 80);
            this.pnlMsj.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblHora.Location = new System.Drawing.Point(218, 25);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(52, 13);
            this.lblHora.TabIndex = 17;
            this.lblHora.Text = "5:13 pm";
            // 
            // lblMsj
            // 
            this.lblMsj.AutoSize = true;
            this.lblMsj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblMsj.Location = new System.Drawing.Point(65, 45);
            this.lblMsj.Name = "lblMsj";
            this.lblMsj.Size = new System.Drawing.Size(189, 16);
            this.lblMsj.TabIndex = 16;
            this.lblMsj.Text = "Lorem ipsum dolor sit amet, co";
            // 
            // lblEmisor
            // 
            this.lblEmisor.AutoSize = true;
            this.lblEmisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmisor.Location = new System.Drawing.Point(65, 20);
            this.lblEmisor.Name = "lblEmisor";
            this.lblEmisor.Size = new System.Drawing.Size(127, 20);
            this.lblEmisor.TabIndex = 15;
            this.lblEmisor.Text = "Julio Escamilla";
            // 
            // panelMensajes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(920, 520);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMensajes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "panelMensajes";
            this.Text = "panelMensajes";
            this.pnlMensajes.ResumeLayout(false);
            this.pnlMsj.ResumeLayout(false);
            this.pnlMsj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMensajes;
        private System.Windows.Forms.Panel pnlMsj;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblMsj;
        private System.Windows.Forms.Label lblEmisor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}