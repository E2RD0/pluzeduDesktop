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
using LoginForm.Admin;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;

namespace LoginForm.Admin
{
    public partial class usuarios : Form
    {
        public int tipo{get;set;}
        public void mostrarUsuarios()
        {
            dgvUsuarios.DataSource = Database.funcionesCRUD.mostrarUsuarios(Convert.ToInt32(cbxTipo.SelectedValue));
            dgvUsuarios.Columns[0].Visible = false;
            dgvReporte.DataSource = Database.funcionesCRUD.reporteUsuarios(Convert.ToInt32(cbxTipo.SelectedValue));
            dgvReporte.Columns[0].Visible = false;
        }
        public usuarios()
        {
            InitializeComponent();
            tipo = -1;
        }
        public void Eliminar()
        {
            if (dgvUsuarios.SelectedRows.Count == 1 || dgvUsuarios.SelectedCells.Count == 1)
            {
                int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);
                constructor eliminar = new constructor();
                int datos = funcionesCRUD.eliminarUsuarios(id);
                if (datos > 0)
                {
                    MessageBox.Show("El usuario se elimino correctamente.", "Usuario Eliminado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El usuario no se ha eliminado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Tienes que seleccionar una fila");
            }
        }
        private void usuarios_Load(object sender, EventArgs e)
        {
            Database.funcionesCRUD mostrar = new Database.funcionesCRUD();
            cbxTipo.DisplayMember = "nombre";
            cbxTipo.ValueMember = "id";
            cbxTipo.DataSource = mostrar.mostrarTipoUsuario();
            lblTitulo.Left = (this.Width - lblTitulo.Width) / 2;
            lblTitulo.Text = cbxTipo.Text;
            if (tipo != -1)
            {
                cbxTipo.SelectedIndex = tipo;
            }
            mostrarUsuarios();

            btnAgregar.Font = btnEditar.Font = btnEliminar.Font = Tipografia.fonts.fontawesome20;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                usuario_editar agregar = new usuario_editar();
                funcionesCRUD funciones = new funcionesCRUD();
                agregar.button1.Text = "Agregar";
                agregar.label9.Text = "Agregar Usuario";
                agregar.tipo = Convert.ToInt32(cbxTipo.SelectedValue);

                agregar.cbx_Tipo.DisplayMember = "nombre";
                agregar.cbx_Tipo.ValueMember = "id";
                agregar.cbx_Tipo.DataSource = funciones.mostrarTipoUsuario();
                agregar.cbx_Tipo.SelectedValue = cbxTipo.SelectedValue;

                agregar.cbx_Estado.DisplayMember = "nombre";
                agregar.cbx_Estado.ValueMember = "id";
                agregar.cbx_Estado.DataSource = funciones.mostrarEstadoUsuario();
                agregar.ShowDialog();
                mostrarUsuarios();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo realizar la orden: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTitulo.Text = cbxTipo.Text;
            lblTitulo.Left = (this.Width - lblTitulo.Width) / 2;
            mostrarUsuarios();
        }
        private void btnEditar_Click(object sender, EventArgs e)
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
            catch(Exception ex)
            {
                MessageBox.Show("Hubo un error: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("¿Desea eliminar el usuario?", "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    Eliminar();
                    mostrarUsuarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public float[] columnasdatagrid(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }
        public void reporte(Document document)
        {
            DataTable reporteDT = Database.funcionesCRUD.reporteUsuarios(Convert.ToInt32(cbxTipo.SelectedValue));
            int i, j;
            PdfPTable datos = new PdfPTable(reporteDT.Columns.Count);
            datos.DefaultCell.Padding = 3;
            float[] margenAncho = columnasdatagrid(dgvReporte);
            datos.SetWidths(margenAncho);
            datos.WidthPercentage = 100;
            datos.DefaultCell.BorderWidth = 1;
            datos.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            for (i = 0; i < reporteDT.Columns.Count; i++)
            {
                datos.AddCell(reporteDT.Columns[i].ColumnName);
            }
            datos.HeaderRows = 1;
            datos.DefaultCell.BorderWidth = 1;
            for (i = 0; i < reporteDT.Rows.Count; i++)
            {
                for (j = 0; j < reporteDT.Columns.Count; j++)
                {
                    if (reporteDT.Rows[i].ItemArray[j] != null)
                    {
                        datos.AddCell(new Phrase(reporteDT.Rows[i].ItemArray[j].ToString()));
                    }
                }
                datos.CompleteRow();
            }
            document.Add(datos);
        }
        
        private void crearPDF()
        {
            Document doc = new Document(PageSize.LETTER.Rotate(), 10, 10, 10, 10);
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = "@C";
            save.Title = "Guardar Reporte";
            save.DefaultExt = "pdf";
            save.Filter = "Archivos pdf (*.pdf)|*.pdf";
            save.FileName = "reporte.pdf";
            save.RestoreDirectory = true;
            string nombreArchivo = "";
            if (save.ShowDialog() == DialogResult.OK)
            {
                nombreArchivo = save.FileName;
            }
            if (nombreArchivo.Trim() != "")
            {
                FileStream file = new FileStream(nombreArchivo,
                                                FileMode.OpenOrCreate,
                                                FileAccess.ReadWrite,
                                                FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, file);
                doc.Open();
                string remitente = "Pluzedu";
                string envio = "Fecha: " + DateTime.Now.ToString();

                Chunk chunk = new Chunk("Reporte General de "+lblTitulo.Text,
                    FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD));
                doc.Add(new Paragraph(chunk));
                doc.Add(new Paragraph("             "));
                doc.Add(new Paragraph("             "));
                //doc.Add(new Paragraph("---------------------------------------------------------"));
                doc.Add(new Paragraph(""));
                doc.Add(new Paragraph(remitente));
                doc.Add(new Paragraph(envio));
                //doc.Add(new Paragraph("---------------------------------------------------------"));
                doc.Add(new Paragraph("             "));
                doc.Add(new Paragraph("             "));
                reporte(doc);
                doc.AddCreationDate();
                doc.Add(new Paragraph("Reporte General de "+ lblTitulo.Text,
                    FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD)));
                doc.Add(new Paragraph("Generado por: " + Database.usuarioActual.nombresUsuario + " " + Database.usuarioActual.apellidosUsuario,
                    FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD)));
                doc.Close();
                Process.Start(nombreArchivo);
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                crearPDF();
            }
            catch(Exception eReporte)
            {
                MessageBox.Show("Error. No se pudo generar el reporte. \n" + eReporte.Message);
            }
        }
    }
}
