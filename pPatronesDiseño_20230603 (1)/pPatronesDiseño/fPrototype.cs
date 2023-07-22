using System;
using System.Collections.Generic;
using System.Windows.Forms;
using pPatronesDiseño.Patrones.Creacionales.Prototype;


namespace pPatronesDiseño
{
    public partial class fPrototype : Form
    {
        GestionEstudiantes gestionEstudiantes = new GestionEstudiantes();
        public fPrototype()
        {
            InitializeComponent();
        }

        private void btnPrototipo_Click(object sender, EventArgs e)
        {
            Estudiante estBaseSistemas = new Estudiante(txtDocumento1.Text, txtNombre1.Text, txtPrograma1.Text, txtPensum1.Text, txtTipoPrograma1.Text);
            gestionEstudiantes[txtPrograma1.Text] = estBaseSistemas;
            Estudiante estBaseTelco = new Estudiante(txtDocumento2.Text, txtNombre2.Text, txtPrograma2.Text, txtPensum2.Text, txtTipoPrograma2.Text);
            gestionEstudiantes[txtPrograma2.Text] = estBaseTelco;
            Estudiante estBaseMaestria = new Estudiante(txtDocumento3.Text, txtNombre3.Text, txtPrograma3.Text, txtPensum3.Text, txtTipoPrograma3.Text);
            gestionEstudiantes[txtPrograma3.Text] = estBaseMaestria;

            List<modelEstudiante> lstEstudiantesSistemas = new List<modelEstudiante>();
            lstEstudiantesSistemas.Add(new modelEstudiante("123", "MARIA"));
            lstEstudiantesSistemas.Add(new modelEstudiante("234", "PEDRO"));
            lstEstudiantesSistemas.Add(new modelEstudiante("345", "GABRIEL"));

            List<modelEstudiante> lstEstudiantesTelco = new List<modelEstudiante>();
            lstEstudiantesTelco.Add(new modelEstudiante("456", "ADRIANA"));
            lstEstudiantesTelco.Add(new modelEstudiante("567", "JULIANA"));
            lstEstudiantesTelco.Add(new modelEstudiante("678", "MARTIN"));

            List<modelEstudiante> lstEstudiantesMaestria = new List<modelEstudiante>();
            lstEstudiantesMaestria.Add(new modelEstudiante("890", "JUAN"));
            lstEstudiantesMaestria.Add(new modelEstudiante("901", "CARLOS"));
            lstEstudiantesMaestria.Add(new modelEstudiante("911", "PATRICIA"));

            //Vamos a clonar los estudiantes de sistemas
            List<Estudiante> lstSistemas = new List<Estudiante>();
            ClonarEstudiantes(lstEstudiantesSistemas, txtPrograma1.Text, lstSistemas);
            //Clonación de los estudiantes de telco
            List<Estudiante> lstTelco = new List<Estudiante>();
            ClonarEstudiantes(lstEstudiantesTelco, txtPrograma2.Text, lstTelco);
            //Clonación estudiantes maestría
            List<Estudiante> lstMaestria = new List<Estudiante>();
            ClonarEstudiantes(lstEstudiantesMaestria, txtPrograma3.Text, lstMaestria);

            //Presentación de la respuesta
            lblRespuesta.Text = "SISTEMAS\n";
            mensaje(estBaseSistemas);
            foreach (Estudiante est in lstSistemas)
            {
                mensaje(est);
            }
            lblRespuesta.Text += "\n\nTELECOMUNICACIONES\n";
            mensaje(estBaseTelco);
            foreach (Estudiante est in lstTelco)
            {
                mensaje(est);
            }
            lblRespuesta.Text += "\n\nMAESTRIA\n";
            mensaje(estBaseMaestria);
            foreach (Estudiante est in lstMaestria)
            {
                mensaje(est);
            }
        }
        private void mensaje(Estudiante est)
        {
            lblRespuesta.Text += "\nEl estudiante: " + est.Nombre + " con documento: " + est.Documento + ", TIPO DE PROGRAMA: " + est.TipoPrograma + ", Programa: " + est.Programa + ", Pensum: " + est.Pensum;
        }
        private void ClonarEstudiantes(List<modelEstudiante> ListaModel, string Clave, List<Estudiante> ListaEstudiantes)
        {
            foreach (modelEstudiante est in ListaModel)
            {
                Estudiante newEst = gestionEstudiantes[Clave].Clone() as Estudiante;
                newEst.Documento = est.Documento;
                newEst.Nombre = est.Nombre;
                ListaEstudiantes.Add(newEst);
            }
        }
    }
}
