using doremi_csharp.Models;
using doremi_csharp.Interface;

namespace doremi_csharp.Service
{
    public class MusicTheoryService : IMusicTheoryService
    {
        private readonly ChromaticScale _chromaticScale;
        
        public MusicTheoryService()
        {
            _chromaticScale = new ChromaticScale();
        }

        public Scale BuildScale(string rootNote, Scale.ScaleType scaleType)
        {
            List<string> chromaticNotes = _chromaticScale.GetChromaticScaleForKey(rootNote);
            
            int rootIndex = chromaticNotes.IndexOf(rootNote);
            
            int[] intervals = scaleType == ScaleType.Major 
                ? new int[] { 0, 2, 4, 5, 7, 9, 11, 12 }
                : new int[] { 0, 2, 3, 5, 7, 8, 10, 12 };
    
            List<string> scaleNotes = new List<string>();
            foreach (int interval in intervals)
            {
                int noteIndex = (rootIndex + interval) % chromaticNotes.Count;
                scaleNotes.Add(chromaticNotes[noteIndex]);
            }
    
            return new Scale(rootNote, scaleType, scaleNotes);
        }

        public Chord BuildChord(string rootNote, ChordType chordType)
        {
            // TODO: Implement chord building
            throw new NotImplementedException();
        }
    }
}