using pPatronesDiseño.Patrones.Estructurales.Composite;
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
    public partial class fComposite : Form
    {
        public fComposite()
        {
            InitializeComponent();
        }

        private void btnBridge_Click(object sender, EventArgs e)
        {
            //Creación de la estructura de la empresa
            //Nivel 1
            EmpleadoDerivado gerente = new EmpleadoDerivado("MARIA ALVAREZ", "GERENTE");
            gerente.AgregarEmpleado(new EmpleadoPrimario("ANDRES BETANCUR", "JEFE DISEÑO"));
            gerente.AgregarEmpleado(new EmpleadoPrimario("ANDREA BOTERO", "JEFE DESARROLLO"));

            //Nivel 2
            EmpleadoDerivado jefeComercial = new EmpleadoDerivado("JULIANA SANCHEZ", "JEFE COMERCIAL");
            jefeComercial.AgregarEmpleado(new EmpleadoPrimario("ALICIA VELEZ", "Asesora comercial"));
            jefeComercial.AgregarEmpleado(new EmpleadoPrimario("ALVARO JARAMILLO", "Asesor comercial"));
            //Nivel 3
            EmpleadoDerivado ventas = new EmpleadoDerivado("BEATRIZ ZAPATA", "ENCARGADA VENTAS");
            ventas.AgregarEmpleado(new EmpleadoPrimario("SANDRA SALAZAR", "CAJERA"));
            ventas.AgregarEmpleado(new EmpleadoPrimario("CARLOS JIMENEZ", "CAJERO"));
            //Agrega ventas al jefe comercial
            jefeComercial.AgregarEmpleado(ventas);
            //Agrega la estructura al gerente
            gerente.AgregarEmpleado(jefeComercial);

            //Nivel 2
            EmpleadoDerivado supervisor = new EmpleadoDerivado("JORGE VILLA", "Supervisor en jefe");
            supervisor.AgregarEmpleado(new EmpleadoPrimario("JUAN GIRALDO", "Supervisor caja"));
            supervisor.AgregarEmpleado(new EmpleadoPrimario("BERTHA TAMAYO", "Supervisor sede Bello"));
            //Agrega los supervisores al gerente
            gerente.AgregarEmpleado(supervisor);

            //Presenta la estructura
            gerente.MostrarEmpleado(1);
            lblMensaje.Text = gerente.Mensaje;
        }
    }
}
