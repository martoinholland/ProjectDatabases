using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Activity
    {
        public int ActivityID { get; set; }
        public string Description { get; set; }
        public int NumberOfStudents { get; set; }
        public int NumberOfSupervisors { get; set; }
    }
}
