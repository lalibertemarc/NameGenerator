using System;
using System.Collections.Generic;

namespace NameGen
{
    public class NameGenService : INameGenService
    {
        private static readonly string[] Vowels = {"a", "e", "i", "o", "u", "y", "ie", "ae", "ui", "ion", "ius" , "iel","oo", "ou","au" };
        private static readonly string[] Consonants =
        {
            "tau", "d", "g", "k", "m", "p", "x", "th", "r", "kh", "gh", "ro", "rd", "uk", "ok", "il",
            "kan", "gn", "md", "gr", "hel", "gon", "wen", "hil", "mn", "nor", "rod", "gw", "thr", "dha", "ech", "oth",
            "abd", "rk", "ck"
        };
        private static readonly string[] Separators = {"-", "'", " "};
        private readonly string[][] _mainArray = {Vowels, Consonants};

        private const float ChanceOfSeparator = 0.1f;

        public List<string> GenerateName(int n)
        {
            var output = new List<string>();
            for (var i = 0; i < n; i++)
            {
                var name = GenerateMedievalName();
                Console.WriteLine(name);
                output.Add(name);
            }
            return output;
        }
        
        private string GenerateMedievalName()
        {
            var random = new Random();
            var indexOfFirstArray = random.Next(0, 2);
            var range = random.Next(3, 7);

            var result = string.Empty;
            
            for (var i = 0; i < range; i++, indexOfFirstArray++)
            {
                if (i > 1 && i < range && random.NextDouble() < ChanceOfSeparator)
                {
                    result += Helpers.RandomFromArray(Separators);
                }

                result += Helpers.RandomFromArray(_mainArray[indexOfFirstArray % 2]);
            }

            return Helpers.CapitalizeFirstLetter(result);
        }
    }
}
