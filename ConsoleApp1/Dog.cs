using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBuilderApp
{
    public class Dog
    {
        private string? _name;
        public string? Name {
            get { return _name; }
            set { _name = value; }
        }

        private string? _breed;
        public string? Breed
        {
            get { return _breed; }
            set { _breed = value; }
        }


        private int? _age;
        public int? Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private List<string>? _toys;
        public List<string>? Toys
        {
            get { return _toys; }
            set { _toys = value; }
        }

        public void toConsole()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Порода: {Breed}");
            Console.WriteLine($"Возраст: {Age}");
            if (Toys != null && Toys.Count != 0)
            {
                Console.WriteLine("Игрушки собаки:");
                foreach (string toy in Toys!)
                {
                    Console.WriteLine(toy);
                }
            }
            Console.WriteLine();
        }
    }
}
