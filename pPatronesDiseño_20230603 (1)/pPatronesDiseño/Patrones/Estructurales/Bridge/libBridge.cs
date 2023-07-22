using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pPatronesDiseño.Patrones.Estructurales.Bridge
{
    //Esta es la interface de implementación
    interface IDiarioImplementation
    {
        void Agregar(string mensaje);
        void Agregar(string amigo, string mensaje);
        void Tag(string persona);
    }
    //Abstracción del proceso
    class DiarioAbstraction
    {
        public IDiarioImplementation _implementation;
        public string Historial { get; set; }
        public DiarioAbstraction(IDiarioImplementation implementation)
        {
            _implementation = implementation;
        }
        public void Agregar(string mensaje)
        {
            _implementation.Agregar(mensaje);
        }
        public void Agregar(string amigo, string mensaje)
        {
            _implementation.Agregar(amigo, mensaje);
        }
        public void Tag(string persona)
        {
            _implementation.Tag(persona);
        }
    }
    //Este es el implementador concreto 2
    public class DailyDiario : IDiarioImplementation
    {
        static SortedList<string, DailyDiario> comunidad = new SortedList<string, DailyDiario>(100);
        public string paginas;
        public string nombre;
        public string espacios = "\n\t\t\t\t";
        public string Historial { get; set; }
        public DailyDiario(string n)
        {
            nombre = n;
            comunidad[n] = this;
        }

        public void Agregar(string s)
        {
            paginas += espacios + s;
            Historial += espacios + "Este es el diario de: ======== " + nombre + "========";
            Historial += paginas;
            Historial += espacios + "=================================";
        }

        public void Agregar(string amigo, string mensaje)
        {
            comunidad[amigo].Agregar(mensaje);
        }

        public void Tag(string persona)
        {
            comunidad[persona].paginas += espacios + "Has sido tagueado";
        }
    }
    //Este es el implementador concreto
    public class ShareDiario : IDiarioImplementation
    {
        public DailyDiario _myDailyDiario;
        public string _nombre;
        static int _users;

        public ShareDiario(string nombre)
        {
            _nombre = nombre;
            _users++;
            _myDailyDiario = new DailyDiario(_nombre + " Diario");
        }

        public void Agregar(string mensaje)
        {
            _myDailyDiario.Agregar(mensaje);
        }

        public void Agregar(string amigo, string mensaje)
        {
            _myDailyDiario.Agregar(amigo, _nombre + " dice:" + mensaje);
        }

        public void Tag(string persona)
        {
            _myDailyDiario.Tag(persona);
        }
    }
}
