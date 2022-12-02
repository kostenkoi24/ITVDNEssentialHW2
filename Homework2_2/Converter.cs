using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2_2
{
    class Converter
    {
        public double usd;
        public double eur;
        public double pln;

        public Converter(double usd, double eur, double pln)
        {
            this.usd = usd;
            this.eur = eur;
            this.pln = pln;
        }

        
        public double CalculateAmount(string val1, string val2, double amount)
        {
            
            if (val1 == "UAH" && val2 != "UAH")
            {
                switch (val2)
                {
                    case "USD": return amount / usd;
                    case "EUR": return amount / eur;
                    case "PLN": return amount / pln;
                    default: return amount;
                }
            }

            if (val1 != "UAH" && val2 == "UAH")
            {
                switch (val1)
                {
                    case "USD": return amount * usd;
                    case "EUR": return amount * eur;
                    case "PLN": return amount * pln;
                    default: return amount;
                }
            }

            if (val1 == "USD" && (val2 == "EUR" || val2 == "PLN"))
            {
                switch (val2)
                {
                    case "EUR": return (amount * usd) / eur;
                    case "PLN": return (amount * usd) / pln;
                }
            }

            if (val1 == "EUR" && (val2 == "USD" || val2 == "PLN"))
            {
                switch (val2)
                {
                    case "USD": return (amount * eur) / usd;
                    case "PLN": return (amount * eur) / pln;
                }
            }

            if (val1 == "PLN" && (val2 == "USD" || val2 == "EUR"))
            {
                switch (val2)
                {
                    case "USD": return (amount * pln) / usd;
                    case "EUR": return (amount * pln) / eur;
                }
            }


            return amount;




        }


    }
}
