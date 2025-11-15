using doremi_csharp.Models;

namespace doremi_csharp.Service
{
    public class MusicTheoryService : IMusicTheoryService
    {
        public Scale BuildScale(string rootNote, ScaleType scaleType)
        {
            try
            {

            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public Chord BuildChord(string rootNote, ChordType chordType)
        {
            // TODO: Build the chord
            throw new NotImplementedException();
        }
    }
}