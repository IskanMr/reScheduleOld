using System;
using System.Threading;

namespace reSchedule
{
    class Show
    {
        public static void entry(Entry[] entries)
        {
            Console.Clear();
            Console.WriteLine("Pilihan: ");
            foreach (Entry entry in entries)
            {
                Console.WriteLine("\t[" + entry.key + "] - " + entry.name);
            }
        }

        public static void delay(string words)
        {
            Console.Clear();
            Console.WriteLine(words);
            Thread.Sleep(1000);
        }
    }
}
