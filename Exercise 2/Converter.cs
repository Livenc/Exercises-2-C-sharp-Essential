using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercise_2
{
    internal class Converter
    {
        double usd, eur, pln, amount;
        int choice;
        public Converter(double usd, double eur, double pln)
        {
            this.usd = usd;
            this.eur = eur;
            this.pln = pln;
        }
   
  
        public void UAHtoOtherCurrencies()
        {
            Console.WriteLine("1 - uah to usd ");
            Console.WriteLine("2 - uah to eur ");
            Console.WriteLine("3 - uah to pln ");
            choice= Convert.ToInt32(Console.ReadLine());
            Console.Write("Input ammount : ");
            amount = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"{amount/usd}  usd");
                    break;
                    
                case 2:
                    Console.WriteLine($"{amount / eur}  eur");
                    break; 
                case 3:
                    Console.WriteLine($"{amount / pln}  pln");
                    break;
                default:
                    Console.WriteLine("Miss choice");
                    break;
            }
        }
        public void toOtherCurrenciesToUAH()
        {
            Console.WriteLine("1 -  usd to uah");
            Console.WriteLine("2 - eur to uah ");
            Console.WriteLine("3 - pln to uah ");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input ammount : ");
            amount = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"{amount * usd}  uah");
                    break;

                case 2:
                    Console.WriteLine($"{amount * eur}  uah");
                    break;
                case 3:
                    Console.WriteLine($"{amount * pln}  uah");
                    break;
                default:
                    Console.WriteLine("Miss choice");
                    break;
            }
        }
    }
}
