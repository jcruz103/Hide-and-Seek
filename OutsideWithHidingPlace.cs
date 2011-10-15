using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace HouseGame
{
    class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        public OutsideWithHidingPlace(string name, bool hot, string hidingPlaceName, Bitmap picture)
            : base(name, hot, picture)
        {
            this.hidingPlaceName = hidingPlaceName;
        }

        private string hidingPlaceName;
        public string HidingPlaceName
        {
            get { return hidingPlaceName; }
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
