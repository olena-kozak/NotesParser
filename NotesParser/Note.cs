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
        public override string ToString()
        {
            return $"{_digit}{_sign}";
        }

        public int CompareTo(Note? obj)
        {
            if (_digit > obj.Digit) return 1;
            else if (_digit < obj.Digit) return -1;
            else if (_digit == obj.Digit)
            {
                if (_sign == null && obj.Sign == null) return 0;
                else if (_sign != null && obj.Sign == null)
                {
                    if (_sign.Equals("-") || _sign.Equals("+")) return _sign == "-" ? -1 : 1;
                    else if (_sign.Equals("--") || _sign.Equals("++")) return _sign == "--" ? -1 : 1;
                    else
                    {
                        throw new Exception();
                    }

                }
                else if (_sign == null && obj.Sign != null)
                {
                    if (obj.Sign.Equals("-") || obj.Sign.Equals("+")) return _sign == "-" ? -1 : 1;
                    else
                    {
                        throw new Exception();
                    }
                }
                else if (_sign != null && obj.Sign != null)
                {
                    if (_sign.Equals("-"))
                    {

                    }
                }
                else { throw new Exception(); }
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
