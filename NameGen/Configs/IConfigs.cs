namespace NameGen.Configs
{
    public interface IConfigs
    {
        int Range { get; }
        int IndexOfFirstArray { get; set; }
        int MinimumRange { get;}
        int MaximumRange { get; }
        string[][] MainArray { get; }
        string[] Separators { get; }
        float ChanceOfSeparator { get; }
        void ResetConfigs();
    }
}
