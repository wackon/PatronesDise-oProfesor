using pPatronesDiseño.Patrones.Comportamiento.Strategy;
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
    public partial class fStrategy : Form
    {
        public fStrategy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // client picks the default concrete strategy:
            MessageBox.Show("Membership type has been set to peak:");

            var context = new GymContext();
            context.SetStrategy(new PeakStrategy());
            context.MemberAcceptableTime();


            // client picks the alternative concrete strategy
            MessageBox.Show("Membership type has been set to off-peak:");

            context.SetStrategy(new OffPeakStrategy());
            context.MemberAcceptableTime();
        }
    }
}
