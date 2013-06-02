using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismTest
{
    class RoomWithDoor : Room, IHasExteriorDoor
    {
        private string doorDescription;
        
        public string DoorDescription { get { return doorDescription; } }

        private Location doorLocation;

        public Location DoorLocation {
            get { return doorLocation; }
            set { doorLocation = value; }
        }

        public RoomWithDoor(string name, string decoraiton, string doorDescription)
            : base(name, decoraiton)
        {
            this.doorDescription = doorDescription;    
        }
    }
}
