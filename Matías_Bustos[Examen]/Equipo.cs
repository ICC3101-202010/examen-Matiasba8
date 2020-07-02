using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matías_Bustos_Examen_
{
    class Equipo
    {
        private string Nombre;
        //Indica si es nacional o de liga
        private string Tipo;
        //Indica que de que nacionalidad es el equipo (o cual es la nacionalidad de origen de la liga)
        //Participantes del equipo
        private List<Jugador> Jugadores = new List<Jugador>();
        private Medico Medico_E;
        private Entrenador Entrenador_E;

        public Equipo(string nombre, string tipo)
        {
            Nombre1 = nombre;
            Tipo1 = tipo;

        }

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Tipo1 { get => Tipo; set => Tipo = value; }
        internal List<Jugador> Jugadores1 { get => Jugadores; set => Jugadores = value; }
        internal Medico Medico_E1 { get => Medico_E; set => Medico_E = value; }
        internal Entrenador Entrenador_E1 { get => Entrenador_E; set => Entrenador_E = value; }

        //Retorna cero si es que no se pudo agregar el jugador dado que la nacionalidad del jugador no coincide con la del equipo
        //Solo retorna cero si es que el equipo es de tipo nacionalidad y no coincide con las condiciones destacadas anteriormente.
        public string AgregarJugador(Jugador NewJugador)
        {
            //En otro caso de que el equipo se de tipo liga , no hay que hacer ningun tipo de filtro de jugadores por nacionalidad
            //Dado que una liga pueden participar jugadores sin importar su nacionalidad.
            if (this.Tipo == "Liga")
            {
                if(!CheckPlayer(NewJugador))
                {
                    Jugadores.Add(NewJugador);
                    return "Jugador agregado con exito!";
                }
                else
                {
                    return "Este jugador ya existe en el equipo";
                }
                
            }
            //Caso en que el equipo es de tipo nacional (por lo cual el nombre del equipo contiene el nombre del pais ej: Chile, Argentina,etc)
            //Si es que es nacional por lo tanto solo se pueden agregar jugadores de esta nacionalidad
            else if (this.Tipo == "Nacional" && NewJugador.Nacionalidad1 == this.Nombre)
            {
                if (!CheckPlayer(NewJugador))
                {
                    Jugadores.Add(NewJugador);
                    return "Jugador agregado con exito!";
                }
                else
                {
                    return "Este jugador ya existe en el equipo";
                }
            }
            return "El jugador: "+ NewJugador.Nombre1 +" no se pudo agregar dado que su nacionalidad no coincide con el del equipo.";
            
            
        }
        //Las llamadas consecutivas a esta función solo iran cambiando el medico dado que solo existe un medico en el equipo!
        public void AgregarMedico(Medico NewMedico)
        {
            Medico_E = NewMedico;
        }
        //Lo mismo que para medico pero para entrenador.
        public void AgregarEntrenador(Entrenador NewEntrenador)
        {
            Entrenador_E = NewEntrenador;
        }
        public bool CheckPlayer(Jugador jugador)
        {
            foreach(Jugador jugador1 in Jugadores)
            {
                if(jugador1.Id == jugador.Id)
                {
                    return true;
                }
            }
            return false;
        }
        
        //Muestra la información del equipo
        public void ShowTeam()
        {
            try
            {
                Console.WriteLine("\n---------------------[|Equipo: " + this.Nombre1 + "|]---------------------" + "\n---------------------[|Tipo Equipo: " + this.Tipo + "|]---------------------");
                Console.WriteLine("\n[Entrenador]:\n");
                Entrenador_E.ShowInfo();
                Console.WriteLine("\n[Medico]:\n");
                Medico_E.ShowInfo();
                Console.WriteLine("\n[Jugadores]:\n");
                foreach (Jugador jugador in Jugadores)
                {
                    jugador.ShowInfo();
                }
                Console.WriteLine("\n");
            }
            catch
            {
                Console.WriteLine("Agrege por lo menos un jugador, medico y entrenador para poder mostrar toda la info del equipo");
            }
            
        }
    }
}
