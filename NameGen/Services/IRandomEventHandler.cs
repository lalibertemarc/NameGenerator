namespace NameGen.Services
{
    public interface IRandomEventHandler
    {
        string HandleSeparators(int index);
        string AddSyllable();
    }
}
