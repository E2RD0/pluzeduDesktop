namespace LoginForm.User
{
    partial class menuUsuario
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
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pnlNav = new LoginForm.GradientUpBottom();
            this.btnDirectorio = new System.Windows.Forms.Button();
            this.btnSignout = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.barra.SuspendLayout();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // barra
            // 
            this.barra.BackColor = System.Drawing.Color.SteelBlue;
            this.barra.Controls.Add(this.btnMin);
            this.barra.Controls.Add(this.btnClose);
            this.barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra.Location = new System.Drawing.Point(0, 0);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(1000, 30);
            this.barra.TabIndex = 13;
            this.barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barra_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(940, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 30);
            this.btnMin.TabIndex = 45;
            this.btnMin.Text = "";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(970, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 44;
            this.btnClose.Text = "";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Red;
            this.btnAgregar.Location = new System.Drawing.Point(933, 490);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(47, 43);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "plus-circle";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(80, 30);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(920, 520);
            this.panelContenedor.TabIndex = 24;
            // 
            // pnlNav
            // 
            this.pnlNav.ColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
            this.pnlNav.ColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.pnlNav.Controls.Add(this.btnDirectorio);
            this.pnlNav.Controls.Add(this.btnSignout);
            this.pnlNav.Controls.Add(this.btnConfiguracion);
            this.pnlNav.Controls.Add(this.btnInicio);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Location = new System.Drawing.Point(0, 30);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(80, 520);
            this.pnlNav.TabIndex = 14;
            // 
            // btnDirectorio
            // 
            this.btnDirectorio.BackColor = System.Drawing.Color.Transparent;
            this.btnDirectorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDirectorio.FlatAppearance.BorderSize = 0;
            this.btnDirectorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
            this.btnDirectorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectorio.ForeColor = System.Drawing.Color.White;
            this.btnDirectorio.Location = new System.Drawing.Point(0, 196);
            this.btnDirectorio.Margin = new System.Windows.Forms.Padding(0);
            this.btnDirectorio.Name = "btnDirectorio";
            this.btnDirectorio.Size = new System.Drawing.Size(80, 60);
            this.btnDirectorio.TabIndex = 17;
            this.btnDirectorio.Text = "";
            this.btnDirectorio.UseVisualStyleBackColor = false;
            this.btnDirectorio.Click += new System.EventHandler(this.btnNivel_Click);
            // 
            // btnSignout
            // 
            this.btnSignout.BackColor = System.Drawing.Color.Transparent;
            this.btnSignout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignout.FlatAppearance.BorderSize = 0;
            this.btnSignout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSignout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSignout.Location = new System.Drawing.Point(0, 460);
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
            this.btnConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracion.Location = new System.Drawing.Point(0, 256);
            this.btnConfiguracion.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(80, 60);
            this.btnConfiguracion.TabIndex = 14;
            this.btnConfiguracion.Text = "";
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(0, 136);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(80, 60);
            this.btnInicio.TabIndex = 12;
            this.btnInicio.Text = "";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // menuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Niveles";
            this.Load += new System.EventHandler(this.menu_Load);
            this.barra.ResumeLayout(false);
            this.pnlNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDirectorio;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnInicio;
        private GradientUpBottom pnlNav;
        private System.Windows.Forms.Button btnSignout;
        private System.Windows.Forms.Panel barra;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Panel panelContenedor;
    }
}