using System.Collections.Generic;

namespace NameGen.Services
{
    public interface INameGenService
    {
        List<string> GenerateName(int n);
    }
}
