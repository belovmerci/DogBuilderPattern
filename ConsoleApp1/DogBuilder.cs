using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DogBuilder : IAnimalBuilder
    {
        private Dog _dog = new Dog();

        public DogBuilder()
        {
            _dog.Name = "Безымянный";
            _dog.Breed = "Дворняга";
            _dog.Age = 1;
            _dog.Toys = new List<string>();
        }

        public IAnimalBuilder setName(string name)
        {
            _dog.Name = name;
            return this;
        }
        public IAnimalBuilder setBreed(string breed)
        {
            _dog.Breed = breed;
            return this;
        }
        public IAnimalBuilder setAge(int age)
        {
            _dog.Age = age;
            return this;
        }
        public IAnimalBuilder setToys(List<string> toys)
        {
            if (_dog.Toys == null) _dog.Toys = toys;
            else _dog.Toys.AddRange(toys);
            return this;
        }

        public Dog getDog() => _dog;
    }

}
