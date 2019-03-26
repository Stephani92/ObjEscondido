namespace OndeEstouNaCasa
{
    class OutSideWDoor : Outside, IhasExteriorDoor
    {
        public OutSideWDoor(string name, bool hot, string DoorDescription) : base(name, hot)
        {
            this.doorDescription = DoorDescription;
        }
        private string doorDescription;

        public string DoorDescription
        {
            get { return doorDescription; }
        }

        private Location doorLocation;
        public Location DoorLocation
        {
            get { return doorLocation; }
            set { doorLocation = value; }
        }
    }
}
