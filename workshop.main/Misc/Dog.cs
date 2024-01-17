using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.main.Misc
{
    public class Dog
    {
        private int _age;
        private string _breed;
        private string _name;

        public Dog()
        {

        }

        public Dog(string Breed, string Name)
        {
            _breed = Breed;
            _name = Name;
        }
        public Dog(string Breed, string Name, int Age)
        {
            _breed = Breed;
            _name = Name;
            _age = Age;
        }



        public string Breed { get { return _breed; } set { _breed = value; } }
        public string Name { get { return _name; } set { _name = value; } }
    }
}
