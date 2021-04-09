using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reSchedule
{
    public class Tugas
    {

        public string name { get; set; }
        public int duration { get; set; }

        public string date{ get;set;}

        public Tugas(string name, int duration)
        {
            this.name = name;
            this.duration = duration;
            DateTime dt = DateTime.Today.AddDays(duration);
            this.date = dt.ToShortDateString();
        }
    }
}
