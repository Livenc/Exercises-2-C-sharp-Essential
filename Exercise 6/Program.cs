namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Fray", "Artyr", "Akimov", 25);
            user.Show();
           // user.FirstName = "Arikest";

            Console.ReadLine();
        }
    }
}