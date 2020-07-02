using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Matías_Bustos_Examen_
{
    class Entrenador : Persona
    {
        private int P_Tactica;
        private int Sueldo;
        public Entrenador(string nombre, int edad, string sexo, string Nacionalidad,int P_Tactica,int Sueldo) : base(nombre, edad, sexo, Nacionalidad)
        {
            this.P_Tactica1 = P_Tactica;
            this.Sueldo1 = Sueldo;
        }

        public int P_Tactica1 { get => P_Tactica; set => P_Tactica = value; }
        public int Sueldo1 { get => Sueldo; set => Sueldo = value; }

        public void Cambiar_Jugador(Jugador jcambio)
        {
            Console.WriteLine("\n'Metodo de cambio de jugador'");
        }
        public void OnPlayerinjured(object source, JugadorEventArgs args)
        {
            Console.WriteLine("Entrenador: "+this.Nombre1+" a recivido la notificación...\nEntrenador notificando al partido...\n");
            Thread.Sleep(2500);
            OnWarnedGame(args.id,args.Lesion);

            //Ejecución del cambio de jugador
            var value = new Object();
            //Simulación con un objecto ambiguo
            Cambiar_Jugador((value as Jugador));
        }

        public void ShowInfo()
        {
            Console.WriteLine("Nombre: " + Nombre1 +", Nacionalidad: "+Nacionalidad+ ", Edad: " + Edad1 + ", Sexo: " + Sexo1 + ", Rol: Entrenador" + ", Puntos Tacticos: " + P_Tactica1+", Sueldo: " + Sueldo1);
        }

        public delegate void WarnedGameEventHandler(object source, JugadorEventArgs args);

        public event WarnedGameEventHandler WarnedGame;
        protected virtual void OnWarnedGame(int id,bool lesionado)
        {
            if (WarnedGame != null)
            {
                WarnedGame(this, new JugadorEventArgs() { id = id, Lesion = lesionado });
            }
        }
    }
}
