using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InveonBootcamp._04.ISP
{
    public interface IRentable
    {
        void Rent();
    }

    public interface ILuxury
    {
        void ProvideLuxuryService();
    }


    public interface ICargo
    {
        void ProvideCargoService();
    }

    public class EconomyCarISP : IRentable
    {
        public void Rent()
        {
            Console.WriteLine("Araç Kiralama Hizmeti");
        }
    }


    public class LuxuryCarISP : ILuxury, IRentable
    {
        public void ProvideLuxuryService()
        {
            Console.WriteLine("Lüks Araç Hizmeti");
        }

        public void Rent()
        {
            Console.WriteLine("Araç Kiralama Hizmeti");
        }
    }


    public class CargoCarISP : ICargo, IRentable
    {
        public void ProvideCargoService()
        {
            Console.WriteLine("Kargo Hizmeti");
        }

        public void Rent()
        {
            Console.WriteLine("Araç Kiralama Hizmeti");
        }
    }








}
