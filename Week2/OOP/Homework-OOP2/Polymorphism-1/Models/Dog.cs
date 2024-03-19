using Polymorphism_1.AbstractClasses;
using Polymorphism_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_1.Models
{
    public class Dog : Animal
    {
        /*   public void MakeSound()
           {
               Console.WriteLine("Woof");
           }

           public void Walk()
           {
               Console.WriteLine("Walk the dog");
           }*/
        public override void MakeSound()
        {
            Console.WriteLine("Woof");
        }
    }
}
