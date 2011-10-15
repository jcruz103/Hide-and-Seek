using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace HouseGame
{
    class Room : Location
    {
        private string decoration;

        public Room(string name, string decoration, Bitmap picture)
            :base(name, picture)
        {
            this.decoration = decoration;
        }

        public override string Description
        {
            get
            {
                return base.Description + " You see " + decoration + ".";
            }
        }
    }
}
