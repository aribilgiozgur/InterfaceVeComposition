using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSeysi.printing
{
    public class Machine : IMachine
    {
        public String machineNumber { get; set; }
        private bool isOn;


        public void TurnOn()
        {
            Console.WriteLine("Machine turns on");
            isOn = true;
        }

        public void TurnOff()
        {
            Console.WriteLine("Machine turns off");
            isOn = false;
        }
        

        public bool isMachineOn()
        {
            return isOn;
        }

       
    }
}
