using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace NameGen
{
    public class NameGenService : INameGenService
    {
        private readonly ILogger<NameGenService> _logger;
        private static readonly string[] Vowels = {"a", "e", "i", "o", "u", "y", "ie", "ae", "ui", "ion", "ius" , "iel" };
        private static readonly string[] Consonants =
        {
            "tau", "d", "g", "k", "m", "p", "x", "th", "r", "kh", "gh", "ro", "rd", "uk", "ok", "il",
            "kan", "gn", "md", "gr", "hel", "gon", "wen", "hil", "mn", "nor", "rod", "gw", "thr", "dha", "ech", "oth",
            "abd", "rk"
        };

        private readonly string[][] _mainArray = {Vowels, Consonants};
        private const float ChanceToBreak = 0.20f;

        public NameGenService(ILogger<NameGenService> logger)
        {
            _logger = logger;
        }

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
            var firstArrayAtStart = random.Next(0, 2);
            var result = string.Empty;
 
            for (var i = 0; i < 5; i++)
            {
                var indexOfFirstArray = firstArrayAtStart % 2;
                var indexOfSecondArray = random.Next(0, _mainArray[firstArrayAtStart % 2].Length);

                result += _mainArray[indexOfFirstArray][indexOfSecondArray];

                if (i >= 2 && random.NextDouble() < ChanceToBreak)
                {
                    break;
                }

                firstArrayAtStart+=1;
            }

            return Helpers.CapitalizeFirstLetter(result);
        }
    }
}
