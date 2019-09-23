using System;

namespace InheritanceAndInterfacesExercises
{
    internal class Cat : Mammal, INoiseMaker
    {
        public Cat()
        {
        }

        public void MakeNoise()
        {
            Console.WriteLine("Meow!");
        }
    }
}