namespace LoginForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.login = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblIconLock = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblIconUser = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.recovery = new System.Windows.Forms.Panel();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.lblContraseñaConfirmacion = new System.Windows.Forms.Label();
            this.lblRepite = new System.Windows.Forms.Label();
            this.pnlContra = new System.Windows.Forms.Panel();
            this.txtContrarep = new System.Windows.Forms.TextBox();
            this.lblIcon2 = new System.Windows.Forms.Label();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.lblEmailValidacion = new System.Windows.Forms.Label();
            this.btnCancelRecovery = new System.Windows.Forms.Button();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.btnSendRec = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblIcon = new System.Windows.Forms.Label();
            this.barra = new LoginForm.GradientPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new LoginForm.GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblIconGroup = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIconFolder = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIconSend = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.recovery.SuspendLayout();
            this.pnlContra.SuspendLayout();
            this.panel6.SuspendLayout();
            this.barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.White;
            this.login.Controls.Add(this.linkLabel1);
            this.login.Controls.Add(this.label11);
            this.login.Controls.Add(this.btnIngresar);
            this.login.Controls.Add(this.panel1);
            this.login.Controls.Add(this.button1);
            this.login.Location = new System.Drawing.Point(680, 30);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(320, 520);
            this.login.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.AppWorkspace;
            this.linkLabel1.Location = new System.Drawing.Point(22, 323);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(221, 23);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Recuperar Contraseña";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 23);
            this.label11.TabIndex = 3;
            this.label11.Text = "Ingresa tus datos";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIngresar.Location = new System.Drawing.Point(22, 261);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(268, 42);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.lblIconLock);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.lblIconUser);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Location = new System.Drawing.Point(22, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 100);
            this.panel1.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(47, 65);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(216, 23);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // lblIconLock
            // 
            this.lblIconLock.AutoSize = true;
            this.lblIconLock.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconLock.Location = new System.Drawing.Point(3, 65);
            this.lblIconLock.Name = "lblIconLock";
            this.lblIconLock.Size = new System.Drawing.Size(26, 20);
            this.lblIconLock.TabIndex = 2;
            this.lblIconLock.Text = "";
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Location = new System.Drawing.Point(47, 10);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(216, 23);
            this.txtUser.TabIndex = 1;
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // lblIconUser
            // 
            this.lblIconUser.AutoSize = true;
            this.lblIconUser.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconUser.Location = new System.Drawing.Point(3, 10);
            this.lblIconUser.Name = "lblIconUser";
            this.lblIconUser.Size = new System.Drawing.Size(26, 20);
            this.lblIconUser.TabIndex = 0;
            this.lblIconUser.Text = "";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(266, 98);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 268;
            this.lineShape1.Y1 = 48;
            this.lineShape1.Y2 = 48;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(173)))), ((int)(((byte)(188)))));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Work Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 394);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 126);
            this.button1.TabIndex = 0;
            this.button1.Text = "Consigue Pluzedu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.barra);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(1);
            this.panel4.Size = new System.Drawing.Size(1000, 30);
            this.panel4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnMin);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(680, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 30);
            this.panel3.TabIndex = 48;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barra_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(290, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 46;
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
            this.btnMin.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(260, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 30);
            this.btnMin.TabIndex = 47;
            this.btnMin.Text = "";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(940, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 45;
            this.button2.Text = "";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(970, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 44;
            this.button3.Text = "";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // recovery
            // 
            this.recovery.BackColor = System.Drawing.Color.White;
            this.recovery.Controls.Add(this.btnCambiar);
            this.recovery.Controls.Add(this.lblContraseñaConfirmacion);
            this.recovery.Controls.Add(this.lblRepite);
            this.recovery.Controls.Add(this.pnlContra);
            this.recovery.Controls.Add(this.btnComprobar);
            this.recovery.Controls.Add(this.lblEmailValidacion);
            this.recovery.Controls.Add(this.btnCancelRecovery);
            this.recovery.Controls.Add(this.lblCorreo);
            this.recovery.Controls.Add(this.btnSendRec);
            this.recovery.Controls.Add(this.panel6);
            this.recovery.Location = new System.Drawing.Point(655, 30);
            this.recovery.Name = "recovery";
            this.recovery.Size = new System.Drawing.Size(345, 520);
            this.recovery.TabIndex = 5;
            this.recovery.Visible = false;
            // 
            // btnCambiar
            // 
            this.btnCambiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.btnCambiar.FlatAppearance.BorderSize = 0;
            this.btnCambiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.btnCambiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
            this.btnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCambiar.Location = new System.Drawing.Point(209, 380);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(99, 35);
            this.btnCambiar.TabIndex = 47;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = false;
            this.btnCambiar.Visible = false;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // lblContraseñaConfirmacion
            // 
            this.lblContraseñaConfirmacion.AutoSize = true;
            this.lblContraseñaConfirmacion.Font = new System.Drawing.Font("Work Sans", 12.25F);
            this.lblContraseñaConfirmacion.ForeColor = System.Drawing.Color.Red;
            this.lblContraseñaConfirmacion.Location = new System.Drawing.Point(32, 352);
            this.lblContraseñaConfirmacion.Name = "lblContraseñaConfirmacion";
            this.lblContraseñaConfirmacion.Size = new System.Drawing.Size(0, 20);
            this.lblContraseñaConfirmacion.TabIndex = 46;
            this.lblContraseñaConfirmacion.Visible = false;
            // 
            // lblRepite
            // 
            this.lblRepite.AutoSize = true;
            this.lblRepite.Location = new System.Drawing.Point(35, 271);
            this.lblRepite.Name = "lblRepite";
            this.lblRepite.Size = new System.Drawing.Size(220, 23);
            this.lblRepite.TabIndex = 45;
            this.lblRepite.Text = "Repite tu contraseña: ";
            this.lblRepite.Visible = false;
            // 
            // pnlContra
            // 
            this.pnlContra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContra.Controls.Add(this.txtContrarep);
            this.pnlContra.Controls.Add(this.lblIcon2);
            this.pnlContra.Location = new System.Drawing.Point(32, 297);
            this.pnlContra.Name = "pnlContra";
            this.pnlContra.Size = new System.Drawing.Size(286, 46);
            this.pnlContra.TabIndex = 44;
            this.pnlContra.Visible = false;
            // 
            // txtContrarep
            // 
            this.txtContrarep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrarep.Location = new System.Drawing.Point(35, 10);
            this.txtContrarep.Name = "txtContrarep";
            this.txtContrarep.Size = new System.Drawing.Size(228, 23);
            this.txtContrarep.TabIndex = 1;
            this.txtContrarep.Visible = false;
            // 
            // lblIcon2
            // 
            this.lblIcon2.AutoSize = true;
            this.lblIcon2.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon2.Location = new System.Drawing.Point(3, 13);
            this.lblIcon2.Name = "lblIcon2";
            this.lblIcon2.Size = new System.Drawing.Size(26, 20);
            this.lblIcon2.TabIndex = 0;
            this.lblIcon2.Text = "";
            // 
            // btnComprobar
            // 
            this.btnComprobar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.btnComprobar.FlatAppearance.BorderSize = 0;
            this.btnComprobar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.btnComprobar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
            this.btnComprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprobar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnComprobar.Location = new System.Drawing.Point(183, 323);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(125, 35);
            this.btnComprobar.TabIndex = 43;
            this.btnComprobar.Text = "Comprobar";
            this.btnComprobar.UseVisualStyleBackColor = false;
            this.btnComprobar.Visible = false;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // lblEmailValidacion
            // 
            this.lblEmailValidacion.AutoSize = true;
            this.lblEmailValidacion.Font = new System.Drawing.Font("Work Sans", 12.25F);
            this.lblEmailValidacion.ForeColor = System.Drawing.Color.Red;
            this.lblEmailValidacion.Location = new System.Drawing.Point(32, 250);
            this.lblEmailValidacion.Name = "lblEmailValidacion";
            this.lblEmailValidacion.Size = new System.Drawing.Size(0, 20);
            this.lblEmailValidacion.TabIndex = 42;
            // 
            // btnCancelRecovery
            // 
            this.btnCancelRecovery.BackColor = System.Drawing.Color.Gray;
            this.btnCancelRecovery.FlatAppearance.BorderSize = 0;
            this.btnCancelRecovery.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancelRecovery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCancelRecovery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelRecovery.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelRecovery.Location = new System.Drawing.Point(81, 282);
            this.btnCancelRecovery.Name = "btnCancelRecovery";
            this.btnCancelRecovery.Size = new System.Drawing.Size(122, 35);
            this.btnCancelRecovery.TabIndex = 5;
            this.btnCancelRecovery.Text = "Cancelar";
            this.btnCancelRecovery.UseVisualStyleBackColor = false;
            this.btnCancelRecovery.Click += new System.EventHandler(this.btnCancelRecovery_Click);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(30, 169);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(291, 23);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "Ingresa tu correo eléctronico:";
            // 
            // btnSendRec
            // 
            this.btnSendRec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.btnSendRec.FlatAppearance.BorderSize = 0;
            this.btnSendRec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.btnSendRec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
            this.btnSendRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendRec.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSendRec.Location = new System.Drawing.Point(209, 282);
            this.btnSendRec.Name = "btnSendRec";
            this.btnSendRec.Size = new System.Drawing.Size(99, 35);
            this.btnSendRec.TabIndex = 2;
            this.btnSendRec.Text = "Enviar";
            this.btnSendRec.UseVisualStyleBackColor = false;
            this.btnSendRec.Click += new System.EventHandler(this.btnSendRec_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.txtCorreo);
            this.panel6.Controls.Add(this.lblIcon);
            this.panel6.Location = new System.Drawing.Point(34, 195);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(284, 46);
            this.panel6.TabIndex = 1;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Location = new System.Drawing.Point(35, 10);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(228, 23);
            this.txtCorreo.TabIndex = 1;
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon.Location = new System.Drawing.Point(3, 13);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(28, 20);
            this.lblIcon.TabIndex = 0;
            this.lblIcon.Text = "";
            // 
            // barra
            // 
            this.barra.ColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.barra.ColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
            this.barra.Controls.Add(this.pictureBox2);
            this.barra.Controls.Add(this.label1);
            this.barra.Controls.Add(this.label3);
            this.barra.Location = new System.Drawing.Point(0, 0);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(680, 30);
            this.barra.TabIndex = 9;
            this.barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barra_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barra_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "|";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barra_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 49;
            this.label3.Text = "Pluzedu";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barra_MouseDown);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.gradientPanel1.ColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Controls.Add(this.label7);
            this.gradientPanel1.Controls.Add(this.lblIconGroup);
            this.gradientPanel1.Controls.Add(this.label5);
            this.gradientPanel1.Controls.Add(this.lblIconFolder);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Controls.Add(this.lblIconSend);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Location = new System.Drawing.Point(0, 30);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(680, 520);
            this.gradientPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 86);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Work Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(84, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Crea grupos";
            // 
            // lblIconGroup
            // 
            this.lblIconGroup.AutoSize = true;
            this.lblIconGroup.BackColor = System.Drawing.Color.Transparent;
            this.lblIconGroup.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconGroup.ForeColor = System.Drawing.Color.White;
            this.lblIconGroup.Location = new System.Drawing.Point(50, 405);
            this.lblIconGroup.Name = "lblIconGroup";
            this.lblIconGroup.Size = new System.Drawing.Size(33, 20);
            this.lblIconGroup.TabIndex = 7;
            this.lblIconGroup.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Work Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(84, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Envía toda clase de archivos";
            // 
            // lblIconFolder
            // 
            this.lblIconFolder.AutoSize = true;
            this.lblIconFolder.BackColor = System.Drawing.Color.Transparent;
            this.lblIconFolder.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconFolder.ForeColor = System.Drawing.Color.White;
            this.lblIconFolder.Location = new System.Drawing.Point(50, 355);
            this.lblIconFolder.Name = "lblIconFolder";
            this.lblIconFolder.Size = new System.Drawing.Size(28, 20);
            this.lblIconFolder.TabIndex = 5;
            this.lblIconFolder.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Work Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(84, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(433, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Comunicate con tus compañeros y maestros";
            // 
            // lblIconSend
            // 
            this.lblIconSend.AutoSize = true;
            this.lblIconSend.BackColor = System.Drawing.Color.Transparent;
            this.lblIconSend.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconSend.ForeColor = System.Drawing.Color.White;
            this.lblIconSend.Location = new System.Drawing.Point(50, 305);
            this.lblIconSend.Name = "lblIconSend";
            this.lblIconSend.Size = new System.Drawing.Size(28, 20);
            this.lblIconSend.TabIndex = 3;
            this.lblIconSend.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Work Sans Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(498, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comunicación para la educación hecha simple.";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.recovery);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.login);
            this.Controls.Add(this.gradientPanel1);
            this.Font = new System.Drawing.Font("Work Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesión";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.login.ResumeLayout(false);
            this.login.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.recovery.ResumeLayout(false);
            this.recovery.PerformLayout();
            this.pnlContra.ResumeLayout(false);
            this.pnlContra.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.barra.ResumeLayout(false);
            this.barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label lblIconSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIconFolder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblIconGroup;
        private System.Windows.Forms.Panel login;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblIconUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblIconLock;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnIngresar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private GradientPanel barra;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel recovery;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Button btnSendRec;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Button btnCancelRecovery;
        private System.Windows.Forms.Label lblEmailValidacion;
        private System.Windows.Forms.Button btnComprobar;
        private System.Windows.Forms.Label lblContraseñaConfirmacion;
        private System.Windows.Forms.Label lblRepite;
        private System.Windows.Forms.Panel pnlContra;
        private System.Windows.Forms.TextBox txtContrarep;
        private System.Windows.Forms.Label lblIcon2;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

