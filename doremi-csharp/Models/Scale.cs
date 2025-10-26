using System.ComponentModel.Design.Serialization;

namespace doremi_csharp.Models;

public class Scale
{
    public enum ScaleType
    {
        Major,
        RelativeMinor
    }

    public string Root { get; private set; }
    public ScaleType Type { get; private set; }
    public IReadOnlyList<string> Notes { get; private set; }
    

    public Scale(string root, ScaleType type, IReadOnlyList<string> notes)
    {
        Root = root;
        Type = type;
        Notes = notes;
    }
}