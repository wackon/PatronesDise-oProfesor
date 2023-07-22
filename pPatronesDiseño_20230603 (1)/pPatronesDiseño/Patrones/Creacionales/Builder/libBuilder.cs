using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pPatronesDiseño.Patrones.Creacionales.Builder
{
    //Ejemplo de hoja de vida, con datos de educación y experiencia laboral
    public class HojaVida
    {
        public IList<Educacion> FormacionEducativa;
        public IList<Trabajo> ExperienciaLaboral;
    }
    public class Educacion
    {
        public string NombrePrograma { get; set; }
        public string NombreInstitucion { get; set; }
        public string Tipo { get; set; } //Tipo - Puede ser: Bachillerato, profesional, postgrado, etc
        public DateTime FechaGrado { get; set; }
        public string Titulo { get; set; }
    }
    public class Trabajo
    {
        public string Cargo { get; set; }
        public string Funciones { get; set; }
        public string Compañia{ get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Activo { get; set; }
    }
    public class HojaVidaBuilder
    {
        private readonly HojaVida hojaVida = new HojaVida();
        public HojaVidaBuilder() { 
            hojaVida.FormacionEducativa= new List<Educacion>();
            hojaVida.ExperienciaLaboral= new List<Trabajo>();
        }
        public ColegioBuilder AgregarColegio()
        {
            return new ColegioBuilder(this, hojaVida);
        }
    }
    public class ColegioBuilder
    {
        private readonly Educacion educacion= new Educacion();
        private readonly HojaVidaBuilder hojaVidaBuilder;
        private readonly HojaVida hojaVida;
        public ColegioBuilder(HojaVidaBuilder resumeBuilder, HojaVida resume)
        {
            hojaVidaBuilder = resumeBuilder;
            hojaVida = resume;
            educacion.Tipo = "Colegio";
        }
        public ColegioBuilder AgregarNombre(string Nombre)
        {
            educacion.NombrePrograma = Nombre; 
            return this;
        }
        public ColegioBuilder AgregarInstitucion(string institucion)
        {
            educacion.NombreInstitucion = institucion;
            return this;
        }
        public ColegioBuilder AgregarFechaGrado(DateTime fechaGrado)
        {
            educacion.FechaGrado = fechaGrado;
            return this;
        }
        public ColegioBuilder AgregarTitulo (string Titulo)
        {
            educacion.Titulo = Titulo;
            return this;
        }
        public EducacionUniversitariaBuilder AgregarEducacionUniversitaria()
        {
            hojaVida.FormacionEducativa.Add(educacion);
            return new EducacionUniversitariaBuilder(hojaVidaBuilder, hojaVida);
        }
    }
    public class EducacionUniversitariaBuilder
    {
        private readonly Educacion educacion = new Educacion();
        private readonly HojaVidaBuilder hojaVidaBuilder;
        private readonly HojaVida hojaVida;
        public EducacionUniversitariaBuilder(HojaVidaBuilder resumeBuilder, HojaVida resume)
        {
            hojaVidaBuilder= resumeBuilder;
            hojaVida = resume;
            educacion.Tipo = "Universitario";
        }
        public EducacionUniversitariaBuilder AgregarNombre(string Nombre)
        {
            educacion.NombrePrograma = Nombre;
            return this;
        }
        public EducacionUniversitariaBuilder AgregarInstitucion(string Nombre)
        {
            educacion.NombreInstitucion = Nombre;
            return this;
        }
        public EducacionUniversitariaBuilder AgregarFechaGrado(DateTime fechaGrado)
        {
            educacion.FechaGrado = fechaGrado; 
            return this;
        }
        public EducacionUniversitariaBuilder AgregarTitulo(string Titulo)
        {
            educacion.Titulo = Titulo;
            return this;
        }
        public ExperienciaLaboralBuilder AgregarExperienciaLaboral()
        {
            hojaVida.FormacionEducativa.Add(educacion);
            return new ExperienciaLaboralBuilder(hojaVidaBuilder, hojaVida);
        }
    }
    public class ExperienciaLaboralBuilder
    {
        private readonly Trabajo trabajo = new Trabajo();
        private readonly HojaVidaBuilder hojaVidaBuilder;
        private readonly HojaVida hojaVida;
        public ExperienciaLaboralBuilder(HojaVidaBuilder resumeBuilder, HojaVida resume)
        {
            hojaVidaBuilder= resumeBuilder;
            hojaVida= resume;
        }
        public ExperienciaLaboralBuilder AgregarCargo(string cargo)
        {
            trabajo.Cargo = cargo;
            return this;
        }
        public ExperienciaLaboralBuilder AgregarFunciones(string funciones)
        {
            trabajo.Funciones = funciones;
            return this;
        }
        public ExperienciaLaboralBuilder AgregarCompañia(string compañia)
        {
            trabajo.Compañia = compañia; 
            return this;
        }
        public ExperienciaLaboralBuilder AgregarFechaInicio(DateTime fechaInicio)
        {
            trabajo.FechaInicio = fechaInicio;
            return this;
        }
        public ExperienciaLaboralBuilder AgregarFechaFin(DateTime fechaFin)
        {
            trabajo.FechaFin = fechaFin;
            return this;
        }
        public ExperienciaLaboralBuilder EstaActivo(bool Activo)
        {
            trabajo.Activo = Activo;
            return this;
        }
        public ExperienciaLaboralBuilder AgregarExperienciaLaboral()
        {
            hojaVida.ExperienciaLaboral.Add(trabajo);
            return new ExperienciaLaboralBuilder(hojaVidaBuilder, hojaVida);
        }
        public HojaVida Build()
        {
            hojaVida.ExperienciaLaboral.Add(trabajo);
            return hojaVida;
        }
    }
}
