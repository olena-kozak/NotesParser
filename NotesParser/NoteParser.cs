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

        public static decimal ParseDigit(string noteAsString)
        {
            decimal digit = 0;
            string pattern = @"[1-5]\.*";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(noteAsString.Trim());
            if (match.Success)
            {
                string value = match.Value;
                string digitAsString = value.Substring(0, value.Length);
                decimal.TryParse(digitAsString, out digit);
                return digit;
            }
            else
            {
                throw new Exception();
            }
        }

        public static string ParseSign(string noteAsString)
        {
            if (noteAsString.Contains("-") && noteAsString.Length == noteAsString.IndexOf("-")) return "-";
            else if (noteAsString.Contains("+") && (noteAsString.Length - 1) == noteAsString.IndexOf("+")) return "+";
            else if (noteAsString.Contains("--")) return "--";
            else if (noteAsString.Contains("++")) return "++";
            else return null;
        }

        public Note ParseNote()
        {
            Note note = new Note();
            note.Digit = ParseDigit(_inputNote);
            note.Sign = ParseSign(_inputNote);
            return note;
        }
    }
}
