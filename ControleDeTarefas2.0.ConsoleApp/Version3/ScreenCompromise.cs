using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeTarefas2._0.ConsoleApp.Version3
{
    class ScreenCompromise
    {
        private static int Option;


        public static void screenCompromise()
        {
            

            Console.Clear();
            Console.WriteLine("Add a compromise = 1");
            Console.WriteLine("View the compromises = 2");
            Console.WriteLine("Edit a compromise = 3");
            Console.WriteLine("Delete a compromise = 4");
            Console.WriteLine("View the contacts = 5");
            Console.WriteLine("Screen start = 6");
            Console.WriteLine("Exit = 0");
            Option = Convert.ToInt32(Console.ReadLine());

            if (Option == 1)
            {
                DBCompromises.InsertDB();
            }
            if (Option == 2)
            {

                DBCompromises.View();
            }
            if (Option == 3)
            {
                DBCompromises.Edit();
            }
            if (Option == 4)
            {
                DBCompromises.Delete();
            }
            if (Option == 5)
            {
                InsertCompromise compromise = new InsertCompromise();
                InsertContact contact = new InsertContact();
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
                {
                    DBControllerCompromiseAndContacts.ViewDBSqlServer(contact, compromise);
                    Console.ReadLine();
                }
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
                {
                    DBControllerCompromiseAndContacts.ViewDBSqlLite(contact);
                    Console.ReadLine();
                }
                
            }
            if (Option == 6)
            {
                ScreenStart.screenStart();
            }
            if (Option == 0)
            {

            }
        }
    }
}
