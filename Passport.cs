using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    public class Passport
    {
        public string Date { get; set; }
        public string Name { get; set; }

        public Passport() 
        { 

        }
        public Passport(string date, string name)
        {
            Date = date;
            Name = name;
        }
        public override string ToString()
        {
            return $"";
        }
    }
    public class ForeignPassport : Passport
    {
        public string[] Vises { get; set; }
        public string Number { get; set; }

        public ForeignPassport() : base() 
        { 
            Vises = new string[0];
            Number = string.Empty;
        }
        public ForeignPassport(string date, string name, string[] vises, string number) : base(date, name)
        {
            Vises = vises;
            Number = number;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nDate: {Date}\nVises: {string.Join(", ", Vises)}\nNumber: {Number}";
        }
    }
}
