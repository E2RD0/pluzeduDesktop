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
        public int idNivel { get; set; }
        public int tipoUsuario { get; set; }
        //INICIALIZAR FORM
        public niveles_nivelAgregarUsuario()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.lblBuscar, "Buscar...");
            this.ttMensaje.SetToolTip(this.txtUser, "Buscar...");
            this.ttMensaje.SetToolTip(this.panel1, "Buscar...");
            this.ttMensaje.SetToolTip(this.btnGuardar, "Guardar cambios");
            this.ttMensaje.SetToolTip(this.btnCancelar, "Cancelar cambios");
        }
        private void niveles_nivelAgregarUsuario_Load(object sender, EventArgs e)
        {
            mostrarNiveles();
            lblBuscar.Font = Tipografia.fonts.fontawesome14;
        }
        //NIVELES
        public void mostrarNiveles()
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
                clbUsuarios.Items.Add(nombresUsuario + " " + apellidosUsuario);
                idUsuarios.Add(idUsuario);
                if (usuarioEnNivel(idUsuario, idNivel))
                {
                    clbUsuarios.SetItemChecked(i, true);
                }
            }
        }
        private void Buscar()
        {
            string busqueda = txtUser.Text;
            if (!string.IsNullOrEmpty(busqueda.Trim()))
            {
                DataTable usuarios = funcionesCRUD.buscarContactosNivel(tipoUsuario, idNivel, busqueda);
                clbUsuarios.Items.Clear();
                clbUsuarios.DisplayMember = "nombre";
                clbUsuarios.ValueMember = "id";
                for (int i = 0; i < usuarios.Rows.Count; i++)
                {
                    int idUsuario = Convert.ToInt32(usuarios.Rows[i].ItemArray[0]);
                    string nombresUsuario = Convert.ToString(usuarios.Rows[i].ItemArray[1]);
                    string apellidosUsuario = Convert.ToString(usuarios.Rows[i].ItemArray[2]);
                    clbUsuarios.Items.Add(nombresUsuario + " " + apellidosUsuario);
                    idUsuarios.Add(idUsuario);
                    if (usuarioEnNivel(idUsuario, idNivel))
                    {
                        clbUsuarios.SetItemChecked(i, true);
                    }
                }
            }else { mostrarNiveles(); }
        }
        public void guardarNivel()
        {
            for (int i=0; i < clbUsuarios.Items.Count; i++)
            {
                if(clbUsuarios.GetItemCheckState(i) == CheckState.Checked && !usuarioEnNivel(idUsuarios[i], idNivel))
                {
                    MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO nivelesusuario(id_usuario, id_nivel) VALUES ({0}, {1})", idUsuarios[i], idNivel), Database.conexion.obtenerconexion());
                    comando.ExecuteNonQuery();
                }
                else if(clbUsuarios.GetItemCheckState(i) == CheckState.Unchecked && usuarioEnNivel(idUsuarios[i], idNivel))
                {
                    MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM nivelesusuario WHERE id_usuario={0} AND id_nivel={1}", idUsuarios[i], idNivel), Database.conexion.obtenerconexion());
                    comando.ExecuteNonQuery();
                }
            }
        }
        private bool usuarioEnNivel(int idUsuario, int idNivel)
        {
            DataTable usuario = new DataTable();
            string instrucciones = String.Format("SELECT * FROM nivelesusuario WHERE id_usuario = {0} AND id_nivel = {1}", idUsuario, idNivel);
            MySqlCommand comando = new MySqlCommand(instrucciones, Database.conexion.obtenerconexion());
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            adapter.Fill(usuario);
            if(usuario.Rows.Count >= 1)
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
    }
}
