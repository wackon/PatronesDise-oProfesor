using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pPatronesDiseño.Patrones.Estructurales.Proxy
{
    public abstract class aSubject
    {
        public string Mensaje { get; set; }
        public abstract void DoOperatio();
    }
    class realSubject : aSubject
    {
        public override void DoOperatio()
        {
            Mensaje = "Operation done by Real Subject!";
        }
    }
    interface ISubject
    {
        void DoOperation();
    }
    //Clase principal que implementa la interfaz
    class RealSubject : ISubject
    {
        public void DoOperation()
        {
            MessageBox.Show("Operation done by Real Subject!");
        }
    }
    //Clase proxy que implementa la interfaz
    public class Proxy : ISubject
    {
        private RealSubject _realSubject;
        public string Perfil { get; set; }
        public void DoOperation()
        {
            if (Perfil == "Admin")
            {
                if (_realSubject == null)
                {
                    _realSubject = new RealSubject();
                }
                MessageBox.Show("Proxy operation before Real Subject's operation.");
                _realSubject.DoOperation();
            }
            else
            {
                MessageBox.Show("Sin permisos");
            }
        }
    }
    class Client
    {
        public void ClientCode(ISubject subject)
        {
            subject.DoOperation();
        }
    }
}
