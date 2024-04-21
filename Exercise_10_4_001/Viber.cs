using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_4_001
{
    internal class Viber : IMessanger<Phone>, IMessanger<Computer>
    {
        Phone IMessanger<Phone>.DeviceInfo()
        {
            throw new NotImplementedException();
        }

        Computer IMessanger<Computer>.DeviceInfo()
        {
            throw new NotImplementedException();
        }
    }
}
