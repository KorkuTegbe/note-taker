using System;
using NoteTaker;

class Program
{
    static void Main()
    {
        NotesManager notesManager = new NotesManager();

        while (true)
        {
            Console.WriteLine("1. Add Note");
            Console.WriteLine("2. Display All Notes");
            Console.WriteLine("3. Edit Note");
            Console.WriteLine("4. Delete Note");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            if(int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        notesManager.AddNote();
                        break;
                    case 2:
                        Console.WriteLine("All Notes:");
                        notesManager.DisplayAllNotes();
                        break;
                    case 3:
                        notesManager.EditNote();
                        break;
                    case 4:
                        notesManager.DeleteNote();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again\n");
            }
        }
    }
} 