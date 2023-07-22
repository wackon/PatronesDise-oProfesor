using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pPatronesDiseño.Patrones.Creacionales.Factory_Method
{
    public abstract class EstudianteCreator
    {
        public DatosEstudiante datosEstudiante;
        public abstract IEstudiante FactoryMethod(); 
        public string Consultar()
        {
            var estudiante = FactoryMethod();
            estudiante.ConsultarNotaGanar();
            estudiante.ConsultarTipoPago();
            return "El estudiante " + datosEstudiante.Nombre + " " +
                    datosEstudiante.Apellidos + "\n" +
                    ", es de tipo: " + datosEstudiante.tipoEstudiante +
                    "\nEl pago de matrícula: " + datosEstudiante.TipoPago +
                    "\nEl CRUD implementado es: " + estudiante.CRUD_DB();
        }
    }
}
