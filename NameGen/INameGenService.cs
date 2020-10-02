using System.Collections.Generic;

namespace NameGen
{
    public interface INameGenService
    {
        List<string> GenerateName(int n);
    }
}
