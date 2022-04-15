using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NotesParser
{
    public class NoteParser
    {
        private string _inputNote;
        public NoteParser(string inputNote)
        {
            _inputNote = inputNote;
        }

        public Note ParseNote()
        {
            Note note = new Note();
            string pattern = @"^([1-5])(\+{0,2}|\-{0,2})";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(_inputNote.Trim());
            if (match.Success)
            {
                string digitAsString = match.Groups[1].Value;
                decimal.TryParse(digitAsString, out var digit);
                note.Digit = digit;
                note.Sign = match.Groups[2].Value;
                return note;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
