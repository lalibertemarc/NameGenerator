using System;
using System.Collections.Generic;

namespace NameGen.Services.Implementations
{
    public class NameGenService : INameGenService
    {
        private readonly IRandomEventHandler _randomEventHandler;
        
        public NameGenService(IRandomEventHandler randomEventHandler)
        {
            _randomEventHandler = randomEventHandler;
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
            var result = string.Empty;
            
            for (var i = 0; i < Configs.Range; i++, Configs.IndexOfFirstArray++)
            {
                result += _randomEventHandler.HandleSeparators(i);
                result += _randomEventHandler.AddSyllable();
            }

            return Helpers.CapitalizeFirstLetter(result);
        }
    }
}
