using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
