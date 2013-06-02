using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module4
{
    class Dog
    {
        public string name { get; set; }

        private void speak()
        {
            Console.WriteLine("bark");
        }
    }

    class ReflectionTest
    {
        public static void main( string [] a )
        {
            Type t1 = typeof(Dog);

            Type t2 = new Dog().GetType();

            Console.WriteLine("################");
            Console.WriteLine( t1.Name );

            Console.WriteLine( t2.Name );

            var newDog = Activator.CreateInstance(typeof(Dog));

            var genericDog = Activator.CreateInstance<Dog>();

            var dogConstructor = typeof(Dog).GetConstructors()[0];

            var advanceDog = dogConstructor.Invoke(null);

        }

        private void AccessProperty()
        {
            Dog dog = new Dog()
            {
                name = "Rovar"
            };

            var type = dog.GetType();

            var property = type.GetProperty("name");

            var value = property.GetValue(dog,null);

            Console.WriteLine(value);
        }

        //invoking a method
        private void InvokeMethod()
        {
            var dog = new Dog();

            var type = dog.GetType();

            var method = type.GetMethod("speak");

            var value = method.Invoke(dog, null);
        }
    }
}
