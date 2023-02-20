using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal dog = new Dog("rocky", "white", 4, 5);

            dog.Eat();
            dog.Cry();

            IAnimal cat = new Cat("mio", "black", 2, 5);

            cat.Eat();
            cat.Cry();

            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(dog);
            animals.Add(cat);

            foreach (IAnimal animal in animals) 
            { 
                Console.WriteLine(animal.Name);
            }
        }
    }
}
