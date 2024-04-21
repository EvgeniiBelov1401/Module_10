using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_4_004
{
    internal interface IGarageManager<in T, out Z>
    {
        Z GarageInfo();
        void Add(T car);
    }
}
