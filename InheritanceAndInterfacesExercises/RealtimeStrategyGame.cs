using System;

namespace InheritanceAndInterfacesExercises
{
    //Exercise 1 2 3
    internal class RealtimeStrategyGame : VideoGame
    {
        
        public RealtimeStrategyGame()
        {
        }

        public void PrintGameType()
        {
            base.PrintGameType();
        }

        public void PrintAcronym()
        {
            Console.WriteLine("RTS");
        }
    }
}