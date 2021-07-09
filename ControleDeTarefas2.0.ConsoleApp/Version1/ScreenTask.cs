using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeTarefas2._0.ConsoleApp.Version1
{
    public class ScreenTask
    {
        public static int Option;

        public static void screenTask()
        {
            Console.Clear();
            Console.WriteLine("Add a task = 1");
            Console.WriteLine("View the tasks = 2");
            Console.WriteLine("Edit a task = 3");
            Console.WriteLine("Delete a task = 4");
            Console.WriteLine("Screen start = 5");
            Console.WriteLine("Exit = 0");
            Option = Convert.ToInt32(Console.ReadLine());

            if (Option == 1)
            {
                DBTasks.Insert();
            }
            if (Option == 2)
            {
                DBTasks.ViewDB();
            }
            if (Option == 3)
            {
                DBTasks.Edit();

            }
            if (Option == 4)
            {
                DBTasks.Delete();
            }
            if (Option == 5)
            {
                Console.Clear();
                ScreenStart.screenStart();
            }
            if (Option == 0)
            {

            }


        }
    }
}
