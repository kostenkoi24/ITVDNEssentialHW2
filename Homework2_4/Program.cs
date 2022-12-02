using System;

namespace Homework2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int account = 1;
            string customer = "Покупатель1" ;
            string provider = "Постачальник";

            Invoice invoice1 = new Invoice(account, customer, provider);

            invoice1.Quantity = 10;
            invoice1.Article = "Товар1";

            int price = 120;
            double vat_rate = 20;

            invoice1.CalculateVAT(invoice1, price, vat_rate); //with VAT

            invoice1.CalculateVAT(invoice1, price, vat_rate=0); //without VAT


            Console.ReadKey();

        }
    }
}
