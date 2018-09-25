using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using LoginForm.Database;
using LoginForm.Admin;

namespace LoginForm.User
{
    public partial class grupo : Form
    {
        public int idUsuarioActual = usuarioActual.idUsuario;
        List<int> idUsuarios = new List<int>();
        List<int> idUsuariosAdd = new List<int>();
        List<UsuarioItem> selectedUsers = new List<UsuarioItem>();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void barra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public grupo()
        {
            InitializeComponent();
        }
        public void MostrarUsuario()
        {
            clbUsuarios.Items.Clear();
            DataTable niveles = Database.funcionesCRUD.nivelUsuario(idUsuarioActual);
            for (int o = 0; o < niveles.Rows.Count; o++)
            {
                int Nivel = Convert.ToInt32(niveles.Rows[o].ItemArray[0]);
                DataTable usuarios = Database.funcionesCRUD.mostrarContactosBuscar(Nivel, idUsuarioActual);
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
                }
            }
            for (int z = 0; z < clbUsuarios.Items.Count; z++)
            {
                var user = clbUsuarios.Items[z] as UsuarioItem;
                if (selectedUsers.Any(x => x.id == user.id))
                    clbUsuarios.SetItemChecked(z, true);
            }
        }
        public void BuscarUsuario()
        {
            string busqueda = txtBuscar.Text;
            clbUsuarios.Items.Clear();
            DataTable niveles = Database.funcionesCRUD.nivelUsuario(idUsuarioActual);
            for (int o = 0; o < niveles.Rows.Count; o++)
            {
                int Nivel = Convert.ToInt32(niveles.Rows[o].ItemArray[0]);
                DataTable usuarios = Database.funcionesCRUD.buscarContactos(Nivel, idUsuarioActual, busqueda);
                clbUsuarios.DisplayMember = "nombre";
                clbUsuarios.ValueMember = "id";
                for (int i = 0; i < usuarios.Rows.Count; i++)
                {
                    int idUsuario = Convert.ToInt32(usuarios.Rows[i].ItemArray[2]);
                    string nombresUsuario = Convert.ToString(usuarios.Rows[i].ItemArray[0]);
                    string apellidosUsuario = Convert.ToString(usuarios.Rows[i].ItemArray[1]);
                    clbUsuarios.Items.Add(new UsuarioItem
                    {
                        id = idUsuario,
                        nombre = nombresUsuario + " " + apellidosUsuario
                    });
                    idUsuarios.Add(idUsuario);
                }
            }
            for (int z = 0; z < clbUsuarios.Items.Count; z++)
            {
                var user = clbUsuarios.Items[z] as UsuarioItem;
                if (selectedUsers.Any(x => x.id == user.id))
                    clbUsuarios.SetItemChecked(z, true);
            }
        }
        private void btnRetorno_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void grupo_Load(object sender, EventArgs e)
        {
            MostrarUsuario();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscar.Text.Trim())) { BuscarUsuario(); } else { MostrarUsuario(); }
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            MessageBox.Show(selectedUsers.Count.ToString());
            ComprobarUsuarios();
            CrearGrupo();
        }
        private void ComprobarUsuarios()
        {
            for (int i = 0; i < clbUsuarios.Items.Count; i++)
            {
                if (clbUsuarios.GetItemCheckState(i) == CheckState.Checked)
                {
                    idUsuariosAdd.Add(idUsuarios[i]);
                }
                else if (clbUsuarios.GetItemCheckState(i) == CheckState.Unchecked)
                {
                    int posicion = idUsuariosAdd.IndexOf(idUsuarios[i]);
                    if (posicion != -1)
                    {
                        idUsuariosAdd.Remove(posicion);
                    }
                }
            }
        }
        private void CrearGrupo()
        {
            string titulo = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            if (!string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                lblNombre.Text = "";
                if (!string.IsNullOrEmpty(txtDescripcion.Text.Trim()))
                {
                    lblDescripcion.Text = "";
                    if (idUsuariosAdd.Count > 0)
                    {
                        if (idUsuariosAdd.Count > 2)
                        {
                            int comprobar = funcionesCRUD.crearConversacionGrupal(idUsuarioActual, idUsuarios, descripcion, titulo);
                            if (comprobar > 0)
                            {
                                MessageBox.Show("El grupo ha sido creado con éxito.", "Grupo creado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                mensajes mensajes = new mensajes();
                                mensajes.mostrarConversaciones();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error al crear el grupo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debes seleccionar al menos dos integrantes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No has seleccionado a ningún integrante.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    lblDescripcion.Text = "El campo esta vacío.";
                }
            }
            else
            {
                lblNombre.Text = "El campo esta vacío.";
            }
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