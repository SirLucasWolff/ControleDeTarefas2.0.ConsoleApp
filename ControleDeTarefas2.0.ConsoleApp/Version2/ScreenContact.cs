using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeTarefas2._0.ConsoleApp.Version2
{
    class ScreenContact
    {
        private static int Option;

        internal static void screenContact()
        {
            Console.Clear();
            Console.WriteLine("Add a contact = 1");
            Console.WriteLine("View the contacts = 2");
            Console.WriteLine("Edit a contact = 3");
            Console.WriteLine("Delete a contact = 4");
            Console.WriteLine("Screen start = 5");
            Console.WriteLine("Exit = 0");
            Option = Convert.ToInt32(Console.ReadLine());

            if (Option == 1)
            {
                DBContact.Insert();
            }
            if (Option == 2)
            {
                DBContact.View();
            }
            if (Option == 3)
            {
                DBContact.Edit();
            }
            if (Option == 4)
            {
                DBContact.Delete();
            }
            if (Option == 5)
            {
                ScreenStart.screenStart();
            }
            if (Option == 0)
            {

            }
        }
    }
}

