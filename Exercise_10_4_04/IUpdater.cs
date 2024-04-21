using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_4_04
{
    internal interface IUpdater<in T>
    {
        void Update(T entity);
    }
}
