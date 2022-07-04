using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTasks
{
    public class Task
    {
        public string? name { get; set; }
        public string? description { get; set; }
        public string? status { get; set; }
        public string? deadLine { get; set; }

        List<Subtask> subtasks = new List<Subtask>();

        public void AddSubtask(string nameSubtask)
        {
            Subtask sub = new Subtask();
            sub.Name = nameSubtask;
            subtasks.Add(sub);
        }

        public void ViewAllSubtask()
        {
            foreach (var i in subtasks)
            {
                Console.WriteLine(i.Name + "     " + i.Status);
            }
        }

        public void SubtaskDone(int num)
        {
            var sub = subtasks[num];
            sub.Status = "Done";
            subtasks[num] = sub;
        }

        public Task()
        {
            name = null;
            description = null;
            status = null;
            deadLine = null;
        }
    }
}
