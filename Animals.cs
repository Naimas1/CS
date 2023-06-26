using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    public class Animal
    {
        public string name { get; set; } 
        public string description { get; set; }
        public Animal() 
        {
            name = string.Empty;
            description = string.Empty;

        }
        public Animal(string name, string description)
        {
            this.name = name;
            this.description = description;

        }

    }
    public class Crocodile : Animal
    {
        public Crocodile() : base() { }
        public Crocodile(string name, string description) : base(name, description) { }

    }
    public class Kangaroo : Animal
    {
        public Kangaroo() : base() { }
        public Kangaroo(string name, string description) : base(name,description) { }

    }
    public class Tiger : Animal
    {
        public Tiger() : base() { }
        public Tiger(string name,string description) : base(name,description) { }

    }
}
