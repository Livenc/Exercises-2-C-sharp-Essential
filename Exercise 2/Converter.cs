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
        double usd, eur, pln;
        public Converter(double usd, double eur, double pln)
        {
            this.usd = usd;
            this.eur = eur;
            this.pln = pln;
        }
        //void ConverterMoney(double first, double second)
        //{
        //    Console.WriteLine(first * second);
        //}
        public void Money(int chouse, int choese2 ,double amount)
        {

            //switch (chouse)
            //{
            //    case 1:
            //        Console.WriteLine(amount / usd );
            //        break;
            //    case 2:
            //        Console.WriteLine(amount / eur);
            //        break;
            //    case 3:
            //        Console.WriteLine(amount / pln);
            //        break;
            //    default:
            //        break;
            //}
        }
        public void UAHtoOtherCurrencies(int choese,double amount)
        {
            
            switch (choese)
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
                    Console.WriteLine("Miss chouse");
                    break;
            }
        }
        public void toOtherCurrenciesToUAH(int choese, double amount)
        {

            switch (choese)
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
                    Console.WriteLine("Miss chouse");
                    break;
            }
        }
    }
}
