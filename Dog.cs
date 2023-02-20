using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInterfaces
{
    internal class Dog : Animal
    {
       public Dog(string name, string colour , int age , int height): base(name,colour,age,height) 
        {
        }
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }

        public override void Cry()
        {
            Console.WriteLine("Woof");
        }
    }
}
