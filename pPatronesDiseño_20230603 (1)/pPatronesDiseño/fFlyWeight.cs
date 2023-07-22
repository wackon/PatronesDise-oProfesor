using pPatronesDiseño.Patrones.Estructurales.FlyWeight;
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
    public partial class fFlyWeight : Form
    {
        public fFlyWeight()
        {
            InitializeComponent();
        }

        private void btnFlyWeight_Click(object sender, EventArgs e)
        {
            string[] elementos = {
                "Triangulo",
                "Rectangulo",
                "Cuadrado",
                "Triangulo"
            };

            DrawingFactory factory = new DrawingFactory();

            // extrinsic state
            int position = 100;

            foreach (string elemento in elementos)
            {
                position++;
                Forma forma = factory.GetForma(elemento);
                forma.Display(position);
            }
        }
    }
}
