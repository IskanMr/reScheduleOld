using System;

namespace reSchedule
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.Title = "reSchedule";

            User user = new User();
            Console.Write("Nama anda: ");
            User.Nama = Console.ReadLine();

            UserInt x = new UserInt();
            x.Menu();
        }
    }
}
