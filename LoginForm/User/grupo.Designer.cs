namespace LoginForm.User
{
    partial class grupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(grupo));
            this.lsArriba = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lsAbajo = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lblBusqueda2 = new System.Windows.Forms.Label();
            this.btnRetorno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlNombre = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.barra = new System.Windows.Forms.Panel();
            this.pnlDescripcion = new System.Windows.Forms.Panel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.clbUsuarios = new System.Windows.Forms.CheckedListBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.pnlBuscar.SuspendLayout();
            this.pnlNombre.SuspendLayout();
            this.barra.SuspendLayout();
            this.pnlDescripcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsArriba
            // 
            this.lsArriba.BorderColor = System.Drawing.Color.Silver;
            this.lsArriba.Name = "lsArriba";
            this.lsArriba.SelectionColor = System.Drawing.Color.Silver;
            this.lsArriba.X1 = 15;
            this.lsArriba.X2 = 620;
            this.lsArriba.Y1 = 45;
            this.lsArriba.Y2 = 45;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lsAbajo,
            this.lsArriba});
            this.shapeContainer2.Size = new System.Drawing.Size(635, 683);
            this.shapeContainer2.TabIndex = 24;
            this.shapeContainer2.TabStop = false;
            // 
            // lsAbajo
            // 
            this.lsAbajo.BorderColor = System.Drawing.Color.Silver;
            this.lsAbajo.Name = "lsAbajo";
            this.lsAbajo.SelectionColor = System.Drawing.Color.Silver;
            this.lsAbajo.X1 = 15;
            this.lsAbajo.X2 = 620;
            this.lsAbajo.Y1 = 630;
            this.lsAbajo.Y2 = 630;
            // 
            // lblBusqueda2
            // 
            this.lblBusqueda2.BackColor = System.Drawing.Color.Transparent;
            this.lblBusqueda2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBusqueda2.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 15.75F);
            this.lblBusqueda2.ForeColor = System.Drawing.Color.Silver;
            this.lblBusqueda2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBusqueda2.Location = new System.Drawing.Point(3, 9);
            this.lblBusqueda2.Name = "lblBusqueda2";
            this.lblBusqueda2.Size = new System.Drawing.Size(25, 25);
            this.lblBusqueda2.TabIndex = 25;
            this.lblBusqueda2.Text = "";
            // 
            // btnRetorno
            // 
            this.btnRetorno.FlatAppearance.BorderSize = 0;
            this.btnRetorno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRetorno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetorno.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20F, System.Drawing.FontStyle.Bold);
            this.btnRetorno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
            this.btnRetorno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRetorno.Location = new System.Drawing.Point(8, 4);
            this.btnRetorno.Name = "btnRetorno";
            this.btnRetorno.Size = new System.Drawing.Size(42, 38);
            this.btnRetorno.TabIndex = 0;
            this.btnRetorno.Text = "";
            this.btnRetorno.UseVisualStyleBackColor = true;
            this.btnRetorno.Click += new System.EventHandler(this.btnRetorno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Crear un nuevo grupo de conversación";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barra_MouseDown);
            // 
            // pbxFoto
            // 
            this.pbxFoto.BackColor = System.Drawing.Color.White;
            this.pbxFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbxFoto.Image")));
            this.pbxFoto.Location = new System.Drawing.Point(49, 70);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(172, 163);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFoto.TabIndex = 27;
            this.pbxFoto.TabStop = false;
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.BackColor = System.Drawing.Color.White;
            this.pnlBuscar.Controls.Add(this.txtBuscar);
            this.pnlBuscar.Controls.Add(this.lblBusqueda2);
            this.pnlBuscar.Location = new System.Drawing.Point(49, 253);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(534, 40);
            this.pnlBuscar.TabIndex = 28;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(34, 11);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(495, 19);
            this.txtBuscar.TabIndex = 26;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 7);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nombre:";
            // 
            // pnlNombre
            // 
            this.pnlNombre.BackColor = System.Drawing.Color.White;
            this.pnlNombre.Controls.Add(this.txtNombre);
            this.pnlNombre.Controls.Add(this.label2);
            this.pnlNombre.Location = new System.Drawing.Point(251, 70);
            this.pnlNombre.Name = "pnlNombre";
            this.pnlNombre.Size = new System.Drawing.Size(332, 33);
            this.pnlNombre.TabIndex = 31;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(84, 8);
            this.txtNombre.MaxLength = 25;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(243, 19);
            this.txtNombre.TabIndex = 26;
            // 
            // barra
            // 
            this.barra.Controls.Add(this.btnRetorno);
            this.barra.Controls.Add(this.label1);
            this.barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra.Location = new System.Drawing.Point(0, 0);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(635, 44);
            this.barra.TabIndex = 32;
            this.barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barra_MouseDown);
            // 
            // pnlDescripcion
            // 
            this.pnlDescripcion.BackColor = System.Drawing.Color.White;
            this.pnlDescripcion.Controls.Add(this.txtDescripcion);
            this.pnlDescripcion.Controls.Add(this.label3);
            this.pnlDescripcion.Location = new System.Drawing.Point(251, 126);
            this.pnlDescripcion.Name = "pnlDescripcion";
            this.pnlDescripcion.Size = new System.Drawing.Size(332, 107);
            this.pnlDescripcion.TabIndex = 32;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(6, 30);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ShortcutsEnabled = false;
            this.txtDescripcion.Size = new System.Drawing.Size(321, 74);
            this.txtDescripcion.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 7);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Descripción:";
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(240)))));
            this.btnCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(182, 642);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(156, 32);
            this.btnCrear.TabIndex = 33;
            this.btnCrear.Text = "Crear conversación";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(344, 642);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 32);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnRetorno_Click);
            // 
            // clbUsuarios
            // 
            this.clbUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbUsuarios.CheckOnClick = true;
            this.clbUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbUsuarios.FormattingEnabled = true;
            this.clbUsuarios.Location = new System.Drawing.Point(49, 312);
            this.clbUsuarios.Name = "clbUsuarios";
            this.clbUsuarios.Size = new System.Drawing.Size(534, 288);
            this.clbUsuarios.Sorted = true;
            this.clbUsuarios.TabIndex = 38;
            this.clbUsuarios.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbUsuarios_ItemCheck);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Red;
            this.lblDescripcion.Location = new System.Drawing.Point(254, 236);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDescripcion.Size = new System.Drawing.Size(0, 16);
            this.lblDescripcion.TabIndex = 36;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Red;
            this.lblNombre.Location = new System.Drawing.Point(254, 107);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNombre.Size = new System.Drawing.Size(0, 16);
            this.lblNombre.TabIndex = 37;
            // 
            // grupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(635, 683);
            this.ControlBox = false;
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.clbUsuarios);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.pnlDescripcion);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.pnlNombre);
            this.Controls.Add(this.pnlBuscar);
            this.Controls.Add(this.pbxFoto);
            this.Controls.Add(this.shapeContainer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "grupo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "grupo";
            this.Load += new System.EventHandler(this.grupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            this.pnlNombre.ResumeLayout(false);
            this.pnlNombre.PerformLayout();
            this.barra.ResumeLayout(false);
            this.barra.PerformLayout();
            this.pnlDescripcion.ResumeLayout(false);
            this.pnlDescripcion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.VisualBasic.PowerPacks.LineShape lsArriba;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lsAbajo;
        private System.Windows.Forms.Label lblBusqueda2;
        private System.Windows.Forms.Button btnRetorno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel barra;
        private System.Windows.Forms.Panel pnlDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckedListBox clbUsuarios;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
    }
}