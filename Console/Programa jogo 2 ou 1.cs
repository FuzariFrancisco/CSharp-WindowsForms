using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int player_1, player_2;

            Random random = new Random();
            int player_pc = random.Next(1, 2);

            Console.WriteLine("Player 1 Digite 2 ou 1.. "); player_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Player 2 Digite 2 ou 1.. "); player_2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A máquina escolheu " + player_pc);
            Console.WriteLine();
            //EMPATES
            if (player_1 + player_2 + player_pc == 3)
            {
                Console.WriteLine("EMPATE");
            }
            else if (player_1 + player_2 + player_pc == 6)
            {
                Console.WriteLine("EMPATE");
            }
            //vitórias player 1
            else if (player_1 == 1 && player_2 == 2 && player_pc == 2)
            {
                Console.WriteLine("PLAYER 1 GANHOU");
            }
            else if (player_1 == 2 && player_2 == 1 && player_pc == 1)
            {
                Console.WriteLine("PLAYER 1 GANHOU");
            }
            //vitórias player 2
            else if (player_2 == 1 && player_1 == 2 && player_pc == 2)
            {
                Console.WriteLine("PLAYER 2 GANHOU");
            }
            else if (player_2 == 2 && player_1 == 1 && player_pc == 1)
            {
                Console.WriteLine("PLAYER 2 GANHOU");
            }
            //vitórias pc
            else if (player_pc == 1 && player_1 == 2 && player_2 == 2)
            {
                Console.WriteLine("A MÁQUINA GANHOU");
            }
            else if (player_pc == 2 && player_1 == 1 && player_2 == 1)
            {
                Console.WriteLine("A MÁQUINA GANHOU");
            }

            Console.ReadKey();






        }
    }
}
