using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Arrays
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            dog.eat();
            
            //single dimenstional array
            int[] table;
            //multi dimenstional array
            string[,] multiArray = new string[5,4];
            //array of array:jagged array
            byte[][] jaggedArray = new byte[5][];
            //create the jagged array
            for (int x = 0; x < jaggedArray.Length; x++)
            {
                jaggedArray[x] = new byte[4];
            }

            //pring length of each row
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine("Length of raw {0} is {1} ", i, jaggedArray[i].Length );
            }
           
            //initilialising array by declaration time
            int[] numbers = new int[4] { 1, 2, 3, 4 };
            //or
            int[] num = new int[] { 1, 2, 3 };
            string[] names = new string[3] { "sanjaya", "kumara", "athukorala"};
            //or
            string[] nam = new string[] {"wasintha" };

            string[,] sibilings = { {"sanjya"},{"kumara"}};

            int[][] jagged = { new int[] { 2,3 }, new int[] { 5,6 } };

            Console.WriteLine("element at 1,1" + jagged[1][1]);

        }
    }
}
