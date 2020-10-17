using System;

namespace NameGen
{
    public static class Helpers
    {
        public static string CapitalizeFirstLetter(string word)
        {
            return char.ToUpper(word[0]) + word.Substring(1);
        }

        public static T RandomFromArray<T>(T[] array)
        {
            var random = new Random();
            var start2 = random.Next(0, array.Length);
            return array[start2];
        }
    }
}
