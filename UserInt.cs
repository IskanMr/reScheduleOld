using System;

namespace reSchedule
{
    public class UserInt : DefaultTwo
    {
        public override void Menu()
        {
            Show.entry(Entries.entries1);
            Opsi y = new Opsi();
            y.Menu();
        }

        public override void Fungsi()
        {
            Show.entry(Entries.entries2);
            Opsi y = new Opsi();
            y.Fungsi();
        }
    }
}
