using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Timetable
    {
        public int Date_Id { get; set; }
        public string Activity { get; set; }
        public string Supervisor { get; set; }
        public DateTime Date { get; set; }
        public string Startime { get; set; }
        public string Endtime { get; set; }
    }
}
