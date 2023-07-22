using pPatronesDiseño.Patrones.Creacionales.Factory_Method;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pPatronesDiseño
{
    public partial class Form1 : Form
    {
        DatosEstudiante datosEstudiante = new DatosEstudiante();
        public Form1()
        {
            InitializeComponent();
        }
        public void InvocaFactory(EstudianteCreator estudiante)
        {
            estudiante.datosEstudiante = datosEstudiante;
            lblRespuesta.Text = estudiante.Consultar();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Carga la información de los combobox
            cboTipoEstudiante.Items.Add("Pregrado");
            cboTipoEstudiante.Items.Add("Postgrado");
        }
        private void CapturarDatos()
        {
            datosEstudiante.Nombre = txtNombres.Text;
            datosEstudiante.Apellidos = txtApellidos.Text;
            datosEstudiante.tipoEstudiante = (TipoEstudiante)(cboTipoEstudiante.SelectedIndex + 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CapturarDatos();
            InvocaFactory(new PregradoCreator(datosEstudiante));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CapturarDatos();
            InvocaFactory(new PostgradoCreator(datosEstudiante));
        }
    }
}
