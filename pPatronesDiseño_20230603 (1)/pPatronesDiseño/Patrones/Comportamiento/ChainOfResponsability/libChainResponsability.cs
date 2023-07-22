using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pPatronesDiseño.Patrones.Comportamiento.ChainOfResponsability
{
    class CompraElemento
    {
        public CompraElemento(string name, double Cantidad)
        {
            TipoSolicitud = name;
            CantidadPropuesta = Cantidad;

            MessageBox.Show($"Compra solicitada para: {TipoSolicitud} " +
                $"por un costo de ${Cantidad} ha sido generada.");
        }

        public string TipoSolicitud { get; set; }
        public double CantidadPropuesta { get; set; }
    }
    abstract class Aprobador
    {
        protected Aprobador _siguienteAprobador;

        public void SetNextAprobador(Aprobador aprobador)
        {
            _siguienteAprobador = aprobador;
        }
        public abstract void ProcessRequest(CompraElemento compra);
    }
    class TechManager : Aprobador
    {
        public override void ProcessRequest(CompraElemento compra)
        {
            if (compra.CantidadPropuesta < 15000)
            {
                MessageBox.Show($"{this.GetType().Name} aprobado: " +
                    $"{compra.TipoSolicitud}");
            }
            else if (_siguienteAprobador != null)
            {
                _siguienteAprobador.ProcessRequest(compra);
            }
        }
    }
    class GeneralManager : Aprobador
    {
        public override void ProcessRequest(CompraElemento compra)
        {
            if (compra.CantidadPropuesta < 30000)
            {
                MessageBox.Show($"{this.GetType().Name} aprobado: " +
                    $"{compra.TipoSolicitud}");
            }
            else if (_siguienteAprobador != null)
            {
                _siguienteAprobador.ProcessRequest(compra);
            }
        }
    }
    class CEO : Aprobador
    {
        public override void ProcessRequest(CompraElemento compra)

        {
            if (compra.CantidadPropuesta < 45000)
            {
                MessageBox.Show($"{this.GetType().Name} aprobado: " +
                    $"{compra.TipoSolicitud}");
            }
            else
            {
                MessageBox.Show("La compra " +
                    "requiere de financiación !");
            }
        }
    }
}
