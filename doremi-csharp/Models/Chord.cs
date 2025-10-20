namespace doremi_csharp.Models
{
    public class Chord
    {
        
        public enum ChordType
        {
            Major,
            Minor
        }
        
        public string Root { get; private set; }
        public ChordType Type { get; private set; }
        public List<string> Notes { get; private set; }
        
        public Chord () {}
        
        public Chord(string root, ChordType type, List<string> notes)
        {
            Root = root;
            Type = type;
            Notes = notes;
        }
    }
    
}