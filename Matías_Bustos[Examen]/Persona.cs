using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matías_Bustos_Examen_
{
    abstract class Persona
    {
        protected string Nombre;
        protected int Edad;
        protected string Sexo;
        protected string Nacionalidad;
        protected Persona(string nombre, int edad, string sexo,string Nacionalidad)
        {
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
            this.Nacionalidad = Nacionalidad;
        }

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int Edad1 { get => Edad; set => Edad = value; }
        public string Sexo1 { get => Sexo; set => Sexo = value; }
        public string Nacionalidad1 { get => Nacionalidad; set => Nacionalidad = value; }
    }
}
