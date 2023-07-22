using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pPatronesDiseño.Patrones.Comportamiento.Memento
{
    public class Original
    {
        public string Mensaje { get; set; }
        int _estadosnap;
        public int Estado
        {
            get { return _estadosnap; }
            set
            {
                _estadosnap = value;
                Mensaje = "El estado actual es " + _estadosnap;
            }
        }

        public Memento CrearMemento()
        {
            return new Memento(_estadosnap);
        }

        public void RestaurarMemento(Memento memento)
        {
            Estado = memento.Estadosnap;
            Mensaje = "El estado previo era: " + Estado;
        }
    }

    public class Memento
    {
        int _estadosnap;

        public Memento(int estadosnap)
        {
            this._estadosnap = estadosnap;
        }

        public int Estadosnap
        {
            get { return _estadosnap; }
        }
    }

    public class Caretaker
    {
        Memento memento;
        public Memento Memento
        {
            set { memento = value; }
            get { return memento; }
        }
    }

}
