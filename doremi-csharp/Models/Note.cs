namespace doremi_csharp.Models
{
    public class Note
    {
        public string Name { get; private set; }
        
        public Note(string name)
        {
            Name = name;
        }
    }
}