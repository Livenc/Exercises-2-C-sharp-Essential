namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(36.5, 39.1, 8.18);
            Console.WriteLine("1 - uah to usd ");
            Console.WriteLine("2 - uah to eur ");
            Console.WriteLine("3 - uah to pln ");
            Console.WriteLine("Input ammount");
            converter.UAHtoOtherCurrencies(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Input ammount");
            Console.WriteLine("1 -  usd to uah");
            Console.WriteLine("2 - eur to uah ");
            Console.WriteLine("3 - pln to uah ");
            converter.toOtherCurrenciesToUAH(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.ReadLine();
        }
    }
}