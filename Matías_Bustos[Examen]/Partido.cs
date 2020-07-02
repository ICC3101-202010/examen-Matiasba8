using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Matías_Bustos_Examen_
{
    class Partido
    {
        private Equipo Visita;
        private Equipo Local;
        //Contiene los jugadores que van a participar en el partido (puede ir cambiando a lo largo de la duración del partido 11 por equipo)
        private List<Jugador> JVisit;
        private List<Jugador> JLocal;
        //min
        private int Duracion;
        //Formato: 2-3 (Local primero y despues visita)
        private string Marcador;
        //Identifica si es que es un partido de liga o nacional.
        private string Tipo_partido;

        public Partido(Equipo visita, Equipo local, int duracion, string marcador, string tipo_partido, List<Jugador> JLocal, List<Jugador> JVisit)
        {
            //Si es que los tipos de equipos son iguales se asignan los atributos para el partido
            if(visita.Tipo1 == local.Tipo1)
            {
                Visita = visita;
                Local = local;
                Duracion = duracion;
                Marcador = marcador;
                Tipo_partido = tipo_partido;
                this.JLocal = JLocal;
                this.JVisit = JVisit;
            }
            //Notificación en consola en caso que el formato es erroneo.
            else
            {
                Console.WriteLine("Porfavor escoja equipos que tengan los mismos tipos (liga-liga o naciona-nacional)");
            }
        }
        //Solo de ejemplo para las notificaciones
        public Partido(Equipo visita, Equipo local)
        {
            if (visita.Tipo1 == local.Tipo1)
            {
                Visita = visita;
                Local = local;
            }
            //Notificación en consola en caso que el formato es erroneo.
            else
            {
                Console.WriteLine("Porfavor escoja equipos que tengan los mismos tipos (liga-liga o naciona-nacional)");
            }
        }

        public int Duracion1 { get => Duracion; set => Duracion = value; }
        public string Marcador1 { get => Marcador; set => Marcador = value; }
        public string Tipo_partido1 { get => Tipo_partido; set => Tipo_partido = value; }
        internal Equipo Visita1 { get => Visita; set => Visita = value; }
        internal Equipo Local1 { get => Local; set => Local = value; }

        public void OnWarnedGame(object source, JugadorEventArgs args)
        {
            Console.WriteLine("Partido a recivido la notificación del lesionado!");
        }
    }
}
