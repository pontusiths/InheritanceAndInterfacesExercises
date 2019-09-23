using System;

namespace InheritanceAndInterfacesExercises
{
    internal class Robot : INoiseMaker
    {
        public Robot()
        {
        }

        public void MakeNoise()
        {
            Console.WriteLine("Bleep bloop");
        }
    }
}