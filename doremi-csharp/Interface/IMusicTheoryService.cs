using doremi_csharp.Models;

namespace doremi_csharp.Interface
{
    public interface IMusicTheoryService
    {
        Scale BuildScale(string rootNote, Scale.ScaleType scaleType);
        Chord BuildChord(string rootNote, ChordType chordType);
    }
}