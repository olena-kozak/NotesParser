using NotesParser;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string anotherInput = Console.ReadLine();
        string thirdInput = Console.ReadLine();


        NoteParser noteParser = new NoteParser(input);
        Note note = noteParser.ParseNote();

        NoteParser anotherNoteParser = new NoteParser(anotherInput);
        Note anotherNote = anotherNoteParser.ParseNote();

        NoteParser thirsNoteParser = new NoteParser(thirdInput);
        Note thirdNote = thirsNoteParser.ParseNote();

        List<Note> notes = new List<Note>();
        notes.Add(note);
        notes.Add(anotherNote);
        notes.Add(thirdNote);
        notes.Add(new Note { Digit = 4, Sign = "--" });
        notes.Add(new Note { Digit = 3 });
        notes.Add(new Note { Digit = 1, Sign = "+" });
        var notes2 = notes.OrderBy(x => x).ToList();

        Console.WriteLine("Sorted List");
        foreach (Note item in notes2)
        {
            Console.WriteLine(item.NoteAsString);
        }
        Console.WriteLine("Sorted List");
        notes.Sort((a, b) => b.CompareTo(a));
        foreach (Note item in notes)
        {
            Console.WriteLine(item.NoteAsString);
        }
        Console.ReadKey();
    }
}