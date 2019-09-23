using System;

namespace InheritanceAndInterfacesExercises
{
    //Exercise 1 2 3
    internal class VideoGame
    {
        public void PrintGameType()
        {
            Console.WriteLine(GetType().Name);
        }
    }
}