using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pPatronesDiseño.Patrones.Comportamiento.Command
{
    public interface IDocumento
    {
        void Execute();
    }
    public class OpenDoc : IDocumento

    {
        private Doc documento;
        public OpenDoc(Doc documento)
        {
            this.documento = documento;
        }
        public void Execute()
        {
            documento.Open();
        }
    }
    public class Doc
    {
        public void Open()
        {
            MessageBox.Show("Abriendo el documento");
        }
    }
    public class Menu
    {
        IDocumento documento;
        public Menu(IDocumento documento)
        {
            this.documento = documento;
        }

        public void AbriDocumento()
        {
            documento.Execute();
        }
    }
}
