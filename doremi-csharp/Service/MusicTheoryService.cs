using doremi_csharp.Models;
using System.Collections.Generic;
using doremi_csharp.Interface;
using doremi_csharp.Service;

namespace doremi_csharp.Services
{
    public class MusicTheoryService : IMusicTheoryService
    {
        private readonly ChromaticScale _chromaticScale;
        
        public MusicTheoryService()
        {
            _chromaticScale = new ChromaticScale();
        }

        public Scale BuildScale(string rootNote, ScaleType scaleType)
        {
            // TODO: Implement scale building
            throw new NotImplementedException();
        }

        public Chord BuildChord(string rootNote, ChordType chordType)
        {
            // TODO: Implement chord building
            throw new NotImplementedException();
        }
    }
}