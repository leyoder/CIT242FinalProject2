using System;

namespace Packt
{
    public class Functions
    {
        public int Difference(DateTime start, DateTime end)
        {
            return (end-start).Days;
        }

        public double Tax(double subTotal)
        {
            return Math.Round(subTotal * .07, 2);
        }
        public double Total(double subTotal, double tax)
        {
            return subTotal + tax;
        }

        public double EmployeeDiscount(double subtotal)
        {
            return Math.Round(subtotal * .10, 2);
        }

        public double ExtendedCost(double cost, double quantity)
        {
            return cost * quantity;
        }
    }
}