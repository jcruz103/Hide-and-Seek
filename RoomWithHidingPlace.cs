using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace HouseGame
{
    class RoomWithHidingPlace : Room, IHidingPlace
    {
        public RoomWithHidingPlace(string name, string decoration, string hidingPlaceName, Bitmap picture)
            : base(name, decoration, picture)
        {
            this.hidingPlaceName = hidingPlaceName;
        }

        private string hidingPlaceName;
        public string HidingPlaceName
        {
            get{ return hidingPlaceName; }
        }

        public override string Description
        {
            get
            {
                return base.Description + " Someone could hide " + hidingPlaceName + ".";
            }
        }
    }
}
