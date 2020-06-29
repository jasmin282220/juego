using System;

namespace piedra_papel_o_tijera
{
    class Program
    {
        static void Main(string[] args)
        {


            Random rnd = new Random();

            int jueg = 1, jugada;
            string jugador, jugadas;
            string[] eleccion = { "Piedra", "Papel", "Tijera" };

            while (jueg == 1)
            {
                Console.WriteLine("Seleccione:[1:Piedra: 2:Papel: 3:Tijera]");
                jugada = int.Parse(Console.ReadLine());
                jugador = eleccion[jugada - 1];
                jugadas = eleccion[rnd.Next(0, 3)];

                if ((jugador == "Piedra") && (jugadas == "Tijera"))
                    Console.WriteLine("Ganaste, la maquina jugo:" + jugadas + "\n");

                else if ((jugador == "Papel") && (jugadas == "Piedra"))
                    Console.WriteLine("Ganaste,la maquina jugo:" + jugadas + "\n");

                else if ((jugador == "Tijera") && (jugadas == "Papel"))
                    Console.WriteLine("Ganaste,la maquina jugo:" + jugadas + "\n");

                if ((jugadas == "Piedra") && (jugador == "Tijera"))
                    Console.WriteLine("Acaba de ganar la maquina porque jugo:" + jugadas + "\n");
                else if ((jugadas == "Papel") && (jugador == "Piedra"))
                    Console.WriteLine("Acaba de ganar la maquina porque jugo:" + jugadas + "\n");

                else if ((jugadas == "Tijera") && (jugador == "Papel"))
                    Console.WriteLine("Acaba de ganar la maquina porque jugo:" + jugadas + "\n");


                if (((jugadas == "Piedra") && (jugador == "Piedra")) && ((jugadas == "Papel") || (jugador == "Papel")) || ((jugadas == "Tijera") && (jugador == "Tijera")))

                    Console.Write("Han quedado empate\n");


                Console.Write("\n Desea continuar jugando: 1:si: 0:no");
                jueg = int.Parse(Console.ReadLine());

            }
        }
    }
}
