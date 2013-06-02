using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Animal
    {
        private string noOfLegs;

        public Animal()
        {
        }

        public Animal( string noOfLegs )
        {
            System.Windows.Forms.MessageBox.Show("Inside the Base Class Constructor");
            this.noOfLegs = noOfLegs;
        }

        public bool isMammal()
        {
            return true;
        }

        public virtual void eat()
        {            
            Console.WriteLine("Eat anything");
        }
    }

    class Dog : Animal
    {
        private string noOfLegs;

        public Dog() : base()
        {

        }
        public Dog(String noOfLegs)
            : base(noOfLegs)
        {
            
            {
                this.noOfLegs = noOfLegs;
            }
            System.Windows.Forms.MessageBox.Show("Inside the sub class");
            
        }
        public override void eat()
        {            
            Console.WriteLine("Eat only meats");            
        }
    }

    class Test
    {
        static void main(String [] a)
        {
            Dog dog = new Dog( "Test Message");
            dog.eat();
        }
    }
}
