using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_4_003
{
    internal class Viber<T> : IMessanger<T> where T : Phone, new()
    {
        public void GetDeviceInfo(T device)
        {
            Console.WriteLine(device);
        }
    }

}
