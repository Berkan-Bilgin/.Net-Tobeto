using Polymorphism_1.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_1.Business
{
    public class AnimalSoundEmitter
    {
        public static void EmitAnimalSound(Animal animal)
        {
            animal.MakeSound();
        }
    }
}
