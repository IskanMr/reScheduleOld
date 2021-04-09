using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace reSchedule
{
    class UserInt
    {
        public static void Menu()
        {
            Show.entry(Entries.entries1);
            Opsi.Menu();

        }
        public static void Fungsi()
        {
            User user = new User();
            Show.entry(Entries.entries2);
            Opsi.Fungsi();
        }
    }
}
