using System;

namespace Sinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Insira um número inteiro.");

            int númeroint;
            string número = Console.ReadLine(); 
            bool letra = Int32.TryParse(número, out númeroint);
            Console.ForegroundColor = ConsoleColor.Green;
            if (!letra)
            {
                Console.WriteLine($"O valor {número} não é válido.");
                Console.ResetColor();
                Environment.Exit(-1);
            }
            else
            {  
                if (númeroint > 0)
                {
                    Console.WriteLine($"O número {número} é positivo.");
                }
                else if (númeroint == 0)
                {
                    Console.WriteLine($"O número {número} é zero.");
                }
                else if (númeroint < 0)
                {
                    Console.WriteLine($"O número {número} é negativo");
                }
            }
            Console.ResetColor();
            Console.ReadKey();
            


            


        }
    }
}
