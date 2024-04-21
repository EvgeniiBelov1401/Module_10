using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_4_004
{
    internal class GarageManagerBase : IGarageManager<Car, Garage>
    {
        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public Garage GarageInfo()
        {
            throw new NotImplementedException();
        }
    }
}
