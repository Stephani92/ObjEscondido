namespace OndeEstouNaCasa
{
    class RoomWDoor : Room, IhasExteriorDoor
    {
        public RoomWDoor(string name, string decoration, string DoorDescription) : base(name, decoration)
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
