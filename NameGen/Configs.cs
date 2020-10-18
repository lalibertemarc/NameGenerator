using System;

namespace NameGen
{
    public static class Configs
    {
        public const float ChanceOfSeparator = 0.20f;
        private const int MinimumRange = 3;
        private const int MaximumRange = 6;

        private static readonly string[] Vowels = { "a", "e", "i", "o", "u", "y", "ie", "ae", "ui", "ion", "ius", "iel", "oo", "ou", "au" };
        private static readonly string[] Consonants =
        {
            "tau", "d", "g", "k", "m", "p", "x", "th", "r", "kh", "gh", "ro", "rd", "uk", "ok", "il",
            "kan", "gn", "md", "gr", "hel", "gon", "wen", "hil", "mn", "nor", "rod", "gw", "thr", "dha", "ech", "oth",
            "abd", "rk", "ck"
        };

        public static readonly string[] Separators = { "-", "'", " " };

        public static readonly string[][] MainArray = { Vowels, Consonants };

        public static int Range  = new Random().Next(MinimumRange,MaximumRange);
        public static int IndexOfFirstArray = new Random().Next(0, 2);
    }
}
