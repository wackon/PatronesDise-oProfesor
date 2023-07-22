using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pPatronesDiseño.Patrones.Estructurales.Facade
{
    public interface IHamburguesa
    {
        void GetHamburguesaVegetariana();
        void GetHamburguesaNormal();
    }
    public class ProveedorHamburguesa : IHamburguesa
    {
        public void GetHamburguesaNormal()
        {
            GetHamburguesaNormalIngredientes();
            MessageBox.Show("Preparando hamburguesa normal.");
        }
        public void GetHamburguesaVegetariana()
        {
            MessageBox.Show("Preparando hamburguesa vegetariana.");
        }
        private void GetHamburguesaNormalIngredientes()
        {
            MessageBox.Show("Preparando hamburguesa con ingredientes tradicionales.");
        }
    }
    public interface HamburguesaPan
    {
        void GetSimplePan();
        void GetAjonjoliPan();
    }

    public class PanProvider : HamburguesaPan
    {
        public void GetSimplePan()
        {
            MessageBox.Show("Preparando pan normal.");
        }
        public void GetAjonjoliPan()
        {
            MessageBox.Show("Preparando pan con semillas ajonjoli.");
        }
    }
    public class RestaurantFacade
    {
        private IHamburguesa _burgerProvider;
        private HamburguesaPan _bunProvider;
        public RestaurantFacade()
        {
            _burgerProvider = new ProveedorHamburguesa();
            _bunProvider = new PanProvider();
        }
        public void GetHamburguesaNormal()
        {
            _bunProvider.GetSimplePan();
            _burgerProvider.GetHamburguesaNormal();
        }
        public void GetHamburguesaVegetariana()
        {
            _bunProvider.GetAjonjoliPan();
            _burgerProvider.GetHamburguesaVegetariana();
        }
    }
}
