﻿namespace LoginForm.Admin
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.barra = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pnlNav = new LoginForm.GradientUpBottom();
            this.cpbxFoto = new LoginForm.circlepbx();
            this.btnNivel = new System.Windows.Forms.Button();
            this.btnSignout = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnConfigurarUsuarios = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // barra
            // 
            this.barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
            this.barra.Controls.Add(this.pictureBox1);
            this.barra.Controls.Add(this.label2);
            this.barra.Controls.Add(this.label1);
            this.barra.Controls.Add(this.btnMin);
            this.barra.Controls.Add(this.btnClose);
            this.barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra.Location = new System.Drawing.Point(0, 0);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(1000, 30);
            this.barra.TabIndex = 13;
            this.barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barra_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.barra_MouseDown);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barra_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "|";
            this.label2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.barra_MouseDown);
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barra_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Pluzedu";
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.barra_MouseDown);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barra_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 12F, System.Drawing.FontStyle.Bold);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(940, 1);
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
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(970, 1);
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
            this.btnAgregar.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.pnlNav.Controls.Add(this.cpbxFoto);
            this.pnlNav.Controls.Add(this.btnNivel);
            this.pnlNav.Controls.Add(this.btnSignout);
            this.pnlNav.Controls.Add(this.btnConfiguracion);
            this.pnlNav.Controls.Add(this.btnConfigurarUsuarios);
            this.pnlNav.Controls.Add(this.btnInicio);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Location = new System.Drawing.Point(0, 30);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(80, 520);
            this.pnlNav.TabIndex = 14;
            // 
            // cpbxFoto
            // 
            this.cpbxFoto.BackColor = System.Drawing.Color.Silver;
            this.cpbxFoto.Location = new System.Drawing.Point(10, 28);
            this.cpbxFoto.Name = "cpbxFoto";
            this.cpbxFoto.Size = new System.Drawing.Size(60, 60);
            this.cpbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cpbxFoto.TabIndex = 0;
            this.cpbxFoto.TabStop = false;
            // 
            // btnNivel
            // 
            this.btnNivel.BackColor = System.Drawing.Color.Transparent;
            this.btnNivel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNivel.FlatAppearance.BorderSize = 0;
            this.btnNivel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
            this.btnNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNivel.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNivel.ForeColor = System.Drawing.Color.White;
            this.btnNivel.Location = new System.Drawing.Point(0, 193);
            this.btnNivel.Margin = new System.Windows.Forms.Padding(0);
            this.btnNivel.Name = "btnNivel";
            this.btnNivel.Size = new System.Drawing.Size(80, 60);
            this.btnNivel.TabIndex = 17;
            this.btnNivel.Text = "";
            this.btnNivel.UseVisualStyleBackColor = false;
            this.btnNivel.Click += new System.EventHandler(this.btnNivel_Click);
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
            this.btnSignout.Location = new System.Drawing.Point(0, 459);
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
            this.btnConfiguracion.Location = new System.Drawing.Point(0, 313);
            this.btnConfiguracion.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(80, 60);
            this.btnConfiguracion.TabIndex = 15;
            this.btnConfiguracion.Text = "";
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // btnConfigurarUsuarios
            // 
            this.btnConfigurarUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnConfigurarUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfigurarUsuarios.FlatAppearance.BorderSize = 0;
            this.btnConfigurarUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
            this.btnConfigurarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigurarUsuarios.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigurarUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnConfigurarUsuarios.Location = new System.Drawing.Point(0, 253);
            this.btnConfigurarUsuarios.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfigurarUsuarios.Name = "btnConfigurarUsuarios";
            this.btnConfigurarUsuarios.Size = new System.Drawing.Size(80, 60);
            this.btnConfigurarUsuarios.TabIndex = 14;
            this.btnConfigurarUsuarios.Text = "";
            this.btnConfigurarUsuarios.UseVisualStyleBackColor = false;
            this.btnConfigurarUsuarios.Click += new System.EventHandler(this.btnConfigurarUsuarios_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(0, 133);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(80, 60);
            this.btnInicio.TabIndex = 12;
            this.btnInicio.Text = "";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Niveles";
            this.Load += new System.EventHandler(this.menu_Load);
            this.barra.ResumeLayout(false);
            this.barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cpbxFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNivel;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnConfigurarUsuarios;
        private System.Windows.Forms.Button btnInicio;
        private GradientUpBottom pnlNav;
        private System.Windows.Forms.Button btnSignout;
        private System.Windows.Forms.Panel barra;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private circlepbx cpbxFoto;
    }
}