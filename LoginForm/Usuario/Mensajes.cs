using System;
using System.Windows.Forms;
using LoginForm.Database;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;

namespace LoginForm
{
    public partial class Mensajes : Form
    {
        List<int> idUsuarios = new List<int>();

        public int idNivel { get; set; }
        public int tipoUsuario { get; set; }
        public Mensajes()
        {
            InitializeComponent();
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
        public void mostrarNiveles()
        {
            int tipoUsuario = 3;
            int idNivel = 1;
            DataTable usuarios = Database.funcionesCRUD.mostrarUsuarios(tipoUsuario);
            clbBuscar.Items.Clear();
            clbBuscar.DisplayMember = "nombre";
            clbBuscar.ValueMember = "id";
            for (int i = 0; i < usuarios.Rows.Count; i++)
            {
                int idUsuario = Convert.ToInt32(usuarios.Rows[i].ItemArray[0]);
                string nombresUsuario = Convert.ToString(usuarios.Rows[i].ItemArray[1]);
                string apellidosUsuario = Convert.ToString(usuarios.Rows[i].ItemArray[2]);
                clbBuscar.Items.Add(nombresUsuario + " " + apellidosUsuario);
                idUsuarios.Add(idUsuario);
                if (usuarioEnNivel(idUsuario, idNivel))
                {
                    clbBuscar.SetItemChecked(i, true);
                }
            }
        }
        private void Mensajes_Load(object sender, EventArgs e)
        {
            int idUsuario = 8;
            labelNombre.Text = Convert.ToString(funcionesCRUD.datosUsuario(idUsuario).Rows[0].ItemArray[1]) + " " + Convert.ToString
                (funcionesCRUD.datosUsuario(idUsuario).Rows[0].ItemArray[2]);

            btnCerrar.Font = btnInformacion.Font = btnInformacion.Font = btnAgrega2.Font = btnArchivos.Font = 
                btnEmoticon.Font = btnLeave.Font = btnAgregar.Font = Tipografia.fonts.fontawesome20;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            panelInformacion.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panelInformacion.Visible = true;
        }
        private void btnLeave_Click(object sender, EventArgs e)
        {
            panelBuscar.Visible = false;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            panelInformacion.Visible = false;
        }
        private void btnInformacion_Click(object sender, EventArgs e)
        {
            panelInformacion.Visible = true;
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {

        }
        private void btnAgrega2_Click(object sender, EventArgs e)
        {

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            panelBuscar.Visible = true;
        }
    }
}
