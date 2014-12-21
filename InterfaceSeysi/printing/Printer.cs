using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSeysi.printing
{
    public class Printer : IMachine
    {
        public String machineNumber;
        public Machine machine;
        private int paperCount;

        public Printer()
        {
            machine = new Machine();
        }
        
        public void TurnOn()
        {
            machine.TurnOn();
            Console.WriteLine("Printer engine warms up");
            
        }

        public void TurnOff()
        {
            Console.WriteLine("Printer engine cools down");
            machine.TurnOff();

        }

        public bool isMachineOn()
        {
            return machine.isMachineOn();
        }

        public int getPaperCount()
        {
            return paperCount;
        } 
    }
}
