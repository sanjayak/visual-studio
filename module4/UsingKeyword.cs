using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace module4
{
    class UsingKeyword
    {
        public void X()
        {
            var path = "c\text.txt";
            var file = File.Open(path, FileMode.Open);

            file.Close();

            //second approach
            using(var file2 = File.Open(path, FileMode.Open))
            {
                //do something
            }
        }
    }
}
