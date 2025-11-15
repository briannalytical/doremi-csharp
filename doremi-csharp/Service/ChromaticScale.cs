namespace doremi_csharp.Service
{
    public class ChromaticScale
    {

        private static readonly List<string> SharpNotes = new List<string>
        {
            "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"
        };


        private static readonly List<string> FlatNotes = new List<string>
        {
            "C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab", "A", "Bb", "B"
        };

        private static readonly Dictionary<string, bool> KeyUsesFlats = new Dictionary<string, bool>
        {
            { "C", false },
            { "Db", true },
            { "D", false },
            { "Eb", true },
            { "E", false },
            { "F", true },
            { "F#", false },
            { "G", false },
            { "Ab", true },
            { "A", false },
            { "Bb", true },
            { "B", false }
        };


        public List<string> GetChromaticScaleForKey(string rootNote)
        {
            bool usesFlats = KeyUsesFlats.ContainsKey(rootNote) && KeyUsesFlats[rootNote];

            return usesFlats
                ? new List<string>(FlatNotes)
                : new List<string>(SharpNotes);
        }
    }
}