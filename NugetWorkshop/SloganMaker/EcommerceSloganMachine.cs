using System;

namespace SloganMaker
{
    public class EcommerceSloganMachine
    {
        private static readonly string[] partOne =
        {
            "Kings",
            "Fools",
            "DJ Bobo",
            "Noobs",
            "Children",
            "Explorers",
            "Grandparents"
        };
        private static readonly string[] partTwo =
        {
            "Ecommerce",
            "Shopping",
            "Selling"
        };

        private readonly Random rnd;

        public EcommerceSloganMachine()
        {
            rnd = new Random();
        }

        public string GenerateSlogan()
        {
            var firstPart = partOne[rnd.Next(0, partOne.Length - 1)];
            var secondPart = partTwo[rnd.Next(0, partTwo.Length - 1)];

            return $"{firstPart} of {secondPart}";
        }
    }
}