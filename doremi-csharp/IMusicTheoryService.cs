using doremi_csharp.Models;
namespace doremi_csharp;


public interface IMusicTheoryService
{
    Scale BuildScale(string rootNote, ScaleType type);
    Chord BuildChord(string rootNote, ChordType type);
}