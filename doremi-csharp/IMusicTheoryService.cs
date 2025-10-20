using doremi_csharp.Models;
namespace doremi_csharp;


public interface IMusicTheoryService
{
    Scale BuildScale(string rootNote, Scale.ScaleType type);
    Chord BuildChord(string rootNote, Chord.ChordType type);
}