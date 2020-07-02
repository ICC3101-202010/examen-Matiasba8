using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matías_Bustos_Examen_
{
    class Medico : Persona
    {
        private int P_Exp;
        private int Sueldo;
        public Medico(string nombre, int edad, string sexo, string Nacionalidad,int P_Exp,int Sueldo) : base(nombre, edad, sexo, Nacionalidad)
        {
            this.P_Exp = P_Exp;
            this.Sueldo1 = Sueldo;
        }

        public int P_Exp1 { get => P_Exp; set => P_Exp = value; }
        public int Sueldo1 { get => Sueldo; set => Sueldo = value; }

        //Evalua si es que hubo una posible lesión del jugador (devuelve true si es que el j esta lesionado)
        public bool Evaluar_L(Jugador jugador)
        {
            //Evaluar Jugador (dado que hubo una posible lesion o falta)
            return false;
        }
        //Se asume que dependiendo de un cierto nivel de exp la efictividad de curación puede ser mayor
        //Si es que el jugador se cura puede volver al partido.
        public void Curar(Jugador jugador)
        {

        }
        public void ShowInfo()
        {
            Console.WriteLine("Nombre: " + Nombre1 +" ,Nacionalidad: "+Nacionalidad1+ ", Edad: " + Edad1 + ", Sexo: " + Sexo1 + ", Rol: Medico" + ", Puntos de Experiencia: " + P_Exp + ", Sueldo: " + Sueldo1);
        }
    }
}
