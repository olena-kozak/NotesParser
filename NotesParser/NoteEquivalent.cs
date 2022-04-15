using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesParser
{
    public class NoteEquivalent
    {
        private Dictionary<int, string> _noteEquivalent = new Dictionary<int, string>()
        {
            {1,"1--"},
            { 2,"1-"},
            { 3,"1"},
            { 4,"1+"},
            { 5,"1++"},
            { 6,"2--"},
            { 7,"2-"},
            { 8,"2"},
            { 9,"2+"},
            { 10,"2++"},
            { 11,"3--"},
            { 12,"3-"},
            { 13,"3"},
            {14,"3+" },
            { 15,"3++"},
            { 16,"4--"},
            { 17,"4-"},
            { 18,"4"},
            { 19,"4+"},
            { 20,"4++"},
            { 21,"5--"},
            { 22,"5-"},
            { 23,"5"},
            { 24,"5+"},
            { 25,"5++"}
        };
        public Dictionary<int, string> NoteEquivalents { get { return _noteEquivalent; } }

        public int ConvertToEquivalent(Note note)
        {
            var noteAsString = note.ToString();
            var noteEquivalent = NoteEquivalents
                                    .Where(x => x.Value.Equals(noteAsString, StringComparison.OrdinalIgnoreCase))
                                    .FirstOrDefault();
            return noteEquivalent.Key;
        }
    }
}
