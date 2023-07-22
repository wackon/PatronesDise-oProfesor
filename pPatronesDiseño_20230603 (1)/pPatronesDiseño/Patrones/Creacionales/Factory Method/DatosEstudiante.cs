using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pPatronesDiseño.Patrones.Creacionales.Factory_Method
{
    public enum TipoEstudiante
    {
        Pregrado = 1,
        Postgrado = 2,
        SillasVacias = 3,
        BachillerExtendido =4
    }
    public class DatosEstudiante
    {
        public TipoEstudiante tipoEstudiante { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string TipoPago { get; set; }
        public double NotaGanar { get; set; }
    }
}
