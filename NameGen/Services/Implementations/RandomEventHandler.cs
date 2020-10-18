using NameGen.Configs;
using System;

namespace NameGen.Services.Implementations
{
    public class RandomEventHandler : IRandomEventHandler
    {
        private readonly IConfigs _configs;

        public RandomEventHandler(IConfigs configs)
        {
            _configs = configs;
        }
        public string HandleSeparators(int index)
        {
            if (index > 1 && (index < _configs.Range - 1) && new Random().NextDouble() < _configs.ChanceOfSeparator)
            {
                return Helpers.RandomFromArray(_configs.Separators);
            }

            return string.Empty;
        }

        public string AddSyllable()
        {
            return Helpers.RandomFromArray(_configs.MainArray[_configs.IndexOfFirstArray % 2]);
        }
    }
}
