using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismTest
{
    abstract class Location
    {
        public Location[] Exists;
        private string name;
        public string Name { get { return name; } }

        public Location(string name)
        {
            this.name = name;
        }

        public virtual string Description
        {
            get
            {
                string description = "you are standing in the " + name + ". You see exists to the following"
                + "places ";
                for (int i = 0; i < Exists.Length; i++)
                {
                    description += " " + Exists[i].Name;
                    if (i != Exists.Length - 1)
                    {
                        description += ",";
                    }
                }
                description += ".";
                return description;
            }            
        }
    }
}
