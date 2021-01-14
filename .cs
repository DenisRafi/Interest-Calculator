using static System.Console;
using System;
namespace _
{
    class _
    {
        static void Main()
        {
            Title = "ByDR";
            double Total = 0, interestRate, years, annualCompound, Amount;
            Write("Initial Amount : ");
            Amount = Convert.ToDouble(ReadLine());
            Write("Rate of Interest : ");
            interestRate = Convert.ToDouble(ReadLine()) / 100;
            Write("Number of Years : ");
            years = Convert.ToDouble(ReadLine());
            Write("Times the Interest will be Compounded : ");
            annualCompound = Convert.ToDouble(ReadLine());
            for (int t = 1; t < years + 1; t++)
            {
                Total = Amount * Math.Pow((1 + interestRate / annualCompound),
                                         (annualCompound * t));
                Write("Total| Year | {0} "
                            + "| {1:F0} \n", t, Total);
            }
            ReadLine();
        }
    }
}