using ControleDeTarefas2._0.ConsoleApp.Version1;
using ControleDeTarefas2._0.ConsoleApp.Version2;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeTarefas2._0.ConsoleApp.Version3
{
    class DBCompromises
    {
        public static int Option { get; private set; }

        public static void InsertDB()
        {
            InsertCompromise compromise = new InsertCompromise();

            Console.Clear();
            Console.WriteLine("New subject:");
            compromise.Subject = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("New spot:");
            compromise.Spot = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("New compromise date:");
            compromise.CompromiseDate = Convert.ToDateTime(Console.ReadLine());

            if (compromise.CompromiseDate.DayOfWeek == DayOfWeek.Saturday)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The dates for compromises only from Monday at Friday!");
                Console.ReadLine();
                Console.ResetColor();
                InsertDB();
            }
            if (compromise.CompromiseDate.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The dates for compromises only from Monday at Friday!");
                Console.ReadLine();
                Console.ResetColor();
                InsertDB();
            }

            Console.Clear();
            Console.WriteLine("New start hour:");
            compromise.StartHour = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("New end hour:");
            compromise.EndHour = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Select the kind of compromise");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1 - Remote");
            Console.WriteLine("2 - Classroom");
            Console.ResetColor();

            Option = Convert.ToInt32(Console.ReadLine());
            if (Option == 1)
            {
                Console.Clear();
                compromise.KindCompromise = "Remote";
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
                {
                    DBControllerLink.InsertDBSqlServer();
                }
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
                {
                    DBControllerLink.InsertDBSqlLite();
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("Link registed with succsses, don't forget your compromise at date:" + compromise.CompromiseDate);
                Console.ResetColor();
                Console.ReadLine();
            }
            if (Option == 2)
            {
                Console.Clear();
                compromise.KindCompromise = "Classroom";
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("Compromise save, don't forget your compromise at date:" + compromise.CompromiseDate);
                Console.ResetColor();
                Console.ReadLine();
            }

            if (compromise.CompromiseDate <= DateTime.Now)
            {
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
                {
                    DBControllerCompromise.InsertDBSqlServer(compromise);
                }
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
                {
                    DBControllerCompromise.InsertDBSqlLite(compromise);
                }
            }
            if (compromise.CompromiseDate >= DateTime.Now)
            {
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
                {
                    DBControllerCompromise.InsertDBFutureSqlServer(compromise);
                }
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
                {
                    DBControllerCompromise.InsertDBFutureSqlLite(compromise);
                }
            }

            Console.Clear();
            Console.WriteLine("Your compromise is with someone of contacts?");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("2 - No");
            Option = Convert.ToInt32(Console.ReadLine());

            if (Option == 1)
            {
                InsertContact contact = new InsertContact();
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
                {
                    DBControllerCompromise.InsertDBContactsSqlServer(contact, compromise);
                }
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
                {
                    DBControllerCompromise.InsertDBContactsSqlLite(compromise);
                }
                DBContactsWithCompromise.Add();
            }
            if (Option == 2)
            {
                ScreenCompromise.screenCompromise();
            }
        }

        public static void View()
        {
            Console.Clear();
            InsertCompromise compromise = new InsertCompromise();
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
            {
                DBControllerCompromise.ViewDBSqlServer(compromise);
                Console.ReadLine();
            }
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
            {
                DBControllerCompromise.ViewDBSqlLite(compromise);
                Console.ReadLine();
            }

            ScreenCompromise.screenCompromise();
        }

        internal static void Edit()
        {
            Console.Clear();
            InsertCompromise compromise = new InsertCompromise();
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
            {
                DBControllerCompromise.ViewDBSqlServer(compromise);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("What you wish to edit?");
                Console.WriteLine("1 - Subject");
                Console.WriteLine("2 - Spot");
                Console.WriteLine("3 - Compromise Date");
                Console.WriteLine("4 - Start Hour");
                Console.WriteLine("5 - End Hour");
                Console.WriteLine("6 - Return to menu");
                Console.ResetColor();
                Option = Convert.ToInt32(Console.ReadLine());
                if (Option == 1)
                {
                    Console.Clear();
                    DBControllerCompromise.ViewDBSqlServer(compromise);
                    Console.WriteLine("Put the Id to edit:");
                    compromise.id = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ID Selected!");
                    Console.ResetColor();
                    Console.WriteLine("New subject of compromise:");
                    compromise.Subject = Console.ReadLine();
                    DBControllerCompromise.EditSubjectDBSqlServer(compromise);
                    Console.Clear();
                    DBControllerCompromise.ViewDBSqlServer(compromise);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Subjet of compromise edited!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Edit();
                }
                if (Option == 2)
                {
                    Console.Clear();
                    DBControllerCompromise.ViewDBSqlServer(compromise);
                    Console.WriteLine("Put the Id to edit:");
                    compromise.id = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ID Selected!");
                    Console.ResetColor();
                    Console.WriteLine("New spot of compromise:");
                    compromise.Spot = Console.ReadLine();
                    DBControllerCompromise.EditSpotDBSqlServer(compromise);
                    Console.Clear();
                    DBControllerCompromise.ViewDBSqlServer(compromise);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Spot of compromise edited!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Edit();
                }
                if (Option == 3)
                {
                    Console.Clear();
                    DBControllerCompromise.ViewDBSqlServer(compromise);
                    Console.WriteLine("Put the Id to edit:");
                    compromise.id = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ID Selected!");
                    Console.ResetColor();
                    Console.WriteLine("New compromise date of compromise:");
                    compromise.CompromiseDate = Convert.ToDateTime(Console.ReadLine());
                    DBControllerCompromise.EditCompromiseDateDBSqlServer(compromise);
                    Console.Clear();
                    DBControllerCompromise.ViewDBSqlServer(compromise);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Compromise date of compromise edited!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Edit();
                }
                if (Option == 4)
                {
                    Console.Clear();
                    DBControllerCompromise.ViewDBSqlServer(compromise);
                    Console.WriteLine("Put the Id to edit:");
                    compromise.id = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ID Selected!");
                    Console.ResetColor();
                    Console.WriteLine("New start hour of compromise:");
                    compromise.StartHour = Console.ReadLine();
                    DBControllerCompromise.EditStartHourDBSqlServer(compromise);
                    Console.Clear();
                    DBControllerCompromise.ViewDBSqlServer(compromise);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Start hour of compromise edited!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Edit();
                }
                if (Option == 5)
                {
                    Console.Clear();
                    DBControllerCompromise.ViewDBSqlServer(compromise);
                    Console.WriteLine("Put the Id to edit:");
                    compromise.id = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ID Selected!");
                    Console.ResetColor();
                    Console.WriteLine("New end hour of compromise:");
                    compromise.EndHour = Console.ReadLine();
                    DBControllerCompromise.EditEndHourDBSqlServer(compromise);
                    Console.Clear();
                    DBControllerCompromise.ViewDBSqlServer(compromise);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("End hour of compromise edited!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Edit();
                }
                if (Option == 6)
                {
                    Console.Clear();
                    ScreenCompromise.screenCompromise();
                }
            }
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
            {
                DBControllerCompromise.ViewDBSqlServer(compromise);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("What you wish to edit?");
                Console.WriteLine("1 - Subject");
                Console.WriteLine("2 - Spot");
                Console.WriteLine("3 - Compromise Date");
                Console.WriteLine("4 - Start Hour");
                Console.WriteLine("5 - End Hour");
                Console.WriteLine("6 - Return to menu");
                Console.ResetColor();
                Option = Convert.ToInt32(Console.ReadLine());
                if (Option == 1)
                {
                    Console.Clear();
                    DBControllerCompromise.ViewDBSqlLite(compromise);
                    Console.WriteLine("Put the Id to edit:");
                    compromise.id = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ID Selected!");
                    Console.ResetColor();
                    Console.WriteLine("New subject of compromise:");
                    compromise.Subject = Console.ReadLine();
                    DBControllerCompromise.EditSubjectDBSqlLite(compromise);
                    Console.Clear();
                    DBControllerCompromise.ViewDBSqlLite(compromise);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Subjet of compromise edited!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Edit();
                }
                if (Option == 2)
                {
                    Console.Clear();
                    DBControllerCompromise.ViewDBSqlLite(compromise);
                    Console.WriteLine("Put the Id to edit:");
                    compromise.id = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ID Selected!");
                    Console.ResetColor();
                    Console.WriteLine("New spot of compromise:");
                    compromise.Spot = Console.ReadLine();
                    DBControllerCompromise.EditSpotDBSqlLite(compromise);
                    Console.Clear();
                    DBControllerCompromise.ViewDBSqlLite(compromise);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Spot of compromise edited!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Edit();
                }
                if (Option == 3)
                {
                    Console.Clear();
                    DBControllerCompromise.ViewDBSqlLite(compromise);
                    Console.WriteLine("Put the Id to edit:");
                    compromise.id = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ID Selected!");
                    Console.ResetColor();
                    Console.WriteLine("New compromise date of compromise:");
                    compromise.CompromiseDate = Convert.ToDateTime(Console.ReadLine());
                    DBControllerCompromise.EditCompromiseDateDBSqlLite(compromise);
                    Console.Clear();
                    DBControllerCompromise.ViewDBSqlLite(compromise);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Compromise date of compromise edited!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Edit();
                }
                if (Option == 4)
                {
                    Console.Clear();
                    DBControllerCompromise.ViewDBSqlLite(compromise);
                    Console.WriteLine("Put the Id to edit:");
                    compromise.id = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ID Selected!");
                    Console.ResetColor();
                    Console.WriteLine("New start hour of compromise:");
                    compromise.StartHour = Console.ReadLine();
                    DBControllerCompromise.EditStartHourDBSqlLite(compromise);
                    Console.Clear();
                    DBControllerCompromise.ViewDBSqlLite(compromise);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Start hour of compromise edited!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Edit();
                }
                if (Option == 5)
                {
                    Console.Clear();
                    DBControllerCompromise.ViewDBSqlLite(compromise);
                    Console.WriteLine("Put the Id to edit:");
                    compromise.id = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ID Selected!");
                    Console.ResetColor();
                    Console.WriteLine("New end hour of compromise:");
                    compromise.EndHour = Console.ReadLine();
                    DBControllerCompromise.EditEndHourDBSqlLite(compromise);
                    Console.Clear();
                    DBControllerCompromise.ViewDBSqlLite(compromise);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("End hour of compromise edited!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Edit();
                }
                if (Option == 6)
                {
                    Console.Clear();
                    ScreenCompromise.screenCompromise();
                }
            }
        }

        public static void Delete()
        {
            Console.Clear();
            InsertCompromise compromise = new InsertCompromise();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("1 - Clear the list");
            Console.WriteLine("2 - Delete with Id");
            Console.WriteLine("3 - Return to menu");
            Console.ResetColor();
            Option = Convert.ToInt32(Console.ReadLine());
            if (Option == 1)
            {
                Console.Clear();
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
                {
                    DBControllerCompromise.DeleteListDBSqlServer(compromise);
                }
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
                {
                    DBControllerCompromise.DeleteListDBSqlLite(compromise);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The list of compromise are clear now!");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                ScreenTask.screenTask();
            }
            if (Option == 2)
            {
                Console.Clear();
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
                {
                    DBControllerCompromise.ViewDBSqlServer(compromise);
                    Console.WriteLine("Put the ID to delete the Task:");
                    compromise.id = Console.ReadLine();
                    DBControllerCompromise.DeleteIdDBSqlServer(compromise);
                }
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
                {
                    DBControllerCompromise.ViewDBSqlLite(compromise);
                    Console.WriteLine("Put the ID to delete the Task:");
                    compromise.id = Console.ReadLine();
                    DBControllerCompromise.DeleteIdDBSqlLite(compromise);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The id selected went deleted!");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                ScreenTask.screenTask();
            }
        }
    }
}
