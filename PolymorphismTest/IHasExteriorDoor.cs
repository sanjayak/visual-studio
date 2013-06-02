﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismTest
{
    interface IHasExteriorDoor
    {
        string DoorDescription { get; }

        Location DoorLocation { get; set; }
    }
}
