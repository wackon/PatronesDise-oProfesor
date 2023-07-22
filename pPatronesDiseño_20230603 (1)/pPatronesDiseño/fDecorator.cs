using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pPatronesDiseño.Patrones.Estructurales.Decorator;
namespace pPatronesDiseño
{
    public partial class fDecorator : Form
    {
        public fDecorator()
        {
            InitializeComponent();
        }

        private void btnDecoratorSin_Click(object sender, EventArgs e)
        {
            LoggerRepositorio SinPermisos = new LoggerRepositorio(new OrdenRepositorio());
            SinPermisos.Agregar(new Orden(10, 120000));
        }

        private void btnDecoratorCon_Click(object sender, EventArgs e)
        {
            LoggerRepositorio Permisos = new LoggerRepositorio(new OrdenRepositorio());
            Permisos.Perfil = "Administrador";
            Permisos.Agregar(new Orden(20, 350000));
        }
    }
}
