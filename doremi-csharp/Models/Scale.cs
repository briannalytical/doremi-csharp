namespace doremi_csharp.Models;

public class Scale
{
    public enum ScaleType
    {
        Major,
        RelativeMinor
    }
    public string Root { get; init; }
    public ScaleType Type { get; init; }
    public IReadOnlyList<string> Notes { get; init; }

    public Scale(string root, ScaleType type, IReadOnlyList<string> notes)
    {
        Root = root;
        Type = type
        Notes = notes;
    }
}