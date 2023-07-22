using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pPatronesDiseño.Patrones.Estructurales.Composite
{
    //Clase componente abstracta
    public abstract class EmpleadoComponente
    {
        protected string _nombre;
        protected string _cargo;
        public string Mensaje = "";

        public EmpleadoComponente(string name, string cargo)
        {
            _nombre = name;
            _cargo = cargo;
        }

        public abstract void AgregarEmpleado(EmpleadoComponente Empleado);
        public abstract void EliminarEmpleado(EmpleadoComponente Empleado);
        public abstract void MostrarEmpleado(int level);
    }
    //Clase hija, u hoja
    public class EmpleadoPrimario : EmpleadoComponente
    {
        public EmpleadoPrimario(string name, string cargo) : base(name, cargo) { }

        //Leaf cannot have children
        public override void AgregarEmpleado(EmpleadoComponente em)
        {
            MessageBox.Show("Los elementos primarios no tienen hijos");
        }

        //No tiene hijos 
        //No se puede eliminar
        public override void EliminarEmpleado(EmpleadoComponente em)
        {
            MessageBox.Show("No se puede eliminar el elemento primario");
        }

        //Display the root node
        public override void MostrarEmpleado(int level)
        {
            Mensaje += new String('*', level) + "Empleado: " + _nombre + ". Cargo: " + _cargo;
        }
    }
    //Clase hija
    public class EmpleadoDerivado : EmpleadoComponente
    {
        List<EmpleadoComponente> _Empleados = new List<EmpleadoComponente>();

        public EmpleadoDerivado(string name,
                                 string cargo) : base(name, cargo) { }

        //Add Empleado
        public override void AgregarEmpleado(EmpleadoComponente Empleado)
        {
            _Empleados.Add(Empleado);
        }

        //Remove Empleado
        public override void EliminarEmpleado(EmpleadoComponente em)
        {
            _Empleados.Remove(em);
        }

        //Show the tree structure
        public override void MostrarEmpleado(int Emp_level)
        {
            //MessageBox.Show(new String('*', Emp_level) + " ! " + _nombre + " " + _cargo);
            Mensaje += new String('*', Emp_level) + " ! " + _nombre + " " + _cargo;
            foreach (EmpleadoComponente e in _Empleados)
            {
                e.MostrarEmpleado(Emp_level + 2); //Muestra el nivel de la jerarquía
                Mensaje += "\n" + e.Mensaje;
            }
        }
    }
}
