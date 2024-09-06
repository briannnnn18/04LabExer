using System;

namespace ApplePurchase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of apples you want to purchase: ");
            int numApples = Convert.ToInt32(Console.ReadLine());

            double ApplePrice= 32.50;
            double TPrice = numApples * ApplePrice;

            Console.WriteLine($"The total price of {numApples} apples is {TPrice:F2}.");

            int convertedPrice = (int)TPrice;
            Console.WriteLine($"The value of the converted price is {convertedPrice}.");

            Console.ReadLine();
        }
    }
}