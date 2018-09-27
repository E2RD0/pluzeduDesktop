using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LoginForm.Database;

namespace LoginForm.Admin
{
    public partial class niveles_nivelAgregarUsuario : Form
    {
        //VARIABLES
        List<int> idUsuarios = new List<int>();
        List<UsuarioItem> selectedUsers = new List<UsuarioItem>();
        public int idNivel { get; set; }
        public int tipoUsuario { get; set; }
        //INICIALIZAR FORM
        public niveles_nivelAgregarUsuario()
        {
            InitializeComponent();
        }
        private void niveles_nivelAgregarUsuario_Load(object sender, EventArgs e)
        {
            mostrarNiveles();
            lblBuscar.Font = Tipografia.fonts.fontawesome14;
        }
        //NIVELES
        public void mostrarNiveles()
        {
            try
            {
                DataTable usuarios = Database.funcionesCRUD.mostrarUsuarios(tipoUsuario);
                clbUsuarios.Items.Clear();
                clbUsuarios.DisplayMember = "nombre";
                clbUsuarios.ValueMember = "id";
                for (int i = 0; i < usuarios.Rows.Count; i++)
                {
                    int idUsuario = Convert.ToInt32(usuarios.Rows[i].ItemArray[0]);
                    string nombresUsuario = Convert.ToString(usuarios.Rows[i].ItemArray[1]);
                    string apellidosUsuario = Convert.ToString(usuarios.Rows[i].ItemArray[2]);
                    clbUsuarios.Items.Add(new UsuarioItem
                    {
                        id = idUsuario,
                        nombre = nombresUsuario + " " + apellidosUsuario
                    });
                    idUsuarios.Add(idUsuario);
                    if (usuarioEnNivel(idUsuario, idNivel))
                    {
                        clbUsuarios.SetItemChecked(i, true);
                    }
                }
                for (int z = 0; z < clbUsuarios.Items.Count; z++)
                {
                    var user = clbUsuarios.Items[z] as UsuarioItem;
                    if (selectedUsers.Any(x => x.id == user.id))
                        clbUsuarios.SetItemChecked(z, true);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error: " + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Buscar()
        {
            try
            {
                string busqueda = txtUser.Text;
                if (!string.IsNullOrEmpty(busqueda.Trim()))
                {
                    DataTable usuarios = funcionesCRUD.buscarContactosNivel(tipoUsuario, busqueda);
                    clbUsuarios.Items.Clear();
                    clbUsuarios.DisplayMember = "nombre";
                    clbUsuarios.ValueMember = "id";
                    for (int i = 0; i < usuarios.Rows.Count; i++)
                    {
                        int idUsuario = Convert.ToInt32(usuarios.Rows[i].ItemArray[0]);
                        string nombresUsuario = Convert.ToString(usuarios.Rows[i].ItemArray[1]);
                        string apellidosUsuario = Convert.ToString(usuarios.Rows[i].ItemArray[2]);
                        clbUsuarios.Items.Add(new UsuarioItem
                        {
                            id = idUsuario,
                            nombre = nombresUsuario + " " + apellidosUsuario
                        });
                        idUsuarios.Add(idUsuario);
                        if (usuarioEnNivel(idUsuario, idNivel))
                        {
                            clbUsuarios.SetItemChecked(i, true);
                        }
                    }
                    for (int z = 0; z < clbUsuarios.Items.Count; z++)
                    {
                        var user = clbUsuarios.Items[z] as UsuarioItem;
                        if (selectedUsers.Any(x => x.id == user.id))
                            clbUsuarios.SetItemChecked(z, true);
                    }
                }
                else { mostrarNiveles(); }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error: " + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void guardarNivel()
        {
            try
            {
                for (int i = 0; i < clbUsuarios.Items.Count; i++)
                {
                    if (clbUsuarios.GetItemCheckState(i) == CheckState.Checked && !usuarioEnNivel(idUsuarios[i], idNivel))
                    {
                        MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO nivelesusuario(id_usuario, id_nivel) VALUES ({0}, {1})", idUsuarios[i], idNivel), Database.conexion.obtenerconexion());
                        comando.ExecuteNonQuery();
                    }
                    else if (clbUsuarios.GetItemCheckState(i) == CheckState.Unchecked && usuarioEnNivel(idUsuarios[i], idNivel))
                    {
                        MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM nivelesusuario WHERE id_usuario={0} AND id_nivel={1}", idUsuarios[i], idNivel), Database.conexion.obtenerconexion());
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error: " + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool usuarioEnNivel(int idUsuario, int idNivel)
        {
            DataTable usuario = new DataTable();
            string instrucciones = String.Format("SELECT * FROM nivelesusuario WHERE id_usuario = {0} AND id_nivel = {1}", idUsuario, idNivel);
            MySqlCommand comando = new MySqlCommand(instrucciones, Database.conexion.obtenerconexion());
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            adapter.Fill(usuario);
            if (usuario.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //INTERACCION USUARIO-FORM
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarNivel();
            Admin.niveles_nivel nivel = new Admin.niveles_nivel();
            nivel.idNivel = this.idNivel;
            nivel.tipoUsuario = this.tipoUsuario;
            nivel.StartPosition = FormStartPosition.CenterParent;
            this.Close();
            (Application.OpenForms["menu"] as menu).abrirFormEnPanel(nivel);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Admin.niveles_nivel nivel = new Admin.niveles_nivel();
            nivel.idNivel = this.idNivel;
            nivel.tipoUsuario = this.tipoUsuario;
            nivel.StartPosition = FormStartPosition.CenterParent;
            this.Close();
            (Application.OpenForms["menu"] as menu).abrirFormEnPanel(nivel);
        }
        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void clbUsuarios_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                selectedUsers.Add(clbUsuarios.Items[e.Index] as UsuarioItem);
            else
                selectedUsers.Remove(clbUsuarios.Items[e.Index] as UsuarioItem);
        }
    }
}