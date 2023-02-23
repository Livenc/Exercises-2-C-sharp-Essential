namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(123442, "Fill", "H&D");
            invoice.VAT("Tea", 2, 20);
            Console.ReadLine();
        }
    }
}