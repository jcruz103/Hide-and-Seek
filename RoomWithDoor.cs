using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace HouseGame
{
    class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration, string doorDescription, string hidingPlaceName, Bitmap picture)
            : base(name, decoration, hidingPlaceName, picture)
        {
            this.doorDescription = doorDescription;
        }

        private string doorDescription;
        public string DoorDescription
        {
            get { return doorDescription; }
        }

        private Location doorLocation;
        public Location DoorLocation
        {
            get { return doorLocation;  }
            set { doorLocation = value; }
        }
    }
}
