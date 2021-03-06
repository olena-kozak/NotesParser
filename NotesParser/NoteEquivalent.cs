using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesParser
{
    public class NoteEquivalent
    {
        private Dictionary<string, int> _noteEquivalent = new Dictionary<string, int>()
        {
            { "1--", 1},
            { "1-",2},
            { "1",3},
            { "1+",4},
            { "1++",5},
            { "2--",6},
            { "2-",7},
            { "2",8},
            { "2+",9},
            { "2++",10},
            { "3--",11},
            { "3-",12},
            { "3",13},
            { "3+",14},
            { "3++",15},
            { "4--",16},
            { "4-",17},
            { "4",18},
            { "4+",19},
            { "4++",20},
            { "5--",21},
            { "5-",22},
            { "5",23},
            { "5+",24},
            { "5++",25}
        };
        public Dictionary<string, int> NoteEquivalents { get { return _noteEquivalent; } }

        public int ConvertToEquivalent(Note note)
        {
            var noteAsString = note.ToString();
            _noteEquivalent.TryGetValue(noteAsString, out var noteEquivalent);
            return noteEquivalent;
        }
    }
}
