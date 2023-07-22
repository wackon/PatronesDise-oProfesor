using pPatronesDiseño.Patrones.Comportamiento.Iterator;
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
    public partial class fIterator : Form
    {
        public fIterator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConcreteAggregate aggregate = new ConcreteAggregate();

            aggregate[0] = "Item 1";
            aggregate[1] = "Item 2";
            aggregate[2] = "Item 3";
            aggregate[3] = "Item 4";
            aggregate[4] = "Item 5";

            // Creating the Iterator and assigning an aggregate to it
            Iterator i = aggregate.Create();
            lblMensaje.Text = "Recorre la colección:";

            string currentItem = i.FirstItem();
            while (currentItem != null)
            {
                lblMensaje.Text += (currentItem);
                currentItem = i.NextItem();
            }
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }
    }
}
