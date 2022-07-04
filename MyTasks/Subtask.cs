using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTasks
{
    public struct Subtask
    {
        public Subtask()
        {
            Name = null;
        }

        public string Name { get; set; }
        public string Status { get; set; } = "Not done";
    }
}
