using pPatronesDiseño.Patrones.Estructurales.Facade;
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
    public partial class fFacade : Form
    {
        public fFacade()
        {
            InitializeComponent();
        }

        private void btnFacade_Click(object sender, EventArgs e)
        {
            RestaurantFacade restaurant = new RestaurantFacade();
            restaurant.GetHamburguesaNormal();
        }
    }
}
