using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBuilderApp
{
    public interface IAnimalBuilder
    {
        // public IAnimalBuilder Add(string variable, string value);
        public IAnimalBuilder setName(string name);
        public IAnimalBuilder setBreed(string breed);
        public IAnimalBuilder setAge(int age);
        public IAnimalBuilder setToys(List<string> toys);
    }
}
