using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module4
{
    class GarbargeColletion: IDisposable
    {
        CascaseClass reference = new CascaseClass();

        public void Dispose()
        {

        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                reference.Dispose();
            }
            //release unmanged resources
        }       
    }

    class CascaseClass : IDisposable
    {
        public void Dispose()
        {

        }
    }
}
