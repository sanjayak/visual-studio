﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismTest
{
    class Room : Location
    {
        private string decoration;
        public string Decoration
        {
            get
            {
                return decoration;
            }
        }

        public Room(string name, string decoration)
            : base(name)
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
