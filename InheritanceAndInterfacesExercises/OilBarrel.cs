using System;

namespace InheritanceAndInterfacesExercises
{
    internal class OilBarrel : IBurnable
    {
        public OilBarrel()
        {
        }

        public void SetOnFire()
        {
            Explode();
        }

        private void Explode()
        {
            Console.WriteLine("OilBarrel goes boom!");
        }
    }
}