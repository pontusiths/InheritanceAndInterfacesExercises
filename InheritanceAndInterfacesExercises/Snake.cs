using System;

namespace InheritanceAndInterfacesExercises
{
    internal class Snake : Reptile, INoiseMaker
    {
        public Snake()
        {
        }

        //12
        public void MakeNoise()
        {
            Console.WriteLine("Hiss!!!");
        }
    }
}