namespace NoteTaker
{
    public class Note
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModified { get; private set; }

        public Note(string title, string content)
        {
            Title = title;
            Content = content;
            CreatedAt = LastModified = DateTime.Now;
        }

        public void DisplayNote()
        {
            Console.WriteLine($"Title: {Title}\nContent: {Content}\nCreatedAt: {CreatedAt}\n");
        }

        public void UpdateNote(string newTitle, string newContent)
        {
            Title = newTitle;
            Content = newContent;
            LastModified = DateTime.Now;
        }
    }
}