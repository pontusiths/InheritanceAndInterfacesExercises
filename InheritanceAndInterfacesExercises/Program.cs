using System;

namespace InheritanceAndInterfacesExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1 2 3
            var game = new RealtimeStrategyGame();
            game.PrintGameType();

            //Exercise 4, check interitance
            var cat = new Cat();
            var bird = new Bird();
            var dog = new Dog();
            var snake = new Snake();

            Console.ReadKey(true);

            //Exercise 5, 6, 7, 8, 10, 12
            var bicycle = new Bicycle();
            var car = new Car();
            var motorboat = new Motorboat();
            var sailboat = new Sailboat();
            bicycle.GoTo("Jobbet");
            car.GoTo("Biltema");
            motorboat.GoTo("Knarrholmen");
            sailboat.GoTo("New York");


            //Exercise 9
            var couch = new Couch();
            couch.Sittable();

            //Exercise 11
            var oilBarrel = new OilBarrel();
            var burnable = oilBarrel as IBurnable;
            if (burnable != null)
            {
                burnable.SetOnFire();
            }

            //Exercise 12
            var robot = new Robot();
        }
    }
}
