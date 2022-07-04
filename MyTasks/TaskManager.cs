using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTasks
{
    internal class TaskManager
    {
        List<TaskGroup> groups = new List<TaskGroup>();
        List<Task> tasks = new List<Task>();

        public void CreateGroup()
        {
            Console.WriteLine("Введите название группы");
            TaskGroup group = new TaskGroup(Console.ReadLine());
            groups.Add(group);
        }

        public void DeleteGroup(int num)
        {
            groups.RemoveAt(num);
        }

        public void ViewGroup(int num)
        {
            groups[num].ViewAll();
        }

        public void ViewAll()
        {
            Console.WriteLine("Groups:");
            int a = 1;
            int b = 1;
            foreach (var group in groups)
            {
                Console.WriteLine(a + ". " + group.name);
                a++;
            }

            Console.WriteLine("Tasks:");
            foreach (var task in tasks)
            {
                Console.WriteLine(b + ". " + task.name + "  " + task.status + "  " + task.deadLine);
                b++;
            }
        }
    }
}
