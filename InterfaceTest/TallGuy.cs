using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    class TallGuy : IClown
    {
        public string Name;
        public int Height;

        public void TalkAboutYourSelf()
        {
            System.Windows.Forms.MessageBox.Show("My Name is " + Name + " and i'm " + Height + "Inches tall.");
            Honk();
        }

        public void Honk()
        {
            System.Windows.Forms.MessageBox.Show("Honk honk!!");
        }

        public string FunnyThingsIHave{
            get { return "big shoes"; }
        }
    }
}
