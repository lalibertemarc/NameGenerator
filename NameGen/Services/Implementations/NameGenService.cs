using NameGen.Configs;
using System;
using System.Collections.Generic;

namespace NameGen.Services.Implementations
{
    public class NameGenService : INameGenService
    {
        private readonly IRandomEventHandler _randomEventHandler;
        private readonly IConfigs _configs;

        public NameGenService(IRandomEventHandler randomEventHandler, IConfigs configs)
        {
            _randomEventHandler = randomEventHandler;
            _configs = configs;
        }

        public List<string> GenerateName(int n)
        {
            var output = new List<string>();
            for (var i = 0; i < n; i++)
            {
                var name = GenerateMedievalName();
                Console.WriteLine(name);
                output.Add(name);
                _configs.ResetConfigs();
            }
            return output;
        }
        
        private string GenerateMedievalName()
        {
            var result = string.Empty;
            
            for (var i = 0; i < _configs.Range; i++, _configs.IndexOfFirstArray++)
            {
                result += _randomEventHandler.HandleSeparators(i);
                result += _randomEventHandler.AddSyllable();
            }

            return Helpers.CapitalizeFirstLetter(result);
        }
    }
}
