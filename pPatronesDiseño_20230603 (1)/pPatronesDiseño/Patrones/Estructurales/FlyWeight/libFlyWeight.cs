using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pPatronesDiseño.Patrones.Estructurales.FlyWeight
{
    //Clase abstracta flyweight
    public abstract class Forma
    {
        protected string _nombre = string.Empty;
        protected int _ancho;
        protected int _altura;
        protected int _posicion;
        public abstract void Display(int posicion);
    }
    public class DrawingFactory
    {
        private Dictionary<string, Forma> formas = new Dictionary<string, Forma>();
        //Forma? forma = null;
        Forma forma = null;
        public Forma GetForma(string key)
        {
            if (formas.ContainsKey(key))
            {
                forma = formas[key];
            }
            else
            {
                switch (key)
                {
                    case "Triangulo": forma = new Triangulo(); break;
                    case "Cuadrado": forma = new Cuadrado(); break;
                    case "Rectangulo": forma = new Rectangulo(); break;
                }
                formas.Add(key, forma);
            }
            return forma;
        }
    }
   
    //Clase concreta flyweight
    public class Triangulo : Forma
    {
        // Constructor
        public Triangulo()
        {
            _nombre = "Triangulo";
            _altura = 100;
            _ancho = 120;
        }

        public override void Display(int posicion)
        {
            this._posicion = posicion;
            MessageBox.Show(_nombre +
                " (posicion " + this._posicion + ")");
        }
    }

    /// <summary>
    /// Clase concreta flyweight
    /// </summary>
    public class Cuadrado : Forma
    {
        // Constructor
        public Cuadrado()
        {
            _nombre = "Cuadrado";
            _altura = 100;
            _ancho = 120;
        }

        public override void Display(int posicion)
        {
            this._posicion = posicion;
            MessageBox.Show(_nombre + " (posicion " + this._posicion + ")");
        }
    }

    //Clase concreta flyweight
    public class Rectangulo : Forma
    {
        public Rectangulo()
        {
            _nombre = "Cuadrado";
            _altura = 100;
            _ancho = 120;
        }
        public override void Display(int posicion)
        {
            this._posicion = posicion;
            MessageBox.Show(_nombre + " (posicion " + this._posicion + ")");
        }
    }
}
