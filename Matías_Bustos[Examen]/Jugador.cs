using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Matías_Bustos_Examen_
{
    class Jugador : Persona
    {
        private int id;
        private int P_Ataque;
        private int P_Defensa;
        private int N_Camiseta;
        private int Sueldo;
        //Establece las posiciones actuales en el partido
        //Tanto como arquero , delantero , etc.
        private string Rol;
        //Si es true significa que el jugador tiene una lesión
        private bool Lesion;
        public Jugador(int id,string nombre, int edad, string sexo, string Nacionalidad, int P_Ataque, int P_Defensa, int N_Camiseta, string Rol,int Sueldo) : base(nombre, edad, sexo, Nacionalidad)
        {
            this.Puntos_Ataque1 = P_Ataque;
            this.Puntos_Defensa1 = P_Defensa;
            this.Numero_Camiseta1 = N_Camiseta;
            this.Rol1 = Rol;
            this.Id = id;
            this.Sueldo1 = Sueldo;
        }

        public int Puntos_Ataque1 { get => P_Ataque; set => P_Ataque = value; }
        public int Puntos_Defensa1 { get => P_Defensa; set => P_Defensa = value; }
        public int Numero_Camiseta1 { get => N_Camiseta; set => N_Camiseta = value; }
        public string Rol1 { get => Rol; set => Rol = value; }
        public bool Lesion1 { get => Lesion; set => Lesion = value; }
        public int Id { get => id; set => id = value; }
        public int Sueldo1 { get => Sueldo; set => Sueldo = value; }

        public void AvisarLesion(Entrenador entrenador)
        {
            if(Lesion == true)
            {
                Console.WriteLine("Jugador: "+Nombre1 + " se ha lesionado...\nNotificando a entrenador...\n");
                Thread.Sleep(2500);
                OnPlayerinjured(this);
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Nombre: "+Nombre1 +", Nacionalidad: "+Nacionalidad1+", Edad: "+Edad1+", Sexo: "+Sexo1+", Rol: "+Rol1+", N°Camiseta: "+Numero_Camiseta1+" Puntos de Ataque: "+Puntos_Ataque1+", Puntos de Defensa: "+Puntos_Defensa1+", Sueldo: "+Sueldo1);
        }

        public delegate void PlayerinjuredEventHandler(object source,JugadorEventArgs args);

        public event PlayerinjuredEventHandler Playerinjured;
    
        protected virtual void OnPlayerinjured(Jugador jugador)
        {
            if (Playerinjured != null)
            {
                Playerinjured(this, new JugadorEventArgs() {id = jugador.Id,Lesion = jugador.Lesion1});
            }
        }
    }
}
