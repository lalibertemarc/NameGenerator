using System;

namespace NameGen.Configs
{
    public class Configs : IConfigs
    {
        private readonly string[] _vowels = { "a", "e", "i", "o", "u", "y", "ie", "ae", "ui", "ion", "ius", "iel", "oo", "ou", "au" };
        private readonly string[] _consonants =
        {
            "tau", "d", "g", "k", "m", "p", "x", "th", "r", "kh", "gh", "ro", "rd", "uk", "ok", "il",
            "kan", "gn", "md", "gr", "hel", "gon", "wen", "hil", "mn", "nor", "rod", "gw", "thr", "dha", "ech", "oth",
            "abd", "rk", "ck"
        };

        public Configs()
        {
            ResetConfigs();
            MainArray = new[] { _vowels, _consonants };
            Separators =new[] { "-", "'", " " };
            ChanceOfSeparator = 0.20f;
        }

        public void ResetConfigs()
        {
            var random = new Random();
            MinimumRange = random.Next(2, 4);
            MaximumRange = random.Next(5, 7);
            Range = random.Next(MinimumRange, MaximumRange);
            IndexOfFirstArray = random.Next(0, 2);
        }

        public int Range { get; private set; }
        public int IndexOfFirstArray { get; set; }
        public int MinimumRange { get; private set; }
        public int MaximumRange { get; private set; }
        public string[][] MainArray { get; }
        public string[] Separators { get; }
        public float ChanceOfSeparator { get; }
    }
}
