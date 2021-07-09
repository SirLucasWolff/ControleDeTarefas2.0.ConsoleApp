using ControleDeTarefas2._0.ConsoleApp.Version1;
using ControleDeTarefas2._0.ConsoleApp.Version2;
using ControleDeTarefas2._0.ConsoleApp.Version3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeTarefas2._0.ConsoleApp
{
    class ScreenStart
    {
        public static int Option;

        public static void screenStart()
        {
            Console.WriteLine("Choose the option");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Task management = 1");
            Console.WriteLine("Contact management = 2");
            Console.WriteLine("Compromise management = 3");
            Console.ResetColor();
            Option = Convert.ToInt32(Console.ReadLine());

            if (Option == 1)
            {
                ScreenTask.screenTask();
            }
            if (Option == 2)
            {
                ScreenContact.screenContact();
            }
            if (Option == 3)
            {
                ScreenCompromise.screenCompromise();
            }

        }
    }
}
