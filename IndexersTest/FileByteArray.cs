using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IndexersTest
{
    class FileByteArray
    {
        Stream stream;

        public FileByteArray(string fileName)
        {
            stream = new FileStream(fileName, FileMode.Open);
        }

        public void close()
        {
            stream.Close();
            stream = null;
        }

        public byte this[long index]
        {
            get
            {
                byte[] buffer = new byte[1];
                stream.Seek(index, SeekOrigin.Begin);
                stream.Read(buffer, 0, 1);
                return buffer[0];                
            }
            set
            {
                byte[] buffer = new byte[1] { value };
                stream.Seek(index, SeekOrigin.Begin);
                stream.Write(buffer, 0, 1);
            }
        }

        public long Length
        {
            get
            {
                return stream.Seek(0, SeekOrigin.End);
            }
        }
    }

    public class Reverse
    {
        public static void Main( string [] a )
        {
            if ( a.Length == 0 )
            {
                Console.WriteLine("No file is given");
                return;
            }

            FileByteArray file = new FileByteArray( a[0]);
            long len = file.Length;

            for( long i = 0; i < len / 2 ; i++)
            {
                byte t;
                t = file[i];
                file[i] = file[len -i -1];
                file[len-i-1] = t;
            }
            file.close();
        }
    }
}
