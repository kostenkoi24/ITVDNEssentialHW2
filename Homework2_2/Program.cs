using System;

namespace Homework2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            string val1 = "";
            string val2 = "";
            double amount;

            double rateUSDtoUAH = 40.5;
            double rateEURtoUAH = 41;
            double ratePLNtoUAH = 12;



            Converter converter = new Converter(rateUSDtoUAH, rateEURtoUAH, ratePLNtoUAH);
            

            Console.WriteLine("Курс валют:");
            Console.WriteLine($"USD:{converter.usd}");
            Console.WriteLine($"EUR:{converter.eur}");
            Console.WriteLine($"PLN:{converter.pln}");
            Console.WriteLine($"UAH:1");


            while (val1 != "E" || val2 != "E")
            { 
            
                Console.WriteLine("Введіть назву валюти (USD|EUR|PLN|UAH) яку потрібно обміняти або натисніть E для виходу:");
                val1 = Console.ReadLine().ToUpper();

                if (val1 == "E")
                {
                    break;
                }

                Console.WriteLine("Введіть суму:");
                amount = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введіть назву кінцевої валюти (USD|EUR|PLN|UAH) або натисніть E для виходу:");
                val2 = Console.ReadLine().ToUpper();

                if (val2 == "E")
                {
                    break;
                }

                Console.WriteLine("{0} {1} = {2} {3}", amount ,val1, converter.CalculateAmount(val1, val2, amount) , val2);

            }


            


            Console.ReadKey();



        }
    }
}
