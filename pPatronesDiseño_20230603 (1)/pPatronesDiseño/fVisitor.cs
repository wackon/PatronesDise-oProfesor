using pPatronesDiseño.Patrones.Comportamiento.Visitor;
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
    public partial class fVisitor : Form
    {
        public fVisitor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            College college = new College();

            var physicianVisitor = new Physician("Mike");
            college.PerformOperation(physicianVisitor);

            var cookVisitor = new Cook("William");
            college.PerformOperation(cookVisitor);
        }
    }
}
