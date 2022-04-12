using System;
using homework_04._12.Models;

namespace homework_04._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pr = new Product("Qogal");
            pr.Count = 10;
            pr.Price = 1;
            pr.Sell();
            pr.Sell();
            pr.Sell();
            pr.Sell();


            Console.WriteLine($" Mehsul sayi "+pr.Count);
            Console.WriteLine($" Kassada olan pul: "+pr.TotalIncome+ " Manat ");
        }
    }
}
