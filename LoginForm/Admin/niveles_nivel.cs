using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginForm.Database;

namespace LoginForm.Admin
{
    public partial class niveles_nivel : Form
    {
        public int idNivel { get; set; }
        public int tipoUsuario { get; set; }
        public int tipo { get; set; }
        public string nombreNivel { get; set; }
        private void mostrarUsuarios()
        {
            try
            {
                dgvUsuarios.DataSource = Database.funcionesCRUD.mostrarUsuariosNivel(Convert.ToInt32(cbxTipo.SelectedValue), idNivel);
                dgvUsuarios.Columns[0].Visible = false;
                dgvUsuarios.Columns[5].Visible = false;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error: " + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public niveles_nivel()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.btnActualizar, "Editar usuario");
            this.ttMensaje.SetToolTip(this.btnAgregar, "Agregar usuarios");
            this.ttMensaje.SetToolTip(this.cbxTipo, "Tipo de usuario");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblTitulo.Text = cbxTipo.Text + ": " + nombreNivel;
                lblTitulo.Left = (this.Width - lblTitulo.Width) / 2;
                mostrarUsuarios();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error: " + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void niveles_nivel_Load(object sender, EventArgs e)
        {
            try
            {
                cbxTipo.DisplayMember = "nombre";
                cbxTipo.ValueMember = "id";
                cbxTipo.DataSource = funcionesCRUD.mostrarTipoUsuarioNivel();
                lblTitulo.Text = cbxTipo.Text + ": " + nombreNivel;
                lblTitulo.Left = (this.Width - lblTitulo.Width) / 2;
                dgvUsuarios.DataSource = Database.funcionesCRUD.mostrarUsuariosNivel(tipoUsuario, idNivel);
                cbxTipo.SelectedValue = tipoUsuario;
                dgvUsuarios.Columns[0].Visible = false;

                btnActualizar.Font = btnAgregar.Font = Tipografia.fonts.fontawesome20;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error: " + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Admin.niveles_nivelAgregarUsuario nivelAgregar = new Admin.niveles_nivelAgregarUsuario();
                nivelAgregar.idNivel = this.idNivel;
                nivelAgregar.tipoUsuario = Convert.ToInt32(cbxTipo.SelectedValue);
                nivelAgregar.StartPosition = FormStartPosition.CenterParent;
                this.Close();
                (Application.OpenForms["menu"] as menu).abrirFormEnPanel(nivelAgregar);
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error: " + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            usuario_editar exportar = new usuario_editar();
            funcionesCRUD funciones = new funcionesCRUD();
            exportar.tipo = Convert.ToInt32(cbxTipo.SelectedValue);
            exportar.cbx_Tipo.DisplayMember = "nombre";
            exportar.cbx_Tipo.ValueMember = "id";
            exportar.cbx_Tipo.DataSource = funciones.mostrarTipoUsuario();
            exportar.cbx_Tipo.SelectedValue = tipo;

            exportar.cbx_Estado.DisplayMember = "nombre";
            exportar.cbx_Estado.ValueMember = "id";
            exportar.cbx_Estado.DataSource = funciones.mostrarEstadoUsuario();
            try
            {
                exportar.txt_Id.Text = this.dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
                exportar.txt_Nombres.Text = this.dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
                exportar.txt_Apellidos.Text = this.dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                exportar.txt_Usuario.Text = this.dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
                exportar.txt_Email.Text = this.dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
                exportar.txt_Password.Text = "";
                exportar.txt_Codigo.Text = this.dgvUsuarios.CurrentRow.Cells[6].Value.ToString();
                exportar.cbx_Tipo.Text = this.dgvUsuarios.CurrentRow.Cells[7].Value.ToString();
                exportar.cbx_Estado.Text = this.dgvUsuarios.CurrentRow.Cells[8].Value.ToString();
                exportar.ShowDialog();
                mostrarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
