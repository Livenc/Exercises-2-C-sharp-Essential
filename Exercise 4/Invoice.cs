using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    internal class Invoice
    {
        readonly int account ;
        readonly string customer, provider;
        private string article;
        private int quantity,price;
        public Invoice(int Account, string Customer, string Provider)
        {
            account= Account;
            customer= Customer;
            provider= Provider;
        }
        public void VAT(string Article, int Quantity,int Price)
        {
            article = Article;
            quantity = Quantity;
            price = Price;

            Console.Write($"With VAT {article} price :");
            Console.Write((quantity*price*0.14)+quantity*price);

            Console.Write($"\nWith out VAT {article} price :");
            Console.Write( quantity * price);

        }

    }
}
