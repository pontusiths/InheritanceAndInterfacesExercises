using System;

namespace InheritanceAndInterfacesExercises
{
    internal class Dog : Mammal, INoiseMaker
    {
        public Dog()
        {
        }

        public void MakeNoise()
        {
            Console.WriteLine("Woof!");
        }
    }
}