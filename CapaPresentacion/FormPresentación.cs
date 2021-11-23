using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormHorasConsultas : Form
    {
        private CN_consultas instancia_CN_consultas = new CN_consultas();
        int? id;

        public FormHorasConsultas()
        {
            InitializeComponent();
        }
        private void FormHorasConsultas_Load(object sender, EventArgs e)
        {
            MostrarConsultas();
        }

        private void MostrarConsultas()
        {
            CN_consultas instancia = new CN_consultas();
            dgDatos.DataSource = instancia.MostrarProductos();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            new FormAgregarEditarRegistro().ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgDatos.SelectedRows.Count > 0)
            { 
                id = (int)dgDatos.CurrentRow.Cells["ID"].Value;
                FormAgregarEditarRegistro f = new FormAgregarEditarRegistro(id);
                f.txtSemana.Text = dgDatos.CurrentRow.Cells["Semana"].Value.ToString();
                f.txtCantidadEstudiantes.Text = dgDatos.CurrentRow.Cells["Estudiantes atendidos"].Value.ToString();
                f.cbTipoConsulta.Text = dgDatos.CurrentRow.Cells["Tipo de consulta"].Value.ToString();
                f.txtTemaConsulta.Text = dgDatos.CurrentRow.Cells["Tema de consulta"].Value.ToString();
                f.dtpFecha.Text = dgDatos.CurrentRow.Cells["Fecha"].Value.ToString();
                f.txtCarnet.Text = dgDatos.CurrentRow.Cells["Carnet del estudiante"].Value.ToString();
                f.txtObservacion.Text = dgDatos.CurrentRow.Cells["Observaciones"].Value.ToString();

                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione la consulta a editar.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarConsultas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgDatos.SelectedRows.Count > 0)
            {
                id = (int)dgDatos.CurrentRow.Cells["ID"].Value;
                instancia_CN_consultas.EliminarConsulta(id.ToString());
                MessageBox.Show("Registro eliminado.");
                MostrarConsultas();
            }
            else
            {
                MessageBox.Show("Seleccione el registro a eliminar.");
            }
        }
    }
}
