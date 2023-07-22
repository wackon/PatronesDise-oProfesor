using System;
using System.Linq.Expressions;
using System.Windows.Forms;
using pPatronesDiseño.Patrones.Creacionales.Builder;

namespace pPatronesDiseño
{
    public partial class fBuilder : Form
    {
        public fBuilder()
        {
            InitializeComponent();
        }

        private void btnBuilder_Click(object sender, EventArgs e)
        {
            var hojaVidaBuilder = new HojaVidaBuilder();
            HojaVida hojaVida = hojaVidaBuilder
                .AgregarColegio()
                    .AgregarNombre("Bachillerato académico")
                    .AgregarInstitucion("Colegio Salesiano")
                    .AgregarTitulo("Bachiller académico")
                    .AgregarFechaGrado(new DateTime(2005, 11, 20))
                .AgregarEducacionUniversitaria()
                    .AgregarNombre("Ingeniería de Sistemas")
                    .AgregarInstitucion("ITM")
                    .AgregarTitulo("Ingeniero de Sistemas")
                    .AgregarFechaGrado(new DateTime(2012, 06, 30))
                .AgregarExperienciaLaboral()
                    .AgregarCargo("Desarrollador")
                    .AgregarFunciones("Programar en ...")
                    .AgregarCompañia("INTERGRUPO")
                    .AgregarFechaInicio(new DateTime(2012, 07, 01))
                    .AgregarFechaFin(new DateTime(2018, 12, 31))
                    .EstaActivo(false)
                .AgregarExperienciaLaboral()
                    .AgregarCargo("Analista")
                    .AgregarFunciones("Levantamiento requerimientos en ...")
                    .AgregarCompañia("Microsoft")
                    .AgregarFechaInicio(new DateTime(2019, 01, 01))
                    .EstaActivo(true)
                .Build();
            //Se imprime la información en el label
            lblPresentacion.Text = "FORMACIÓN / EDUCACIÓN\n";
            foreach(Educacion educacion in hojaVida.FormacionEducativa)
            {
                lblPresentacion.Text += "Programa: " + educacion.NombrePrograma + " - " +
                                        "Institución: " + educacion.NombreInstitucion + "\n" +
                                        "Título: " + educacion.Titulo + " - " +
                                        "Fecha grado: " + educacion.FechaGrado.ToString("yyyy-MMM") + "\n";
            }
            lblPresentacion.Text += "\nEXPERIENCIA LABORAL\n";
            foreach (Trabajo trabajo in hojaVida.ExperienciaLaboral)
            {
                lblPresentacion.Text += "Cargo: " + trabajo.Cargo + " - " +
                                        "Funciones: " + trabajo.Funciones + "\n" +
                                        "Empresa: " + trabajo.Compañia + " - " +
                                        "Fecha inicio: " + trabajo.FechaInicio.ToString("yyyy-MMM") + "\n";
                if (!trabajo.Activo)
                {
                    lblPresentacion.Text += "Fecha terminación contrato: " + 
                                            trabajo.FechaFin.ToString("yyyy-MMM") + "\n\n";
                }
                else
                {
                    lblPresentacion.Text += "Trabajo actual\n\n";
                }
            }
        }
    }
}
