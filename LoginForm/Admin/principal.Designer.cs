namespace LoginForm.Admin
{
    partial class principal
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
            this.pnlNiveles = new System.Windows.Forms.Panel();
            this.lblIconAward = new System.Windows.Forms.Label();
            this.lblNiveles = new System.Windows.Forms.Label();
            this.pnlEstudiantes = new System.Windows.Forms.Panel();
            this.lblEstudiantes = new System.Windows.Forms.Label();
            this.lblIIconUserGraduate = new System.Windows.Forms.Label();
            this.pnlMaestros = new System.Windows.Forms.Panel();
            this.lblMaestros = new System.Windows.Forms.Label();
            this.lblIconChalkboardTeacher = new System.Windows.Forms.Label();
            this.pnlAdministradores = new System.Windows.Forms.Panel();
            this.lblIconUser = new System.Windows.Forms.Label();
            this.lblAdmins = new System.Windows.Forms.Label();
            this.pnlGraficas = new System.Windows.Forms.Panel();
            this.lblconChart = new System.Windows.Forms.Label();
            this.lblChart = new System.Windows.Forms.Label();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.pnlNiveles.SuspendLayout();
            this.pnlEstudiantes.SuspendLayout();
            this.pnlMaestros.SuspendLayout();
            this.pnlAdministradores.SuspendLayout();
            this.pnlGraficas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNiveles
            // 
            this.pnlNiveles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.pnlNiveles.Controls.Add(this.lblIconAward);
            this.pnlNiveles.Controls.Add(this.lblNiveles);
            this.pnlNiveles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlNiveles.ForeColor = System.Drawing.Color.White;
            this.pnlNiveles.Location = new System.Drawing.Point(100, 24);
            this.pnlNiveles.Name = "pnlNiveles";
            this.pnlNiveles.Size = new System.Drawing.Size(200, 200);
            this.pnlNiveles.TabIndex = 0;
            this.pnlNiveles.Click += new System.EventHandler(this.pnlNiveles_Click);
            this.pnlNiveles.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.pnlNiveles.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // lblIconAward
            // 
            this.lblIconAward.AutoSize = true;
            this.lblIconAward.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconAward.Location = new System.Drawing.Point(55, 45);
            this.lblIconAward.Name = "lblIconAward";
            this.lblIconAward.Size = new System.Drawing.Size(95, 83);
            this.lblIconAward.TabIndex = 1;
            this.lblIconAward.Text = "";
            this.lblIconAward.Click += new System.EventHandler(this.pnlNiveles_Click);
            this.lblIconAward.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.lblIconAward.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // lblNiveles
            // 
            this.lblNiveles.AutoSize = true;
            this.lblNiveles.Location = new System.Drawing.Point(68, 160);
            this.lblNiveles.Name = "lblNiveles";
            this.lblNiveles.Size = new System.Drawing.Size(59, 20);
            this.lblNiveles.TabIndex = 0;
            this.lblNiveles.Text = "Niveles";
            this.lblNiveles.Click += new System.EventHandler(this.pnlNiveles_Click);
            this.lblNiveles.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.lblNiveles.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // pnlEstudiantes
            // 
            this.pnlEstudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.pnlEstudiantes.Controls.Add(this.lblEstudiantes);
            this.pnlEstudiantes.Controls.Add(this.lblIIconUserGraduate);
            this.pnlEstudiantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlEstudiantes.ForeColor = System.Drawing.Color.White;
            this.pnlEstudiantes.Location = new System.Drawing.Point(365, 24);
            this.pnlEstudiantes.Name = "pnlEstudiantes";
            this.pnlEstudiantes.Size = new System.Drawing.Size(200, 200);
            this.pnlEstudiantes.TabIndex = 1;
            this.pnlEstudiantes.Click += new System.EventHandler(this.pnlEstudiantes_Click);
            this.pnlEstudiantes.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEstudiantes_Paint);
            this.pnlEstudiantes.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.pnlEstudiantes.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // lblEstudiantes
            // 
            this.lblEstudiantes.AutoSize = true;
            this.lblEstudiantes.Location = new System.Drawing.Point(49, 160);
            this.lblEstudiantes.Name = "lblEstudiantes";
            this.lblEstudiantes.Size = new System.Drawing.Size(94, 20);
            this.lblEstudiantes.TabIndex = 2;
            this.lblEstudiantes.Text = "Estudiantes";
            this.lblEstudiantes.Click += new System.EventHandler(this.pnlEstudiantes_Click);
            this.lblEstudiantes.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.lblEstudiantes.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // lblIIconUserGraduate
            // 
            this.lblIIconUserGraduate.AutoSize = true;
            this.lblIIconUserGraduate.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIIconUserGraduate.Location = new System.Drawing.Point(50, 45);
            this.lblIIconUserGraduate.Name = "lblIIconUserGraduate";
            this.lblIIconUserGraduate.Size = new System.Drawing.Size(105, 83);
            this.lblIIconUserGraduate.TabIndex = 3;
            this.lblIIconUserGraduate.Text = "";
            this.lblIIconUserGraduate.Click += new System.EventHandler(this.pnlEstudiantes_Click);
            this.lblIIconUserGraduate.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.lblIIconUserGraduate.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // pnlMaestros
            // 
            this.pnlMaestros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.pnlMaestros.Controls.Add(this.lblMaestros);
            this.pnlMaestros.Controls.Add(this.lblIconChalkboardTeacher);
            this.pnlMaestros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMaestros.ForeColor = System.Drawing.Color.White;
            this.pnlMaestros.Location = new System.Drawing.Point(630, 24);
            this.pnlMaestros.Name = "pnlMaestros";
            this.pnlMaestros.Size = new System.Drawing.Size(200, 200);
            this.pnlMaestros.TabIndex = 2;
            this.pnlMaestros.Click += new System.EventHandler(this.pnlMaestros_Click);
            this.pnlMaestros.MouseEnter += new System.EventHandler(this.pnlMaestros_MouseEnter);
            this.pnlMaestros.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            // 
            // lblMaestros
            // 
            this.lblMaestros.AutoSize = true;
            this.lblMaestros.Location = new System.Drawing.Point(61, 160);
            this.lblMaestros.Name = "lblMaestros";
            this.lblMaestros.Size = new System.Drawing.Size(75, 20);
            this.lblMaestros.TabIndex = 4;
            this.lblMaestros.Text = "Maestros";
            this.lblMaestros.Click += new System.EventHandler(this.pnlMaestros_Click);
            this.lblMaestros.MouseEnter += new System.EventHandler(this.pnlMaestros_MouseEnter);
            this.lblMaestros.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            // 
            // lblIconChalkboardTeacher
            // 
            this.lblIconChalkboardTeacher.AutoSize = true;
            this.lblIconChalkboardTeacher.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconChalkboardTeacher.Location = new System.Drawing.Point(35, 45);
            this.lblIconChalkboardTeacher.Name = "lblIconChalkboardTeacher";
            this.lblIconChalkboardTeacher.Size = new System.Drawing.Size(135, 83);
            this.lblIconChalkboardTeacher.TabIndex = 5;
            this.lblIconChalkboardTeacher.Text = "";
            this.lblIconChalkboardTeacher.Click += new System.EventHandler(this.pnlMaestros_Click);
            this.lblIconChalkboardTeacher.MouseEnter += new System.EventHandler(this.pnlMaestros_MouseEnter);
            this.lblIconChalkboardTeacher.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            // 
            // pnlAdministradores
            // 
            this.pnlAdministradores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.pnlAdministradores.Controls.Add(this.lblIconUser);
            this.pnlAdministradores.Controls.Add(this.lblAdmins);
            this.pnlAdministradores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlAdministradores.ForeColor = System.Drawing.Color.White;
            this.pnlAdministradores.Location = new System.Drawing.Point(100, 275);
            this.pnlAdministradores.Name = "pnlAdministradores";
            this.pnlAdministradores.Size = new System.Drawing.Size(200, 200);
            this.pnlAdministradores.TabIndex = 1;
            this.pnlAdministradores.Click += new System.EventHandler(this.pnlAdministradores_Click);
            this.pnlAdministradores.MouseEnter += new System.EventHandler(this.pnlAdministradores_MouseEnter);
            this.pnlAdministradores.MouseLeave += new System.EventHandler(this.label8_MouseLeave);
            // 
            // lblIconUser
            // 
            this.lblIconUser.AutoSize = true;
            this.lblIconUser.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconUser.Location = new System.Drawing.Point(50, 45);
            this.lblIconUser.Name = "lblIconUser";
            this.lblIconUser.Size = new System.Drawing.Size(105, 83);
            this.lblIconUser.TabIndex = 7;
            this.lblIconUser.Text = "";
            this.lblIconUser.Click += new System.EventHandler(this.pnlAdministradores_Click);
            this.lblIconUser.MouseEnter += new System.EventHandler(this.pnlAdministradores_MouseEnter);
            this.lblIconUser.MouseLeave += new System.EventHandler(this.label8_MouseLeave);
            // 
            // lblAdmins
            // 
            this.lblAdmins.AutoSize = true;
            this.lblAdmins.Location = new System.Drawing.Point(32, 151);
            this.lblAdmins.Name = "lblAdmins";
            this.lblAdmins.Size = new System.Drawing.Size(124, 20);
            this.lblAdmins.TabIndex = 6;
            this.lblAdmins.Text = "Administradores";
            this.lblAdmins.Click += new System.EventHandler(this.pnlAdministradores_Click);
            this.lblAdmins.MouseEnter += new System.EventHandler(this.pnlAdministradores_MouseEnter);
            this.lblAdmins.MouseLeave += new System.EventHandler(this.label8_MouseLeave);
            // 
            // pnlGraficas
            // 
            this.pnlGraficas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.pnlGraficas.Controls.Add(this.lblconChart);
            this.pnlGraficas.Controls.Add(this.lblChart);
            this.pnlGraficas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlGraficas.ForeColor = System.Drawing.Color.White;
            this.pnlGraficas.Location = new System.Drawing.Point(365, 275);
            this.pnlGraficas.Name = "pnlGraficas";
            this.pnlGraficas.Size = new System.Drawing.Size(200, 200);
            this.pnlGraficas.TabIndex = 8;
            this.pnlGraficas.Click += new System.EventHandler(this.pnlGraficas_Click);
            // 
            // lblconChart
            // 
            this.lblconChart.AutoSize = true;
            this.lblconChart.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconChart.Location = new System.Drawing.Point(50, 45);
            this.lblconChart.Name = "lblconChart";
            this.lblconChart.Size = new System.Drawing.Size(115, 83);
            this.lblconChart.TabIndex = 7;
            this.lblconChart.Text = "";
            this.lblconChart.Click += new System.EventHandler(this.lblconChart_Click);
            // 
            // lblChart
            // 
            this.lblChart.AutoSize = true;
            this.lblChart.Location = new System.Drawing.Point(63, 151);
            this.lblChart.Name = "lblChart";
            this.lblChart.Size = new System.Drawing.Size(69, 20);
            this.lblChart.TabIndex = 6;
            this.lblChart.Text = "Gráficas";
            this.lblChart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChart.Click += new System.EventHandler(this.lblconChart_Click);
            // 
            // principal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(920, 520);
            this.Controls.Add(this.pnlGraficas);
            this.Controls.Add(this.pnlAdministradores);
            this.Controls.Add(this.pnlMaestros);
            this.Controls.Add(this.pnlEstudiantes);
            this.Controls.Add(this.pnlNiveles);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "principal";
            this.Text = "principal";
            this.Load += new System.EventHandler(this.principal_Load);
            this.pnlNiveles.ResumeLayout(false);
            this.pnlNiveles.PerformLayout();
            this.pnlEstudiantes.ResumeLayout(false);
            this.pnlEstudiantes.PerformLayout();
            this.pnlMaestros.ResumeLayout(false);
            this.pnlMaestros.PerformLayout();
            this.pnlAdministradores.ResumeLayout(false);
            this.pnlAdministradores.PerformLayout();
            this.pnlGraficas.ResumeLayout(false);
            this.pnlGraficas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNiveles;
        private System.Windows.Forms.Label lblIconAward;
        private System.Windows.Forms.Label lblNiveles;
        private System.Windows.Forms.Panel pnlEstudiantes;
        private System.Windows.Forms.Label lblIIconUserGraduate;
        private System.Windows.Forms.Panel pnlMaestros;
        private System.Windows.Forms.Panel pnlAdministradores;
        private System.Windows.Forms.Label lblEstudiantes;
        private System.Windows.Forms.Label lblMaestros;
        private System.Windows.Forms.Label lblIconChalkboardTeacher;
        private System.Windows.Forms.Label lblIconUser;
        private System.Windows.Forms.Label lblAdmins;
        private System.Windows.Forms.Panel pnlGraficas;
        private System.Windows.Forms.Label lblconChart;
        private System.Windows.Forms.Label lblChart;
        private System.Windows.Forms.ToolTip ttMensaje;
    }
}