using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InveonBootcamp._03.LSP
{


    public interface IRechargeable
    {
        void Charge();
    }


    public abstract class VehicleLSP
    {
        public void Run()
        {
            Console.WriteLine("Hareket ediyor");
        }
    }


    public class TeslaLSP : VehicleLSP, IRechargeable
    {
        public void Charge()
        {
            Console.WriteLine("Tesla şarj ediliyor");
        }
    }


    public class VolvoLSP : VehicleLSP
    {
    }
}
