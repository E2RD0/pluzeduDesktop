namespace LoginForm
{
    partial class Inicio
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
            this.barra = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pnlNav = new LoginForm.GradientUpBottom();
            this.btnSignout = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnDirectorio = new System.Windows.Forms.Button();
            this.btnMensajes = new System.Windows.Forms.Button();
            this.barra.SuspendLayout();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // barra
            // 
            this.barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
            this.barra.Controls.Add(this.btnClose);
            this.barra.Controls.Add(this.btnMin);
            this.barra.Location = new System.Drawing.Point(80, 0);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(920, 30);
            this.barra.TabIndex = 10;
            this.barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barra_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(888, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 48;
            this.btnClose.Text = "";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 12F, System.Drawing.FontStyle.Bold);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(858, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 30);
            this.btnMin.TabIndex = 49;
            this.btnMin.Text = "";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(80, 30);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(920, 520);
            this.panelContenedor.TabIndex = 25;
            // 
            // pnlNav
            // 
            this.pnlNav.ColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
            this.pnlNav.ColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.pnlNav.Controls.Add(this.btnSignout);
            this.pnlNav.Controls.Add(this.btnConfiguracion);
            this.pnlNav.Controls.Add(this.btnDirectorio);
            this.pnlNav.Controls.Add(this.btnMensajes);
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(80, 550);
            this.pnlNav.TabIndex = 11;
            // 
            // btnSignout
            // 
            this.btnSignout.BackColor = System.Drawing.Color.Transparent;
            this.btnSignout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignout.FlatAppearance.BorderSize = 0;
            this.btnSignout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSignout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignout.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSignout.Location = new System.Drawing.Point(0, 490);
            this.btnSignout.Margin = new System.Windows.Forms.Padding(0);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Size = new System.Drawing.Size(80, 60);
            this.btnSignout.TabIndex = 16;
            this.btnSignout.Text = "";
            this.btnSignout.UseVisualStyleBackColor = false;
            this.btnSignout.Click += new System.EventHandler(this.btnSignout_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracion.Location = new System.Drawing.Point(0, 290);
            this.btnConfiguracion.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(80, 60);
            this.btnConfiguracion.TabIndex = 15;
            this.btnConfiguracion.Text = "";
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // btnDirectorio
            // 
            this.btnDirectorio.BackColor = System.Drawing.Color.Transparent;
            this.btnDirectorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDirectorio.FlatAppearance.BorderSize = 0;
            this.btnDirectorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
            this.btnDirectorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectorio.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectorio.ForeColor = System.Drawing.Color.White;
            this.btnDirectorio.Location = new System.Drawing.Point(0, 230);
            this.btnDirectorio.Margin = new System.Windows.Forms.Padding(0);
            this.btnDirectorio.Name = "btnDirectorio";
            this.btnDirectorio.Size = new System.Drawing.Size(80, 60);
            this.btnDirectorio.TabIndex = 14;
            this.btnDirectorio.Text = "";
            this.btnDirectorio.UseVisualStyleBackColor = false;
            this.btnDirectorio.Click += new System.EventHandler(this.btnDirectorio_Click);
            // 
            // btnMensajes
            // 
            this.btnMensajes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
            this.btnMensajes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMensajes.FlatAppearance.BorderSize = 0;
            this.btnMensajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMensajes.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMensajes.ForeColor = System.Drawing.Color.Transparent;
            this.btnMensajes.Location = new System.Drawing.Point(0, 170);
            this.btnMensajes.Margin = new System.Windows.Forms.Padding(0);
            this.btnMensajes.Name = "btnMensajes";
            this.btnMensajes.Size = new System.Drawing.Size(80, 60);
            this.btnMensajes.TabIndex = 12;
            this.btnMensajes.Text = "";
            this.btnMensajes.UseVisualStyleBackColor = false;
            this.btnMensajes.Click += new System.EventHandler(this.btnMensajes_Click);
            // 
            // Inicio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.barra);
            this.Font = new System.Drawing.Font("Work Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.barra.ResumeLayout(false);
            this.pnlNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barra;
        private GradientUpBottom pnlNav;
        private System.Windows.Forms.Button btnMensajes;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnDirectorio;
        private System.Windows.Forms.Button btnSignout;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
        public System.Windows.Forms.Panel panelContenedor;
    }
}