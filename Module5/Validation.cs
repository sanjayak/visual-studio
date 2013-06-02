using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace Module5
{
    class Validation
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            dog.SetName(null);
            Console.WriteLine("Done");
        }
    }

    public abstract class Animal
    {
        public string Name { get; set; }

        public virtual void SetName(string name)
        {
            this.Name = name;
        }
    }

    class Dog : Animal
    {
       
        public override void SetName(string value)
        {
            Contract.Requires(!string.IsNullOrWhiteSpace(value), "value is empty");
            this.Name = value;                
        }

        public string GetName()
        {
            Contract.Ensures(!string.IsNullOrWhiteSpace(Contract.Result<string>()));
            return this.Name;
        }
    }
}
