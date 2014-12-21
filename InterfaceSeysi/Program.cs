using InterfaceSeysi.printing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSeysi
{
    class Program
    {
        static void Main(string[] args)
        {
            IMachine p = new Printer();
            p.TurnOn();
            p.TurnOff();
            Console.ReadLine();
        }
    }
}
