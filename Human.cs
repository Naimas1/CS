using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Profession { get; set; }


        public Human()
        {
            Name = string.Empty;
            Age = 0;
            Profession = string.Empty;
        }
        public Human(string name, int age) : this()
        {
            Name = name;
            Age = age;
        }
        public Human(string name, int age, string profession)
        {
            Name = name;
            Age = age;
            Profession = profession;
        }
    }

    public class Builder : Human
    {
        public Builder() : base() { }
        public Builder(string name, int age) : base(name, age)
        {
            Profession = "Builder";
        }
        public string Build()
        {
            return "I`m a builder";
        }

    }
    public class Sailor : Human
    {
        public Sailor() : base() { }
        public Sailor(string name, int age) : base(name, age)
        {
            Profession = "Sailor";
        }
        public string Sail()
        {
            return "I'm Sailor";
        }
    }
    public class Pilot : Human
    {
        public Pilot() : base() { }
        public Pilot(string name, int age) : base(name, age) 
        {
            Profession = "Pilot";
        }
        public string Piloting()
        {
            return "I'm Pilot";
        }
    }
}
