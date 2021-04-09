using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reSchedule
{
    class Entry
    {
        public string name { get; set; }
        public string key { get; set; }

        public Entry(string name, string key)
        {
            this.name = name;
            this.key = key;
        }
    }
}
