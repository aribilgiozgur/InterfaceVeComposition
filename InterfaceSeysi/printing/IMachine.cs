using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSeysi.printing
{
    public interface IMachine
    {
        // Metotların adları
         void TurnOn();
         void TurnOff();
         Boolean isMachineOn();
    }
}
