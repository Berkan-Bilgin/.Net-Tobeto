using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_1.AbstractClasses
{
    public abstract class Animal
    {
        public abstract void MakeSound();

        public virtual void Walk()
        {
            Console.WriteLine($"The {GetType().Name} walks.");
        }

    }
}
