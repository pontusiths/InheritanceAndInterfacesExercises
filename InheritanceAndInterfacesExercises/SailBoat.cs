namespace InheritanceAndInterfacesExercises
{
    internal class Sailboat : Boat
    {
        public Sailboat() : base()
        {
        }

        public override void GoTo(string destination)
        {
            withVehicleType = "med segelbåt";
            base.GoTo(destination);
        }
    }
}