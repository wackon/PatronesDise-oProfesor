using pPatronesDiseño.Patrones.Estructurales.Proxy;
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
    public partial class fProxy : Form
    {
        public fProxy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            MessageBox.Show("Se ejecuta el cliente en forma directa, sin pasar el proxy");
            RealSubject realsubject = new RealSubject();
            client.ClientCode(realsubject);

            MessageBox.Show("Se ejecuta el cliente, pasando por el proxy (Sin permisos)");

            Proxy proxy = new Proxy();
            proxy.Perfil = "usuario";
            client.ClientCode(proxy);

            MessageBox.Show("Se ejecuta el cliente, pasando por el proxy (Con permisos)");
            Proxy proxy1 = new Proxy();
            proxy1.Perfil = "Admin";
            client.ClientCode(proxy1);
        }
    }
}
