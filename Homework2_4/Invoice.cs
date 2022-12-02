using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2_4
{
    class Invoice
    {
        readonly int account;
        readonly string customer;
        readonly string provider;
        string article;
        int quantity;

        /*
        public int Account
        {
            get { return account; }
        }
        public string Customer
        {
            get { return customer; }
        }
        public string Provider
        {
            get { return provider; }
        }
        */
        public string Article
        {
            set
            {
                article = value;
            }
            get
            {
                return article;
            }
        }
        public int Quantity
        {
            set
            {
                quantity = value;
            }
            get
            {
                return quantity;
            }
        }
        

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }


        public void CalculateVAT(Invoice invoice, int price, double vat_rate)
        {

            Console.WriteLine($"Account {account}");
            Console.WriteLine($"Customer {customer}");
            Console.WriteLine($"Provider {provider}");
            Console.WriteLine($"Article {article}");
            Console.WriteLine($"Quantity {quantity}");
            Console.WriteLine($"Price {price}");

            if (vat_rate != 0)
            {
                Console.WriteLine($"VAT_rate {vat_rate}");
                Console.WriteLine($"Payment amount with VAT {quantity * price + (quantity * price * vat_rate/100)}");
                Console.WriteLine($"VAT {(quantity * price * vat_rate)/100}");
            }
            else
            {
                Console.WriteLine($"Payment amount {quantity * price}");
            }
            Console.WriteLine(new string('-',30) );

        }


    }
}
