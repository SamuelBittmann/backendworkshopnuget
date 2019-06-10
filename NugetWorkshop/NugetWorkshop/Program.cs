using System;

namespace NugetWorkshop
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var sloganMachine = new MySloganMachine();
            
            Console.WriteLine("Press enter to create a slogan, press \"q\" to quit.");

            var input = ConsoleKey.Q;

            do
            {
                input = Console.ReadKey().Key;
                if (input == ConsoleKey.Enter)
                {
                    Console.WriteLine($"{sloganMachine.GenerateSlogan()}\n");
                }
            } while (input != ConsoleKey.Q);
        }
    }
}