using doremi_csharp.Models;

namespace doremi_csharp.Service  // or .Services, whichever you're using
{
    public interface IMusicTheoryService
    {
        Scale BuildScale(string rootNote, ScaleType scaleType);
        Chord BuildChord(string rootNote, ChordType chordType);
    }
}