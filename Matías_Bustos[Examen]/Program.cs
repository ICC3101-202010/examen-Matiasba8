using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matías_Bustos_Examen_
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo VisitTeam = new Equipo("Chile", "Nacional");
            Equipo LocalTeam = new Equipo("Argentñina", "Nacional");
            //Ejemplo de jugadores:
            Jugador newjugado1 = new Jugador(1,"Sebastian", 21, "H", "Chile", 8, 5, 5, "Delantero",300000);
            Jugador newjugador2 = new Jugador(2, "Juan", 23, "H", "Chile", 5, 5, 8,"Medio Campista", 240000);
            Jugador newjugador3 = new Jugador(3, "Lucas", 26, "H", "Chile", 5, 7, 8, "Defensor", 200000);
            Jugador newjugadortest = new Jugador(3,"Ronaldinho", 40, "H", "Brasil", 10, 7, 10, "Delantero",1000000);

            //Agregar jugador tiene la funcionalidad de que hace un filtro c/r a la id de los jugadores para evitar agregar jugadores
            //repetidos, ademas de hacer un filtro si es que el equipo es nacional y el jugador que se va agregar no cumple con la nacionalidad
            //del equipo en el cual se va agregar , en la siguiente linea muestra los estados de si se pudo agregar los jugadores al equipo.
            Console.WriteLine(VisitTeam.AgregarJugador(newjugado1));
            //Intento de agregar 2 veces consecutivas el mismo jugador
            Console.WriteLine(VisitTeam.AgregarJugador(newjugado1));
            //Intento de agregar un jugador con distinta nacionalidad
            Console.WriteLine(VisitTeam.AgregarJugador(newjugadortest));

            //Agregar mas jugadores
            VisitTeam.AgregarJugador(newjugador2);
            VisitTeam.AgregarJugador(newjugador3);

            Medico medico = new Medico("Carlos", 43, "H", "Chile", 54,10000);
            Entrenador entrenador = new Entrenador("Lucas", 44, "H", "Chile", 65, 10000);

            //Las llamadas consecutivas a agregarmedico y agregarentrenador solo cambiaran el entrenador o el medico por uno nuevo.
            VisitTeam.AgregarMedico(medico);
            VisitTeam.AgregarEntrenador(entrenador);

            //Muestra al equipo
            VisitTeam.ShowTeam();

            
            //Elección al azar de un jugador lesionado para probar la funcionalidad:
            var rand = new Random();
            int value = rand.Next(0, 3);

            //Ejemplo del contructor de partido (el real recive mas parametros , estan señalados en la clase respectiva)
            Partido partido = new Partido(VisitTeam,LocalTeam);

            //Se elige un jugador al azar , y se testea la lesión del jugador
            entrenador.WarnedGame += partido.OnWarnedGame;
            VisitTeam.Jugadores1[value].Lesion1 = true;
            VisitTeam.Jugadores1[value].Playerinjured += entrenador.OnPlayerinjured;

            VisitTeam.Jugadores1[value].AvisarLesion(entrenador);
            
            

        }

        
    }
}
