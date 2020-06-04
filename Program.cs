using System;

namespace Sinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Insira um número inteiro.");

            int número = Convert.ToInt32(Console.ReadLine()); 
            Console.ForegroundColor = ConsoleColor.Green;

            if (número < 0) 
            {
                Console.WriteLine($"O número {número} é negativo");
            }
            else if (número == 0)
            {
                Console.WriteLine($"O número {número} é zero");
            }
            else if (número > 0)
            {
                Console.WriteLine($"O número {número} é positivo.");
            }
            else 
            {
                Console.WriteLine("número invalido.");
            }
            Console.ForegroundColor = ConsoleColor.Gray;


        }
    }
}
