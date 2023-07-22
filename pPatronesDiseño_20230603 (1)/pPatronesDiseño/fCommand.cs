using pPatronesDiseño.Patrones.Comportamiento.Command;
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
    public partial class fCommand : Form
    {
        public fCommand()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doc documento = new Doc();
            IDocumento doc = new OpenDoc(documento);
            Patrones.Comportamiento.Command.Menu menu = new Patrones.Comportamiento.Command.Menu(doc);
            menu.AbriDocumento();
        }
    }
}
