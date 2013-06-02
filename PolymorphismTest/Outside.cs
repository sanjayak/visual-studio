using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismTest
{
    class Outside : Location
    {
        private bool hot;
        private bool Hot
        {
            get
            {
                return hot;
            }
        }

        public Outside(String name, bool hot) 
            : base(name)
        {
            this.hot = hot;
        }

        public override string Description
        {
            get
            {
                string NewDescription = base.Description;
                if (hot)
                    NewDescription += "It’s very hot.";
                    return NewDescription;
            }
        }
    }
}
