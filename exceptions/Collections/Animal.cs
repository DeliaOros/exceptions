using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class Animal
    {
        public Gender Gender { get; set; }
        public string Name { get; set; }
        public Animal(string name, Gender gender)
        {
            this.Name = name;
            this.Gender = gender;
        }
    }
    public enum Gender
    {
        Male,
        Female
    }
}
