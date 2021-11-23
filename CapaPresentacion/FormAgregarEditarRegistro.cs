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
    public partial class FormAgregarEditarRegistro : Form
    {
        //  REFERENCIAS
        private CN_consultas instancia_CN_consultas = new CN_consultas();

        private int? _id = 0;
        public FormAgregarEditarRegistro(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private void FormAgregarEditarRegistro_Load(object sender, EventArgs e)
        {
            if (_id == null)
                Text = "Nuevo registro";
            else
            { 
                Text = "Editar registro";
                btnInsertar.Text = "Editar";
            }
                
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (_id == null)
            {
                try
                {
                    instancia_CN_consultas.InsertarConsulta(txtSemana.Text, txtCantidadEstudiantes.Text, cbTipoConsulta.Text, txtTemaConsulta.Text, dtpFecha.Text, txtCarnet.Text, txtObservacion.Text, checkAprobacion.Checked);
                    MessageBox.Show("Consulta insertada.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error. La consulta no ha sido insertada. Detalles del error: \n " + ex);
                }
            }
            else
            {
                try
                {
                    instancia_CN_consultas.EditarConsulta((int)_id, txtSemana.Text, txtCantidadEstudiantes.Text, cbTipoConsulta.Text, txtTemaConsulta.Text, dtpFecha.Text, txtCarnet.Text, txtObservacion.Text, checkAprobacion.Checked);
                    MessageBox.Show("Consulta editada.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error. La consulta no ha sido insertada. Detalles del error: \n " + ex);
                }
            }
        }
    }
}
