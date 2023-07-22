using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pPatronesDiseño.Patrones.Estructurales.Bridge;

namespace pPatronesDiseño
{
    public partial class fBridge : Form
    {
        public fBridge()
        {
            InitializeComponent();
        }

        private void btnBridge_Click(object sender, EventArgs e)
        {
            DailyDiario diarioPersonal = new DailyDiario("Martín");
            diarioPersonal.Agregar("Buenas tardes");
            diarioPersonal.Agregar("Hoy inicia un nuevo puente en Colombia");

            var diarioExterno = new DiarioAbstraction(new ShareDiario("María"));
            diarioExterno.Tag("Martín");
            diarioExterno.Agregar("Martín", "Cómo estás?");
            diarioExterno.Agregar("Hola a todos, he iniciado un blog");
            
            lblMensaje.Text = diarioPersonal.Historial;
        }
    }
}
