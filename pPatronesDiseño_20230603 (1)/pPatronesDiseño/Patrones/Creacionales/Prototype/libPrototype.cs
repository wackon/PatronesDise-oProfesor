using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pPatronesDiseño.Patrones.Creacionales.Prototype
{
    public interface IEstudiantePrototipo
    {
        IEstudiantePrototipo Clone();
    }
    public class Estudiante : IEstudiantePrototipo
    {
        public Estudiante(string documento, string nombre, string programa, string pensum, string tipoPrograma) {
            Documento = documento;
            Nombre = nombre;
            Programa = programa;
            Pensum = pensum;
            TipoPrograma = tipoPrograma;
        }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Programa { get; set; }
        public string TipoPrograma { get; set; } //Tecnología, técnica, Universitario, postgrado, etc
        public string Pensum { get; set; }
        public string Mensaje { get; set; }
        public IEstudiantePrototipo Clone()
        {
            Mensaje = ($"Clona un estudiante del programa: {Programa}. \n" +
                       $"que es del tipo: {TipoPrograma}. Con pensum {Pensum}.");
            return (IEstudiantePrototipo)this.MemberwiseClone();
        }
    }
    public class GestionEstudiantes
    {
        private Dictionary<string, IEstudiantePrototipo> Estudiantes =
            new Dictionary<string, IEstudiantePrototipo>();
        public IEstudiantePrototipo this[string key]
        {
            get { return Estudiantes[key]; }
            set { Estudiantes.Add(key, value); }
        }
    }
    public class modelEstudiante
    {
        public modelEstudiante(string documento, string nombre)
        {
            Documento = documento ?? throw new ArgumentNullException(nameof(documento));
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
        }

        public string Documento { get; set; }
        public string Nombre { get; set; }
    }
}
