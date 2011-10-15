using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace HouseGame
{
    class Outside : Location
    {
        private bool hot;
        public bool Hot { get { return hot; } }

        public Outside(string name, bool hot, Bitmap picture)
            :base(name, picture)
        {
            this.hot = hot;
        }

        public override string Description
        {
            get
            {
                string NewDescription = base.Description;
                if (hot)
                    NewDescription += " It's ver hot.";
                return NewDescription;
            }
        }
    }
}
