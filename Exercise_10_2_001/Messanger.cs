using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_2_001
{
    internal class Messanger : IWhatsApp, IViber
    {
        void IWhatsApp.SendMassage(string message)
        {
            Console.WriteLine($"WhatsApp: {message}");
        }

        void IViber.SendMassage(string message)
        {
            Console.WriteLine($"Viber: {message}");
        }
    }
}
