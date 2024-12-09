using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InveonBootcamp._04.ISP
{
    public interface IVehicle
    {
        void Rent();

        void ProvideCargoService();

        void ProvideLuxuryService();
    }


    public class EconomyCar : IVehicle
    {
        public void ProvideCargoService() //Unnecessary Method
        {
            throw new NotImplementedException();
        }

        public void ProvideLuxuryService() //Unnecessary Method
        {
            throw new NotImplementedException();
        }

        public void Rent()
        {
            Console.WriteLine("Araç Kiralama Hizmeti");
        }
    }


    public class LuxuryCar : IVehicle
    {
        public void ProvideCargoService() //Unnecessary Method
        {
            throw new NotImplementedException();
        }

        public void ProvideLuxuryService()
        {
            Console.WriteLine("Lüks Araç Hizmeti");
        }

        public void Rent()
        {
            Console.WriteLine("Araç Kiralama Hizmeti");
        }
    }


    public class CargoCar : IVehicle
    {
        public void ProvideCargoService()
        {
            Console.WriteLine("Kargo Hizmeti");
        }

        public void ProvideLuxuryService() //Unnecessary Method
        {
            throw new NotImplementedException();
        }

        public void Rent()
        {
            Console.WriteLine("Araç Kiralama Hizmeti");
        }
    }






}
