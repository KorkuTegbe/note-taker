namespace NoteTaker
{
    class NotesManager
    {
        private List<Note> notes = new List<Note>();

        // AddNote
        public void AddNote()
        {
            Console.Write($"Enter note title: ");
            string title = Console.ReadLine();

            Console.Write($"Enter note content: ");
            string content = Console.ReadLine();

            Note newNote = new Note(title, content);
            notes.Add(newNote);
            Console.WriteLine("Note added successfully!\n");
        }
        // DisplayAllNotes
        public void DisplayAllNotes()
        {
            foreach (var note in notes)
            {
                note.DisplayNote();
            }
        }
        // EditNote
        public void EditNote() // index of note to delete, newtitle, newcontent
        {
            Console.Write($"Enter the index of the note you wish to edit: ");
            if(int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < notes.Count)
            {
                Console.Write("Enter new Note Title: ");
                string newTitle = Console.ReadLine();

                Console.Write("Enter new Note Content: ");
                string newContent = Console.ReadLine();

                notes[index].UpdateNote(newTitle, newContent);
                Console.WriteLine("Note edited successfully!!\n");
            }
            else
            {
                Console.WriteLine("Invalid index. Note not found!\n");
            }
        }
        // DeleteNote
        public void DeleteNote()
        {
            Console.Write($"Enter the index of the note you wish to delete: ");
            if(int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < notes.Count)
            {
                notes.RemoveAt(index);
                Console.WriteLine("Note deleted successfully!!\n");
            }
            else
            {
                Console.WriteLine("Invalid index. Note not found!\n");
            }
        }     
    }
}