using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_4_003
{
    internal interface IMessanger<in T>
    {
        void GetDeviceInfo(T device);
    }
}
