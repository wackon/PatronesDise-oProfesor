using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pPatronesDiseño.Patrones.Creacionales.Factory_Method
{
    internal class PostgradoCreator : EstudianteCreator
    {
        public PostgradoCreator(DatosEstudiante _datosEstudiante)
        {
            datosEstudiante = _datosEstudiante;
        }
        public override IEstudiante FactoryMethod()
        {
            return new EstudiantePostgrado(datosEstudiante);
        }
    }
    public class EstudiantePostgrado : IEstudiante
    {
        DatosEstudiante datosEstudiante;
        public EstudiantePostgrado(DatosEstudiante _datosEstudiante)
        {
            datosEstudiante = _datosEstudiante;
        }
        public void ConsultarNotaGanar()
        {
            datosEstudiante.NotaGanar = 3.5;
        }

        public void ConsultarTipoPago()
        {
            datosEstudiante.TipoPago = "Pago por créditos, y por programa";
        }

        public string CRUD_DB()
        {
            return "Proceso inserción, actualización, desactivación de estudiante de postgrado";
        }
    }
}
