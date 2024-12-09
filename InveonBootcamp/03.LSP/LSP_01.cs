using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InveonBootcamp._03.LSP
{

    
    public abstract class Vehicle
    {
        public void Run()
        {
            Console.WriteLine("Hareket ediyor");
        }

        public abstract void Charge();
    }


    public class Tesla : Vehicle
    {
        public override void Charge()
        {
            Console.WriteLine("Tesla şarj ediliyor");

        }
    }


    public class Volvo : Vehicle
    {
        public override void Charge()
        {
            throw new NotImplementedException();
        }
    }



}
