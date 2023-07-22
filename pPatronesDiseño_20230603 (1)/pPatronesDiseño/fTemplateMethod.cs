using pPatronesDiseño.Patrones.Comportamiento.TemplateMethod;
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
    public partial class fTemplateMethod : Form
    {
        public fTemplateMethod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Preparing Tea with Lipton\n");
            TeaTemplate tea = new LiptonTea();
            tea.TeaTemplateMethod();

            MessageBox.Show("Preparing Tea with Tetley\n");
            tea = new TetleyTea();
            tea.TeaTemplateMethod();
        }
    }
}
