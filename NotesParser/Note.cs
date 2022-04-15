using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesParser
{
    public class Note : IComparable<Note>
    {
        private decimal _digit;
        public decimal Digit
        {
            get { return _digit; }
            set
            {
                if (0 < value && value <= 5)
                {
                    _digit = value;
                }
                else { throw new Exception(); }
            }
        }

        private string _sign;
        public string Sign
        {
            get { return _sign; }
            set
            {
                if (value != null)
                {
                    _sign = value;
                }
            }

        }

        private string _noteAsString;
        public string NoteAsString { get { return _noteAsString; } }
        public override string ToString()
        {
            _noteAsString = $"{_digit}{_sign}";
            return $"{_digit}{_sign}";
        }

        public int CompareTo(Note? obj)
        {
            var noteEquivalent = new NoteEquivalent();
            int currentNote = noteEquivalent.ConvertToEquivalent(this);
            var nextNote = noteEquivalent.ConvertToEquivalent(obj);
            if (currentNote == nextNote) return 0;
            else return currentNote > nextNote ? -1 : 1;
        }
    }
}
