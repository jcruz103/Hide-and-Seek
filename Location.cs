using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace HouseGame
{
    abstract class Location
    {
        public Location(string name,  Bitmap picture)
        {
            this.name = name;
            this.picture = picture;
        }

        public Location[] Exits;

        private string name;
        public string Name
        {
            get { return name; }
        }

        private Bitmap picture;
        public Bitmap Picture
        {
            get { return picture; }
        }

        public virtual string Description
        {
            get
            {
                string description = "You're standing in the " + name + ". You see exits to the following places: ";
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += " " + Exits[i].Name;
                    if (i != Exits.Length - 1)
                        description += ",";
                }
                description += ".";
                return description;
            }
        }
    }
}
