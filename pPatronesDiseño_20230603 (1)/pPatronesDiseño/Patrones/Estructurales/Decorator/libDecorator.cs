using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pPatronesDiseño.Patrones.Estructurales.Decorator
{
    public class Orden
    {
        public Orden(int ID, decimal Total)
        {
            OrdenId = ID;
            TotalAmount = Total;
        }
        public int OrdenId { get; set; }
        public decimal TotalAmount { get; set; }
    }
    internal interface IOrdenRepositorio
    {
        void Agregar(Orden orden);
        void Actualizar(Orden orden);
        void Eliminar(Orden orden);
        Orden Consultar(int ordenId);
    }
    class OrdenRepositorio : IOrdenRepositorio
    {
        public void Agregar(Orden orden)
        {
            MessageBox.Show("Reporte original: Orden agregada");
        }
        public void Actualizar(Orden orden)
        {
            MessageBox.Show("Reporte original: Orden actualizada");
        }
        public void Eliminar(Orden orden)
        {
            MessageBox.Show("Reporte original: Orden eliminada");
        }
        public Orden Consultar(int ordenId)
        {
            MessageBox.Show("Reporte original: Orden consultada");
            return new Orden(ordenId, 100);
        }
    }
    class LoggerRepositorio : IOrdenRepositorio
    {
        private readonly IOrdenRepositorio _ordenRepositorio;
        public string Perfil { get; set; }
        private bool Permiso;
        public LoggerRepositorio(IOrdenRepositorio ordenRepositorio)
        {
            _ordenRepositorio = ordenRepositorio;
        }
        public void Agregar(Orden orden)
        {
            if (Perfil == "Administrador" || Perfil == "Cajero")
            {
                Permiso = true;
            }
            if (Permiso)
            {
                MessageBox.Show("Se agrega un comportamiento adicional con base en un perfil");
                _ordenRepositorio.Agregar(orden);
            }
            else
            {
                MessageBox.Show("No se tienen permisos para agregar una orden");
            }
        }
        public void Actualizar(Orden orden)
        {
            if (Perfil == "Administrador" || Perfil == "Supervisor")
            {
                Permiso = true;
            }
            if (Permiso)
            {
                MessageBox.Show("Logger: Orden actualizada");
                _ordenRepositorio.Actualizar(orden);
            }
            else
            {
                MessageBox.Show("No tiene permisos de actualización");
            }
        }

        public void Eliminar(Orden orden)
        {
            if (Perfil == "Administrador" || Perfil == "Supervisor")
            {
                Permiso = true;
            }
            if (Permiso)
            {
                MessageBox.Show("Logger: Orden eliminada");
                _ordenRepositorio.Eliminar(orden);
            }
            else
            {
                MessageBox.Show("No tiene permisos de eliminación");
            }
        }

        public Orden Consultar(int ordenId)
        {
            MessageBox.Show("Logger: Orden consultada");
            return _ordenRepositorio.Consultar(ordenId);
        }
    }
}
