namespace InheritanceAndInterfacesExercises
{
    internal class Boat : Vehicle
    {
        public Boat() 
        {

        }
        public override void GoTo(string destination)
        {
            withVehicleType = "med båt";
            base.GoTo(destination);
        }
    }
}