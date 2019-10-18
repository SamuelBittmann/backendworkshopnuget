using System;
using SloganMaker;

namespace NugetWorkshop
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Press enter to create a slogan, press \"q\" to quit.");

            var input = ConsoleKey.Q;

            var program = new Program();

            do
            {
                input = Console.ReadKey().Key;
                if (input == ConsoleKey.Enter)
                {
                    Console.WriteLine($"{program.GenerateSlogan()}\n");
                }
            } while (input != ConsoleKey.Q);
        }

        private readonly EcommerceSloganMachine sloganMachine;

        private Program()
        {
            sloganMachine = new EcommerceSloganMachine();
        }

        private string GenerateSlogan()
        {
            return sloganMachine.GenerateSlogan();
        }
    }
}