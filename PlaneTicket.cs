using System;

namespace LatihanMemberClass
{
    public class PlaneTicket
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public int Cost { get; set; }
        public string Currency { get; set; }

        public void PrintSummary()
        {
            Console.WriteLine("Origin: " + Origin);
            Console.WriteLine("Destination: " + Destination);
            Console.WriteLine("Cost: " + Cost + " (" + Currency + ")");

            if (Currency == "USD")
            {
                int convertedCost = Cost * 15000;
                Console.WriteLine("Convert to Rupiah: " + convertedCost);
            }
            else if (Currency == "IDR")
            {
                int convertedCost = Cost / 15000;
                Console.WriteLine("Convert to Dolar: " + convertedCost);
            }
        }
    }
}
