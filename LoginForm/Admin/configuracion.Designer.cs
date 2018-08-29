namespace LoginForm.Admin
{
    partial class configuracion
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
            this.txtClaveNueva = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditarClave = new System.Windows.Forms.Button();
            this.btnEditarEmail = new System.Windows.Forms.Button();
            this.txtClaveRepetir = new System.Windows.Forms.TextBox();
            this.lblRepetirClave = new System.Windows.Forms.Label();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.lblEmailValidacion = new System.Windows.Forms.Label();
            this.lblValidacionClave = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtClaveNueva
            // 
            this.txtClaveNueva.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtClaveNueva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtClaveNueva.Location = new System.Drawing.Point(464, 214);
            this.txtClaveNueva.Name = "txtClaveNueva";
            this.txtClaveNueva.ReadOnly = true;
            this.txtClaveNueva.Size = new System.Drawing.Size(346, 26);
            this.txtClaveNueva.TabIndex = 28;
            this.txtClaveNueva.Text = "Cambiar contraseña";
            this.txtClaveNueva.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtClaveNueva_KeyUp);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtEmail.Location = new System.Drawing.Point(464, 149);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(346, 26);
            this.txtEmail.TabIndex = 27;
            this.txtEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyUp);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtUsuario.Location = new System.Drawing.Point(464, 84);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(346, 26);
            this.txtUsuario.TabIndex = 26;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Work Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.Color.Black;
            this.lblClave.Location = new System.Drawing.Point(66, 214);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(124, 23);
            this.lblClave.TabIndex = 25;
            this.lblClave.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Work Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(66, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Correo Electrónico:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Work Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(66, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Usuario:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(70, 469);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 28);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditarClave
            // 
            this.btnEditarClave.FlatAppearance.BorderSize = 0;
            this.btnEditarClave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEditarClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarClave.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarClave.ForeColor = System.Drawing.Color.Black;
            this.btnEditarClave.Location = new System.Drawing.Point(813, 208);
            this.btnEditarClave.Name = "btnEditarClave";
            this.btnEditarClave.Size = new System.Drawing.Size(47, 37);
            this.btnEditarClave.TabIndex = 35;
            this.btnEditarClave.Text = "";
            this.btnEditarClave.UseVisualStyleBackColor = true;
            this.btnEditarClave.Click += new System.EventHandler(this.btnEditarClave_Click);
            // 
            // btnEditarEmail
            // 
            this.btnEditarEmail.FlatAppearance.BorderSize = 0;
            this.btnEditarEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEditarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarEmail.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEmail.ForeColor = System.Drawing.Color.Black;
            this.btnEditarEmail.Location = new System.Drawing.Point(813, 144);
            this.btnEditarEmail.Name = "btnEditarEmail";
            this.btnEditarEmail.Size = new System.Drawing.Size(47, 37);
            this.btnEditarEmail.TabIndex = 34;
            this.btnEditarEmail.Text = "";
            this.btnEditarEmail.UseVisualStyleBackColor = true;
            this.btnEditarEmail.Click += new System.EventHandler(this.btnEditarEmail_Click);
            // 
            // txtClaveRepetir
            // 
            this.txtClaveRepetir.BackColor = System.Drawing.Color.White;
            this.txtClaveRepetir.ForeColor = System.Drawing.Color.Black;
            this.txtClaveRepetir.Location = new System.Drawing.Point(464, 257);
            this.txtClaveRepetir.Name = "txtClaveRepetir";
            this.txtClaveRepetir.Size = new System.Drawing.Size(346, 26);
            this.txtClaveRepetir.TabIndex = 37;
            this.txtClaveRepetir.UseSystemPasswordChar = true;
            this.txtClaveRepetir.Visible = false;
            this.txtClaveRepetir.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtClaveRepetir_KeyUp);
            // 
            // lblRepetirClave
            // 
            this.lblRepetirClave.AutoSize = true;
            this.lblRepetirClave.Font = new System.Drawing.Font("Work Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepetirClave.ForeColor = System.Drawing.Color.Black;
            this.lblRepetirClave.Location = new System.Drawing.Point(66, 257);
            this.lblRepetirClave.Name = "lblRepetirClave";
            this.lblRepetirClave.Size = new System.Drawing.Size(198, 23);
            this.lblRepetirClave.TabIndex = 36;
            this.lblRepetirClave.Text = "Repetir Contraseña:";
            this.lblRepetirClave.Visible = false;
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.FlatAppearance.BorderSize = 0;
            this.btnEditarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarUsuario.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnEditarUsuario.Location = new System.Drawing.Point(813, 81);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(47, 37);
            this.btnEditarUsuario.TabIndex = 40;
            this.btnEditarUsuario.Text = "";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // lblEmailValidacion
            // 
            this.lblEmailValidacion.AutoSize = true;
            this.lblEmailValidacion.ForeColor = System.Drawing.Color.Red;
            this.lblEmailValidacion.Location = new System.Drawing.Point(464, 182);
            this.lblEmailValidacion.Name = "lblEmailValidacion";
            this.lblEmailValidacion.Size = new System.Drawing.Size(0, 19);
            this.lblEmailValidacion.TabIndex = 41;
            // 
            // lblValidacionClave
            // 
            this.lblValidacionClave.AutoSize = true;
            this.lblValidacionClave.ForeColor = System.Drawing.Color.Red;
            this.lblValidacionClave.Location = new System.Drawing.Point(464, 286);
            this.lblValidacionClave.Name = "lblValidacionClave";
            this.lblValidacionClave.Size = new System.Drawing.Size(0, 19);
            this.lblValidacionClave.TabIndex = 42;
            // 
            // configuracion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(920, 520);
            this.Controls.Add(this.lblValidacionClave);
            this.Controls.Add(this.lblEmailValidacion);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.txtClaveRepetir);
            this.Controls.Add(this.lblRepetirClave);
            this.Controls.Add(this.btnEditarClave);
            this.Controls.Add(this.btnEditarEmail);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtClaveNueva);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Work Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "configuracion";
            this.Text = "configuracion";
            this.Load += new System.EventHandler(this.configuracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtClaveNueva;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditarClave;
        private System.Windows.Forms.Button btnEditarEmail;
        private System.Windows.Forms.TextBox txtClaveRepetir;
        private System.Windows.Forms.Label lblRepetirClave;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Label lblEmailValidacion;
        private System.Windows.Forms.Label lblValidacionClave;
    }
}