using pPatronesDiseño.Patrones.Comportamiento.Memento;
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
    public partial class fMemento : Form
    {
        public fMemento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Original origin = new Original();
            Random rand = new Random();
            origin.Estado = rand.Next(1000000);
            lblMensaje.Text = origin.Mensaje;

            // Creating a Memento
            Caretaker anterior = new Caretaker();
            anterior.Memento = origin.CrearMemento();

            //Changing the state
            origin.Estado = rand.Next(1000000);
            lblMensaje.Text += "\n" + origin.Mensaje;

            // Restoring the State
            origin.RestaurarMemento(anterior.Memento);
            lblMensaje.Text += "\n" + origin.Mensaje;
        }
    }
}
