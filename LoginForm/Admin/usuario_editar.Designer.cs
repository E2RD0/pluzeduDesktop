namespace LoginForm.Admin
{
    partial class usuario_editar
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
            this.components = new System.ComponentModel.Container();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMostrarClave = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.cbx_Estado = new System.Windows.Forms.ComboBox();
            this.cbx_Tipo = new System.Windows.Forms.ComboBox();
            this.linkClavePredeterminada = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Apellidos = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nombres = new System.Windows.Forms.TextBox();
            this.barra = new System.Windows.Forms.Panel();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.lblEmailValidacion = new System.Windows.Forms.Label();
            this.lblValidacionClave = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.barra.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(3, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Editar Usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblValidacionClave);
            this.panel1.Controls.Add(this.lblEmailValidacion);
            this.panel1.Controls.Add(this.lblMostrarClave);
            this.panel1.Controls.Add(this.txt_Id);
            this.panel1.Controls.Add(this.cbx_Estado);
            this.panel1.Controls.Add(this.cbx_Tipo);
            this.panel1.Controls.Add(this.linkClavePredeterminada);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_Codigo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_Email);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_Usuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Apellidos);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_Nombres);
            this.panel1.Controls.Add(this.barra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 331);
            this.panel1.TabIndex = 1;
            // 
            // lblMostrarClave
            // 
            this.lblMostrarClave.AutoSize = true;
            this.lblMostrarClave.Location = new System.Drawing.Point(501, 214);
            this.lblMostrarClave.Name = "lblMostrarClave";
            this.lblMostrarClave.Size = new System.Drawing.Size(18, 17);
            this.lblMostrarClave.TabIndex = 52;
            this.lblMostrarClave.Text = "";
            this.lblMostrarClave.MouseEnter += new System.EventHandler(this.lblMostrarClave_MouseEnter);
            this.lblMostrarClave.MouseLeave += new System.EventHandler(this.lblMostrarClave_MouseLeave);
            // 
            // txt_Id
            // 
            this.txt_Id.AllowDrop = true;
            this.txt_Id.BackColor = System.Drawing.Color.DarkGray;
            this.txt_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Id.Enabled = false;
            this.txt_Id.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.ForeColor = System.Drawing.Color.White;
            this.txt_Id.Location = new System.Drawing.Point(26, 36);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.Size = new System.Drawing.Size(59, 23);
            this.txt_Id.TabIndex = 51;
            this.txt_Id.Visible = false;
            // 
            // cbx_Estado
            // 
            this.cbx_Estado.BackColor = System.Drawing.Color.DarkGray;
            this.cbx_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Estado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_Estado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Estado.ForeColor = System.Drawing.Color.White;
            this.cbx_Estado.FormattingEnabled = true;
            this.cbx_Estado.Location = new System.Drawing.Point(345, 81);
            this.cbx_Estado.Name = "cbx_Estado";
            this.cbx_Estado.Size = new System.Drawing.Size(150, 25);
            this.cbx_Estado.TabIndex = 50;
            // 
            // cbx_Tipo
            // 
            this.cbx_Tipo.BackColor = System.Drawing.Color.DarkGray;
            this.cbx_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_Tipo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Tipo.ForeColor = System.Drawing.Color.White;
            this.cbx_Tipo.FormattingEnabled = true;
            this.cbx_Tipo.Location = new System.Drawing.Point(67, 82);
            this.cbx_Tipo.Name = "cbx_Tipo";
            this.cbx_Tipo.Size = new System.Drawing.Size(182, 25);
            this.cbx_Tipo.TabIndex = 49;
            // 
            // linkClavePredeterminada
            // 
            this.linkClavePredeterminada.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.linkClavePredeterminada.AutoSize = true;
            this.linkClavePredeterminada.LinkColor = System.Drawing.Color.DimGray;
            this.linkClavePredeterminada.Location = new System.Drawing.Point(120, 233);
            this.linkClavePredeterminada.Name = "linkClavePredeterminada";
            this.linkClavePredeterminada.Size = new System.Drawing.Size(194, 17);
            this.linkClavePredeterminada.TabIndex = 48;
            this.linkClavePredeterminada.TabStop = true;
            this.linkClavePredeterminada.Text = "Contraseña predeterminada";
            this.linkClavePredeterminada.VisitedLinkColor = System.Drawing.Color.DimGray;
            this.linkClavePredeterminada.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClavePredeterminada_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "Código:";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.BackColor = System.Drawing.Color.DarkGray;
            this.txt_Codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Codigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo.ForeColor = System.Drawing.Color.White;
            this.txt_Codigo.Location = new System.Drawing.Point(99, 282);
            this.txt_Codigo.MaxLength = 8;
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.ShortcutsEnabled = false;
            this.txt_Codigo.Size = new System.Drawing.Size(150, 23);
            this.txt_Codigo.TabIndex = 46;
            this.txt_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Codigo_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "Contraseña:";
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.DarkGray;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.Color.White;
            this.txt_Password.Location = new System.Drawing.Point(117, 210);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(378, 23);
            this.txt_Password.TabIndex = 44;
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Email:";
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.DarkGray;
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Email.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.ForeColor = System.Drawing.Color.White;
            this.txt_Email.Location = new System.Drawing.Point(85, 153);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(410, 23);
            this.txt_Email.TabIndex = 42;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Usuario:";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.BackColor = System.Drawing.Color.DarkGray;
            this.txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Usuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario.ForeColor = System.Drawing.Color.White;
            this.txt_Usuario.Location = new System.Drawing.Point(85, 118);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(410, 23);
            this.txt_Usuario.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Tipo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Apellidos: ";
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.BackColor = System.Drawing.Color.DarkGray;
            this.txt_Apellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Apellidos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellidos.ForeColor = System.Drawing.Color.White;
            this.txt_Apellidos.Location = new System.Drawing.Point(345, 46);
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.ShortcutsEnabled = false;
            this.txt_Apellidos.Size = new System.Drawing.Size(150, 23);
            this.txt_Apellidos.TabIndex = 34;
            this.txt_Apellidos.TextChanged += new System.EventHandler(this.txt_Nombres_TextChanged);
            this.txt_Apellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombres_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(429, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 38);
            this.button2.TabIndex = 33;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(310, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 38);
            this.button1.TabIndex = 31;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nombres:";
            // 
            // txt_Nombres
            // 
            this.txt_Nombres.AllowDrop = true;
            this.txt_Nombres.BackColor = System.Drawing.Color.DarkGray;
            this.txt_Nombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nombres.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombres.ForeColor = System.Drawing.Color.White;
            this.txt_Nombres.Location = new System.Drawing.Point(99, 47);
            this.txt_Nombres.Name = "txt_Nombres";
            this.txt_Nombres.ShortcutsEnabled = false;
            this.txt_Nombres.Size = new System.Drawing.Size(150, 23);
            this.txt_Nombres.TabIndex = 30;
            this.txt_Nombres.TextChanged += new System.EventHandler(this.txt_Nombres_TextChanged);
            this.txt_Nombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombres_KeyPress);
            // 
            // barra
            // 
            this.barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.barra.Controls.Add(this.label9);
            this.barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra.Location = new System.Drawing.Point(0, 0);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(546, 30);
            this.barra.TabIndex = 17;
            this.barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barra_MouseDown);
            // 
            // lblEmailValidacion
            // 
            this.lblEmailValidacion.AutoSize = true;
            this.lblEmailValidacion.ForeColor = System.Drawing.Color.Red;
            this.lblEmailValidacion.Location = new System.Drawing.Point(23, 184);
            this.lblEmailValidacion.Name = "lblEmailValidacion";
            this.lblEmailValidacion.Size = new System.Drawing.Size(0, 17);
            this.lblEmailValidacion.TabIndex = 53;
            // 
            // lblValidacionClave
            // 
            this.lblValidacionClave.AutoSize = true;
            this.lblValidacionClave.ForeColor = System.Drawing.Color.Red;
            this.lblValidacionClave.Location = new System.Drawing.Point(23, 255);
            this.lblValidacionClave.Name = "lblValidacionClave";
            this.lblValidacionClave.Size = new System.Drawing.Size(0, 17);
            this.lblValidacionClave.TabIndex = 54;
            // 
            // usuario_editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(548, 333);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "usuario_editar";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "editar_usuario";
            this.Load += new System.EventHandler(this.editar_usuario_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.barra.ResumeLayout(false);
            this.barra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txt_Id;
        public System.Windows.Forms.ComboBox cbx_Estado;
        public System.Windows.Forms.ComboBox cbx_Tipo;
        private System.Windows.Forms.LinkLabel linkClavePredeterminada;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_Apellidos;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_Nombres;
        private System.Windows.Forms.Panel barra;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.Label lblMostrarClave;
        private System.Windows.Forms.Label lblValidacionClave;
        private System.Windows.Forms.Label lblEmailValidacion;
    }
}