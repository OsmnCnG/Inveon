using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InveonBootcamp._02.OCP
{


    public class DiscountCalculator
    {

        public enum RentalPeriodType{
            ThreeDays,
            Weekly,
            Monthly
        }

        // yeni bir enum gelirse kodu düzenlememiz gerekir!
        public static decimal CalculateDiscount(decimal basePrice, RentalPeriodType period)
        {
            decimal discount = 0;
            if (RentalPeriodType.ThreeDays == period) { 
                discount = 0;
            }
            else if(RentalPeriodType.Weekly == period)
            {
                discount =  (basePrice * 15) / 100;
            }
            else if (RentalPeriodType.Monthly == period)
            {
                discount = (basePrice * 30) / 100;
            }

            return discount;
        }


    }
    
    
    public interface IDiscountCalculate
    {
        decimal CalculateDiscountOCP(decimal basePrice);
    }




    public class DiscountCalculator3Days
    {
        public decimal CalculateDiscountOCP(decimal basePrice)
        {
            return 0;
        }


    }


    public class DiscountCalculatorWeekly
    {
        //public decimal CalculateDiscountOCP(decimal basePrice)
        //{
        //    return basePrice* 15 / 100;
        //}

        public decimal CalculateDiscountDelagate(decimal basePrice, Func<decimal, decimal> discountCalculateFunction) { return discountCalculateFunction(basePrice); }

    }


    public class DiscountCalculatorMonthly
    {
        //public decimal CalculateDiscountOCP(decimal basePrice)
        //{
        //    return basePrice * 30 / 100;
        //}
        public decimal CalculateDiscountDelagate(decimal basePrice, Func<decimal, decimal> discountCalculateFunction) { return discountCalculateFunction(basePrice); }


    }


}
