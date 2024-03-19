using Polymorphism_1.AbstractClasses;
using Polymorphism_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_1.Models
{
    public class Cat : Animal
    {
        /*    public void MakeSound()
            {
                Console.WriteLine("Meow");
            }

            public void Walk()
            {
                Console.WriteLine("Walk");
            }*/
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
