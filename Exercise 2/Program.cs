namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(36.5, 39.1, 8.18);
            converter.UAHtoOtherCurrencies();      
            converter.toOtherCurrenciesToUAH();
            Console.ReadLine();
        }
    }
}