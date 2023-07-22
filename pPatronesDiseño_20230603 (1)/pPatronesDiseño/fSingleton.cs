using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pPatronesDiseño.Patrones.Creacionales.Singleton;

namespace pPatronesDiseño
{
    public partial class fSingleton : Form
    {
        public fSingleton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BalanceadorCarga b1 = BalanceadorCarga.GetBalanceador();
            BalanceadorCarga b2 = BalanceadorCarga.GetBalanceador();
            BalanceadorCarga b3 = BalanceadorCarga.GetBalanceador();
            BalanceadorCarga b4 = BalanceadorCarga.GetBalanceador();
            BalanceadorCarga b5 = BalanceadorCarga.GetBalanceador();
            BalanceadorCarga b6 = BalanceadorCarga.GetBalanceador();

            if (b1 == b2 && b2 == b3 && b3 == b4 && b4 == b5 && b5 == b6)
            {
                lblRespuesta.Text = "SÓLO SE CREA UNA INSTANCIA";
            }
            BalanceadorCarga balanceador = BalanceadorCarga.GetBalanceador();
            for (int i = 0; i < 15; i++)
            {
                string server = balanceador.Servidor;
                lblRespuesta.Text += "\nSe despacha al servidor: " + server;
            }
        }
    }
}
