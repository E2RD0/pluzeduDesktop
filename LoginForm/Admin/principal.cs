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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }



        private void pnlEstudiantes_Click(object sender, EventArgs e)
        {
            Admin.usuarios usuarios = new Admin.usuarios();
            Database.funcionesCRUD mostrar = new Database.funcionesCRUD();
            usuarios.tipo = 2;
            (Application.OpenForms["menu"] as menu).abrirFormEnPanel(usuarios);
        }

        private void pnlMaestros_Click(object sender, EventArgs e)
        {
            Admin.usuarios usuarios = new Admin.usuarios();
            Database.funcionesCRUD mostrar = new Database.funcionesCRUD();
            usuarios.tipo = 1;
            (Application.OpenForms["menu"] as menu).abrirFormEnPanel(usuarios);
        }

        private void pnlAdministradores_Click(object sender, EventArgs e)
        {
            Admin.usuarios usuarios = new Admin.usuarios();
            Database.funcionesCRUD mostrar = new Database.funcionesCRUD();
            usuarios.tipo = 0;
            (Application.OpenForms["menu"] as menu).abrirFormEnPanel(usuarios);
        }

        private void pnlNiveles_Click(object sender, EventArgs e)
        {
            Admin.niveles niveles = new Admin.niveles();
            (Application.OpenForms["menu"] as menu).abrirFormEnPanel(niveles);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            pnlNiveles.BackColor = Color.FromArgb(20, 152, 213);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            pnlNiveles.BackColor = Color.FromArgb(67, 173, 221);
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            pnlEstudiantes.BackColor = Color.FromArgb(20, 152, 213);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            pnlEstudiantes.BackColor = Color.FromArgb(67, 173, 221);
        }

        private void pnlMaestros_MouseEnter(object sender, EventArgs e)
        {
            pnlMaestros.BackColor = Color.FromArgb(20, 152, 213);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            pnlMaestros.BackColor = Color.FromArgb(67, 173, 221);
        }

        private void pnlAdministradores_MouseEnter(object sender, EventArgs e)
        {
            pnlAdministradores.BackColor = Color.FromArgb(20, 152, 213);
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            pnlAdministradores.BackColor = Color.FromArgb(67, 173, 221);
        }

        private void principal_Load(object sender, EventArgs e)
        {
            lblIconAward.Font = lblIconChalkboardTeacher.Font = lblIconUser.Font = lblIIconUserGraduate.Font = Tipografia.fonts.fontawesome60;
        }

        private void pnlEstudiantes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlGraficas_Click(object sender, EventArgs e)
        {
            Admin.graficas graficas = new Admin.graficas();
            (Application.OpenForms["menu"] as menu).abrirFormEnPanel(graficas);
        }
    }
}
