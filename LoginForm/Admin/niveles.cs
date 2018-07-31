using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm.Admin
{
    public partial class niveles : Form
    {
        public void mostrarNiveles()
        {
            DataTable niveles = Database.funcionesCRUD.mostrarNiveles();
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < niveles.Rows.Count; i++)
            {
                int id = Convert.ToInt32(niveles.Rows[i].ItemArray[0]);
                string nombre = Convert.ToString(niveles.Rows[i].ItemArray[1]);
                Panel pnlNivel = new System.Windows.Forms.Panel();
                Label lblId = new Label();
                Label lblNombre = new Label();
                Button btnEditar = new Button();
                Button btnEliminar = new Button();
                pnlNivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
                pnlNivel.Location = new System.Drawing.Point(0 + i * 180, 0);
                pnlNivel.Margin = new System.Windows.Forms.Padding(15);
                pnlNivel.Name = "nivel" + i;
                pnlNivel.Size = new System.Drawing.Size(180, 180);
                pnlNivel.Cursor = Cursors.Hand;
                pnlNivel.TabIndex = 22 + i;

                btnEditar.BackColor = System.Drawing.Color.Transparent;
                btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
                btnEditar.FlatAppearance.BorderSize = 0;
                btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
                btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnEditar.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                btnEditar.Location = new System.Drawing.Point(135, 135);
                btnEditar.Margin = new System.Windows.Forms.Padding(0);
                btnEditar.Name = "btnEditar" + i;
                btnEditar.Size = new System.Drawing.Size(45, 45);
                btnEditar.TabIndex = 22 + i;
                btnEditar.Text = "edit";
                btnEditar.UseVisualStyleBackColor = false;

                lblNombre.AutoSize = true;
                lblNombre.Font = new System.Drawing.Font("Work Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblNombre.ForeColor = System.Drawing.Color.White;
                lblNombre.Location = new System.Drawing.Point(8, 69);
                lblNombre.Name = "lblNombre" + i;
                lblNombre.Size = new System.Drawing.Size(161, 44);
                lblNombre.TabIndex = 21 + i;
                lblNombre.Text = nombre;
                lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                lblId.AutoSize = true;
                lblId.Location = new System.Drawing.Point(9, 160);
                lblId.Name = "lblId" + i;
                lblId.Size = new System.Drawing.Size(15, 13);
                lblId.TabIndex = 23 + i;
                lblId.Text = Convert.ToString(id);

                btnEliminar.BackColor = System.Drawing.Color.Transparent;
                btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
                btnEliminar.FlatAppearance.BorderSize = 0;
                btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(142)))));
                btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnEliminar.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnEliminar.ForeColor = System.Drawing.Color.Red;
                btnEliminar.Location = new System.Drawing.Point(135, 0);
                btnEliminar.Margin = new System.Windows.Forms.Padding(0);
                btnEliminar.Name = "btnEliminar" + i;
                btnEliminar.Size = new System.Drawing.Size(45, 45);
                btnEliminar.TabIndex = 20;
                btnEliminar.Text = "times-circle";
                btnEliminar.UseVisualStyleBackColor = false;

                btnEliminar.Click += (s, ev) => {
                    if (MessageBox.Show("¿Seguro que quiere eliminar a " + nombre + "?", "Eliminar nivel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int retorno = Database.funcionesCRUD.eliminarNivel(id);
                        if(retorno < 1)
                        {
                            MessageBox.Show("El nivel no pudo ser eliminado");
                        }
                        mostrarNiveles();
                    };
                };
                btnEditar.Click += (s, ev) => {
                    niveles_editar editar = new niveles_editar();
                    editar.id = id;
                    editar.nombre = nombre;
                    editar.StartPosition = FormStartPosition.CenterParent;
                    editar.ShowDialog();
                    mostrarNiveles();
                };
                pnlNivel.Click += (s, ev) =>
                {
                    Admin.niveles_nivel nivel= new Admin.niveles_nivel();
                    nivel.idNivel = id;
                    nivel.tipoUsuario = 2;
                    nivel.nombreNivel = nombre;
                    nivel.StartPosition = FormStartPosition.CenterParent;
                    this.Close();
                    (Application.OpenForms["menu"] as menu).abrirFormEnPanel(nivel);
                };
                flowLayoutPanel1.Controls.Add(pnlNivel);
                pnlNivel.Controls.Add(lblId);
                pnlNivel.Controls.Add(btnEditar);
                pnlNivel.Controls.Add(lblNombre);
                pnlNivel.Controls.Add(btnEliminar);

            }
        }

        public niveles()
        {
            InitializeComponent();
        }

        private void niveles_Load(object sender, EventArgs e)
        {
            mostrarNiveles();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            niveles_nuevo nuevo = new niveles_nuevo();
            nuevo.StartPosition = FormStartPosition.CenterParent;
            nuevo.ShowDialog();
            mostrarNiveles();
        }
    }
}
