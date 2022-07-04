using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MyTasks
{
    public class TaskGroup
    {
        public string name;

        List<Task> _tasksInGroup = new List<Task>();

        public TaskGroup(string name)
        {
            this.name = name;
        }

        public void CreateNew()
        {
            Task task = new Task();
            Console.WriteLine("Придумайте имя задаче");
            task.name = Console.ReadLine();
            task.status = "Not done";
            Console.WriteLine("Добавьте описание задачи (если его нет напишите -)");
            task.description = Console.ReadLine();
            Console.WriteLine("Напишите дедлайн (если его нет напишите -)");
            task.deadLine = Console.ReadLine();
            Console.WriteLine("Есть ли у вас подзадачи для этой задачи ? Если есть напишите их количество, если их нет напишите 0");
            int i = int.Parse(Console.ReadLine());
            int j = 1;
            while (i != 0)
            {
                Console.WriteLine($"Напишите {j} подзадачу");
                task.AddSubtask(Console.ReadLine());
                j++;
                i--;
            }
            _tasksInGroup.Add(task);
        }

        public void Done(int num)
        {
            var task = _tasksInGroup[num];
            task.status = "Done";
            _tasksInGroup[num] = task;
        }

        public void DeleteTask(int num)
        {
            _tasksInGroup.RemoveAt(num);
        }

        public void MoreInfo(int num)
        {
            var task = _tasksInGroup[num];
            Console.WriteLine(task.name);
            Console.WriteLine(task.description);
            Console.WriteLine(task.deadLine);
            Console.WriteLine(task.status);
            task.ViewAllSubtask();
        }

        public void ViewAll()
        {
            foreach (var task in _tasksInGroup)
            {
                Console.WriteLine(task.name + "    "  + task.status + "    " + task.deadLine);
            }
        }

    }
}
