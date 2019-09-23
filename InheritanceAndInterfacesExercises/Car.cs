namespace InheritanceAndInterfacesExercises
{
    internal class Car : Vehicle
    {
        

        public Car() 
        {

        }

        public override void GoTo(string destination)
        {
            withVehicleType = "med bil";
            base.GoTo(destination);
        }
    }
}