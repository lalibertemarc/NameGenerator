namespace NameGen
{
    public static class Helpers
    {
        public static string CapitalizeFirstLetter(string word)
        {
            return char.ToUpper(word[0]) + word.Substring(1);
        }
    }
}
