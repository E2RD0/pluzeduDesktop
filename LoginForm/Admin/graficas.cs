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
    public partial class graficas : Form
    {
        public graficas()
        {
            InitializeComponent();
        }

        private void btnChart1_Click(object sender, EventArgs e)
        {
            Database.conexion.obtenerconexion();
            chart1.Visible=true;
            chart2.Visible = false;
            chart3.Visible = false;
            chart1.Series["Series1"].LegendText = "Grafica de cantidad de mensajes enviados por mes";
            chart1.Series["Series1"].XValueMember = "DATE_FORMAT(fechaenviado, '%M %Y')";
            chart1.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart1.Series["Series1"].YValueMembers = "COUNT(fechaenviado)";
            chart1.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chart1.DataSource = Database.funcionesCRUD.EnviarDatos("SELECT DATE_FORMAT(fechaenviado, '%M %Y'), COUNT(fechaenviado) from mensaje WHERE fechaenviado BETWEEN CAST('2018-09-01' as Date) AND CAST('2018-09-30' as Date);");
        }

        private void btnChart2_Click(object sender, EventArgs e)
        {
            Database.conexion.obtenerconexion();
            chart1.Visible = false;
            chart2.Visible = true;
            chart3.Visible = false;
            chart2.Series["Series1"].LegendText = "Grafica de cantidad de usuarios habilitados y deshabilitados";
            chart2.Series["Series1"].XValueMember = "nombre";
            chart2.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart2.Series["Series1"].YValueMembers = "COUNT(id_usuarioestado)";
            chart2.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chart2.DataSource = Database.funcionesCRUD.EnviarDatos("SELECT nombre, COUNT(id_usuarioestado) FROM usuario u INNER JOIN usuarioestado ue ON u.id_usuarioestado=ue.id GROUP BY nombre;");
        }

        private void btnChart3_Click(object sender, EventArgs e)
        {
            Database.conexion.obtenerconexion();
            chart1.Visible = false;
            chart2.Visible = false;
            chart3.Visible = true;
            chart3.Series["Series1"].LegendText = "Grafica de cantidad de mensajes enviados por maestros y alumnos";
            chart3.Series["Series1"].XValueMember = "nombre";
            chart3.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart3.Series["Series1"].YValueMembers = "COUNT(id_usuariotipo)";
            chart3.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chart3.DataSource = Database.funcionesCRUD.EnviarDatos("SELECT id_usuariotipo, nombre, COUNT(id_usuariotipo) FROM mensaje m INNER JOIN usuario u ON m.id_autor=u.id INNER JOIN usuariotipo ut ON u.id_usuariotipo=ut.id;");
        }
    }
}
