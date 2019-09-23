using System;

namespace InheritanceAndInterfacesExercises
{
    internal abstract class Vehicle
    {
        protected string withVehicleType;

        public virtual void GoTo(string destination)
        {
            string output = $"Färdas till {destination}";
            if (withVehicleType != null)
            {
                output = $"Färdas {withVehicleType} till {destination}";
            }
            Console.WriteLine(output);
        }
    }
}