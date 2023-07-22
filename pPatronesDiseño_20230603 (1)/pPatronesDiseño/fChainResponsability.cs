using pPatronesDiseño.Patrones.Comportamiento.ChainOfResponsability;
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
    public partial class fChainResponsability : Form
    {
        public fChainResponsability()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Elemento = txtElemento.Text;
            double Valor = Convert.ToDouble(txtValor.Text);
            Aprobador tech = new TechManager();
            Aprobador generalManager = new GeneralManager();
            Aprobador ceo = new CEO();

            tech.SetNextAprobador(generalManager);
            generalManager.SetNextAprobador(ceo);

            // Generate and process purchase requests
            var purchase1 = new CompraElemento(Elemento, Valor);
            tech.ProcessRequest(purchase1);
        }
    }
}
