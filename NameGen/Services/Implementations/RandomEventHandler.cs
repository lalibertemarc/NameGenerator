using System;

namespace NameGen.Services.Implementations
{
    public class RandomEventHandler : IRandomEventHandler
    {
        public string HandleSeparators(int index)
        {
            if (index > 1 && index < Configs.Range && new Random().NextDouble() < Configs.ChanceOfSeparator)
            {
                return Helpers.RandomFromArray(Configs.Separators);
            }

            return string.Empty;
        }

        public string AddSyllable()
        {
            return Helpers.RandomFromArray(Configs.MainArray[Configs.IndexOfFirstArray % 2]);
        }
    }
}
