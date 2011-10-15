using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HouseGame
{
    class Opponent
    {
        private Random random;
        private Location myLocation;
        public Opponent(Location startingLocation)
        {
            myLocation = startingLocation;
            random = new Random();
        }
        public void Move()
        {
            if (myLocation is IHasExteriorDoor)
            {
                IHasExteriorDoor LocationWithDoor = myLocation as IHasExteriorDoor;
                if (random.Next(2) == 1)
                    myLocation = LocationWithDoor.DoorLocation;
            }

            bool hidden = false;
            while (!hidden)
            {
                int rand = random.Next(myLocation.Exits.Length);
                myLocation = myLocation.Exits[rand];
                if (myLocation is OutsideWithDoor)
                    hidden = false;
                else if (myLocation is IHidingPlace)
                    hidden = true; 
                
            }
        }

        public string Place()
        {
            return myLocation.Description;
        }

        public bool Check(Location locationToCheck)
        {

            if (locationToCheck.Description == myLocation.Description)
            {
                return true;
            }
            else
            {

                return false;
            }


        }
    }
}
