using System;

namespace _5Hafta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");




            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerID = 12345;
            customer1.CustomerName = "Nevzat";
            customer1.CustomerSurname = "Peker";
            customer1.CustomerNumber = "1235";
            customer1.CustomerIdentityNumber = "302423423";

            CooporateCustomer customer2 = new CooporateCustomer();
            customer2.CustomerID = 12346;
            customer2.CustomerNumber = "1234";
            customer2.CustomerTaxNumber = "4213423423";
            customer2.CustomerCompanyName = "Peker LTD";
        }
    }
}
