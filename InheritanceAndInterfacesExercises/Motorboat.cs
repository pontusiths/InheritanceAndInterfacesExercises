namespace InheritanceAndInterfacesExercises
{
    internal class Motorboat : Boat
    {
        public Motorboat() : base()
        {
        }

        public override void GoTo(string destination)
        {
            withVehicleType = "med motorbåt";
            base.GoTo(destination);
        }
    }
}