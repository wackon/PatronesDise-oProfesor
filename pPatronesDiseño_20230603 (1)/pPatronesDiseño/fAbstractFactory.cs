using pPatronesDiseño.Patrones.Creacionales.Abstract_Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace pPatronesDiseño
{
    public partial class fAbstractFactory : Form
    {
        private string Propietario;
        private eTipoVehiculo TipoVehiculo;
        public fAbstractFactory()
        {
            InitializeComponent();
        }

        private void fAbstractFactory_Load(object sender, EventArgs e)
        {
            cboTipoVehiculo.Items.Clear();
            cboTipoVehiculo.Items.Add("Automóvil");
            cboTipoVehiculo.Items.Add("Camioneta");
            cboTipoVehiculo.Items.Add("Camion");
            cboTipoVehiculo.Items.Add("Bicicleta");
            cboTipoVehiculo.Items.Add("Motocicleta");
            cboTipoVehiculo.Items.Add("TractoCamion");
            cboTipoVehiculo.Items.Add("Carro_traccion_Animal");
            cboTipoVehiculo.Items.Add("Carro_Rodillos");
            cboTipoVehiculo.Items.Add("MotoCarro");
            cboTipoVehiculo.Items.Add("Carretilla");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Propietario = txtPropietario.Text;
            TipoVehiculo = (eTipoVehiculo)(cboTipoVehiculo.SelectedIndex + 1);
            VehiculosMotorFactory factory = new VehiculosMotorFactory();
            factory.TipoVehiculo = TipoVehiculo;
            string Rpta = InvocarFactory(factory);
            if (Rpta != "Con")
            {
                //El vehículo es sin motor o no está definido
                VehiculosSinMotorFactory factory1 = new VehiculosSinMotorFactory();
                factory1.TipoVehiculo = TipoVehiculo;
                InvocarFactory(factory1);
            }
        }
        private string InvocarFactory(IAbstractFactoryVehiculos factory)
        {
            factory.Propietario = Propietario;
            factory.TipoVehiculo = TipoVehiculo;
            var vehiculoMotor = factory.CrearVehiculosMotor();
            if (vehiculoMotor != null )
            {
                vehiculoMotor.NumeroMotor = txtNumeroMotor.Text;
                vehiculoMotor.NumeroChasis = txtNumeroChasis.Text;
                vehiculoMotor.Propietario = Propietario;
                lblRespuesta.Text = vehiculoMotor.DefinirCaracterísticas();
                lblRespuesta.Text += vehiculoMotor.RegistrarRUNT();
                lblRespuesta.Text += vehiculoMotor.Matricular();
                lblRespuesta.Text += vehiculoMotor.PagarSOAT();
                return "Con";
            }
            else
            {
                var VehiculoSinMotor = factory.CrearVehiculosSinMotor();
                if (VehiculoSinMotor != null)
                {
                    //El vehículo existe y es sin motor, se capturan las propiedades
                    VehiculoSinMotor.Propietario = Propietario;
                    VehiculoSinMotor.NumeroSerie = txtNumeroChasis.Text;
                    lblRespuesta.Text = VehiculoSinMotor.Registrar();
                    return "Sin";
                }
                else
                {
                    lblRespuesta.Text = "El tipo de vehículo no tiene implementación";
                    return "No existe";
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtNumeroPasajeros_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNumeroChasis_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblRespuesta_Click(object sender, EventArgs e)
        {

        }

        private void cboTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNumeroMotor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPropietario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
