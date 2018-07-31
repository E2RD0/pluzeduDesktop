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
            dgvUsuarios.DataSource = Database.funcionesCRUD.mostrarUsuariosNivel(Convert.ToInt32(cbxTipo.SelectedValue), idNivel);
            dgvUsuarios.Columns[0].Visible = false;
        }
        public niveles_nivel()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTitulo.Text = cbxTipo.Text + ": " + nombreNivel;
            lblTitulo.Left = (this.Width - lblTitulo.Width) / 2;
            mostrarUsuarios();
        }
        private void niveles_nivel_Load(object sender, EventArgs e)
        {
            cbxTipo.DisplayMember = "nombre";
            cbxTipo.ValueMember = "id";
            cbxTipo.DataSource = funcionesCRUD.mostrarTipoUsuarioNivel();
            lblTitulo.Text = cbxTipo.Text + ": " + nombreNivel;
            lblTitulo.Left = (this.Width - lblTitulo.Width) / 2;
            dgvUsuarios.DataSource = Database.funcionesCRUD.mostrarUsuariosNivel(tipoUsuario, idNivel);
            cbxTipo.SelectedValue = tipoUsuario; 
            dgvUsuarios.Columns[0].Visible = false;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Admin.niveles_nivelAgregarUsuario nivelAgregar = new Admin.niveles_nivelAgregarUsuario();
            nivelAgregar.idNivel = this.idNivel;
            nivelAgregar.tipoUsuario = Convert.ToInt32(cbxTipo.SelectedValue);
            nivelAgregar.StartPosition = FormStartPosition.CenterParent;
            this.Close();
            (Application.OpenForms["menu"] as menu).abrirFormEnPanel(nivelAgregar);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            editar_usuario exportar = new editar_usuario();
            funcionesCRUD funciones = new funcionesCRUD();
            exportar.tipo = Convert.ToInt32(cbxTipo.SelectedValue);
            exportar.cbx_Tipo.DisplayMember = "nombre";
            exportar.cbx_Tipo.ValueMember = "id";
            exportar.cbx_Tipo.DataSource = Database.funcionesCRUD.mostrarTipoUsuarioNivel();
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
                exportar.txt_Password.Text = this.dgvUsuarios.CurrentRow.Cells[5].Value.ToString();
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
