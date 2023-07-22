using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pPatronesDiseño.Patrones.Creacionales.Factory_Method
{
    public class PregradoCreator : EstudianteCreator
    {
        public PregradoCreator(DatosEstudiante _datosEstudiante)
        {
            datosEstudiante = _datosEstudiante;
        }
        public override IEstudiante FactoryMethod()
        {
            //Retorna un estudiante de tipo Estudiante Pregrado
            return new EstudiantePregrado(datosEstudiante);
        }
    }
    public class EstudiantePregrado : IEstudiante
    {
        DatosEstudiante datosEstudiante;
        public EstudiantePregrado(DatosEstudiante _datosEstudiante)
        {
            datosEstudiante = _datosEstudiante;
        }
        public void ConsultarNotaGanar()
        {
            datosEstudiante.NotaGanar = 3.0;
        }

        public void ConsultarTipoPago()
        {
            datosEstudiante.TipoPago = "Pago cero. Programa de matrícula cero";
        }

        public string CRUD_DB()
        {
            return "Proceso inserción, actualización, eliminación de estudiante de pregrado";
        }
    }
}
