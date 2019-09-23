namespace InheritanceAndInterfacesExercises
{
    internal class Bicycle : Vehicle
    {
        public Bicycle()
        {
        }

        public override void GoTo(string destination)
        {
            withVehicleType = "med cykel";
            base.GoTo(destination);
        }
    }
}