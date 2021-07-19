using ControleDeTarefas2._0.ConsoleApp.Version3;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeTarefas2._0.ConsoleApp.Version1
{
    class DBTasks
    {
        public static int Option { get; private set; }

        public static void Insert()
        {
            InsertTask insert = new InsertTask();

            Console.Clear();
            Console.WriteLine("New Task:");
            insert.NameOfTask = Console.ReadLine();
            Console.Clear();

            Console.Clear();
            Console.WriteLine("New Conclusion date:");
            insert.ConclusionDate = Convert.ToDateTime(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Choose the importance level");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Low = 1");
            Console.WriteLine("Normal = 2");
            Console.WriteLine("High = 3");
            Console.ResetColor();
            Option = Convert.ToInt32(Console.ReadLine());

            if (Option == 1)
            {
                insert.ImportanceLevel = "Low";

            }
            if (Option == 2)
            {
                insert.ImportanceLevel = "Normal";

            }
            if (Option == 3)
            {
                insert.ImportanceLevel = "High";

            }
            Console.Clear();

            insert.ConclusionPercent = 0;

            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
            {
                DBControllerTask.InsertDBSqlServer(insert);
            }
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
            {
                DBControllerTask.InserDBSqlLite(insert);
            }
        }

        public static void ViewDB()
        {
            Console.Clear();
            InsertTask insert = new InsertTask();
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
            {
                DBControllerTask.ViewDBSqlServer(insert);
                Console.ReadLine();
            }
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
            {
                DBControllerTask.ViewDBSqlLite(insert);
                Console.ReadLine();
            }
            ScreenTask.screenTask();
        }

        public static void Delete()
        {
            Console.Clear();
            InsertTask insert = new InsertTask();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("1 - Clear the list?");
            Console.WriteLine("2 - Delete complete tasks");
            Console.WriteLine("3 - Delete with Id");
            Console.WriteLine("4 - Retur to Screen Task");
            Console.ResetColor();
            Option = Convert.ToInt32(Console.ReadLine());
            if (Option == 1)
            {
                Console.Clear();
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
                {
                    DBControllerTask.DeleteListDBSqlServer(insert);
                }
                else if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
                {
                    DBControllerTask.DeleteListDBSqlLite(insert);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The list of tasks are clear now!");
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
                    DBControllerTask.DeleteCompleteTasksDBSqlServer(insert);
                }
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
                {
                    DBControllerTask.DeleteCompleteTasksDBSqlLite(insert);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The completes tasks went deleted!");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                ScreenTask.screenTask();
            }
            if (Option == 3)
            {
                Console.Clear();
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
                {
                    DBControllerTask.ViewDBSqlServer(insert);
                    Console.WriteLine("Put the ID to delete the Task:");
                    insert.id = Console.ReadLine();
                    DBControllerTask.DeleteIdTasksDBSqlServer(insert);
                }
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
                {
                    DBControllerTask.ViewDBSqlLite(insert);
                    Console.WriteLine("Put the ID to delete the Task:");
                    insert.id = Console.ReadLine();
                    DBControllerTask.DeleteIdTasksDBSqlLite(insert);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The id selected went deleted!");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                ScreenTask.screenTask();
            }
            if (Option == 4)
            {
                ScreenTask.screenTask();
            }
        }

        public static void Edit()
        {
            Console.Clear();
            InsertTask insert = new InsertTask();
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
            {
                DBControllerTask.ViewDBSqlServer(insert);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("What you wish to edit?");
                Console.WriteLine("1 - Task");
                Console.WriteLine("2 - Conclusion Date");
                Console.WriteLine("3 - Conclusion Percent");
                Console.WriteLine("4 - Return to menu");
                Console.ResetColor();
                Option = Convert.ToInt32(Console.ReadLine());
                if (Option == 1)
                {
                    Console.Clear();
                    DBControllerTask.ViewDBSqlServer(insert);
                    Console.WriteLine("Put the Id to edit:");
                    insert.id = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ID Selected!");
                    Console.ResetColor();
                    Console.WriteLine("New name of task:");
                    insert.NameOfTask = Console.ReadLine();
                    DBControllerTask.EditTaskDBSqlServer(insert);
                    Console.Clear();
                    DBControllerTask.ViewDBSqlServer(insert);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Name of task edited!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Edit();
                }
                if (Option == 2)
                {
                    Console.Clear();
                    DBControllerTask.ViewDBSqlServer(insert);
                    Console.WriteLine("Put the Id to edit:");
                    insert.id = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ID Selected!");
                    Console.ResetColor();
                    Console.WriteLine("New Conclusion Date:");
                    insert.ConclusionDate = Convert.ToDateTime(Console.ReadLine());
                    DBControllerTask.EditConclusionDateDBSqlServer(insert);
                    Console.Clear();
                    DBControllerTask.ViewDBSqlServer(insert);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Conclusion date of task edited!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Edit();
                }
                if (Option == 3)
                {
                    Console.Clear();
                    DBControllerTask.ViewDBSqlServer(insert);
                    Console.WriteLine("Put the Id to edit:");
                    insert.id = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ID Selected!");
                    Console.ResetColor();
                    Console.WriteLine("New conclusion percent:");
                    Console.WriteLine("0% - 0");
                    Console.WriteLine("10% - 1");
                    Console.WriteLine("20% - 2");
                    Console.WriteLine("30% - 3");
                    Console.WriteLine("40% - 4");
                    Console.WriteLine("50% - 5");
                    Console.WriteLine("60% - 6");
                    Console.WriteLine("70% - 7");
                    Console.WriteLine("80% - 8");
                    Console.WriteLine("90% - 9");
                    Console.WriteLine("100% - 10");
                    Option = Convert.ToInt32(Console.ReadLine());
                    if (Option == 0)
                    {
                        insert.ConclusionPercent = 0;
                    }
                    if (Option == 1)
                    {
                        insert.ConclusionPercent = 10;
                    }
                    if (Option == 2)
                    {
                        insert.ConclusionPercent = 20;
                    }
                    if (Option == 3)
                    {
                        insert.ConclusionPercent = 30;
                    }
                    if (Option == 4)
                    {
                        insert.ConclusionPercent = 40;
                    }
                    if (Option == 5)
                    {
                        insert.ConclusionPercent = 50;
                    }
                    if (Option == 6)
                    {
                        insert.ConclusionPercent = 60;
                    }
                    if (Option == 7)
                    {
                        insert.ConclusionPercent = 70;
                    }
                    if (Option == 8)
                    {
                        insert.ConclusionPercent = 80;
                    }
                    if (Option == 9)
                    {
                        insert.ConclusionPercent = 90;
                    }
                    if (Option == 10)
                    {
                        insert.ConclusionPercent = 100;
                    }
                    DBControllerTask.EditConclusionPercentDBSqlServer(insert);
                    Console.Clear();
                    DBControllerTask.ViewDBSqlServer(insert);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Conclusion percent edited!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Edit();
                }
                if (Option == 4)
                {
                    Console.Clear();
                    ScreenTask.screenTask();
                }
            }
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
            {
                DBControllerTask.ViewDBSqlLite(insert);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("What you wish to edit?");
                Console.WriteLine("1 - Task");
                Console.WriteLine("2 - Conclusion Date");
                Console.WriteLine("3 - Conclusion Percent");
                Console.WriteLine("4 - Return to menu");
                Console.ResetColor();
                Option = Convert.ToInt32(Console.ReadLine());
                if (Option == 1)
                {
                    Console.Clear();
                    DBControllerTask.ViewDBSqlLite(insert);
                    Console.WriteLine("Put the Id to edit:");
                    insert.id = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ID Selected!");
                    Console.ResetColor();
                    Console.WriteLine("New name of task:");
                    insert.NameOfTask = Console.ReadLine();
                    DBControllerTask.EditTaskDBSqlLite(insert);
                    Console.Clear();
                    DBControllerTask.ViewDBSqlLite(insert);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Name of task edited!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Edit();
                }
                if (Option == 2)
                {
                    Console.Clear();
                    DBControllerTask.ViewDBSqlLite(insert);
                    Console.WriteLine("Put the Id to edit:");
                    insert.id = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ID Selected!");
                    Console.ResetColor();
                    Console.WriteLine("New Conclusion Date:");
                    insert.ConclusionDate = Convert.ToDateTime(Console.ReadLine());
                    DBControllerTask.EditConclusionDateDBSqlLite(insert);
                    Console.Clear();
                    DBControllerTask.ViewDBSqlLite(insert);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Conclusion date of task edited!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Edit();
                }
                if (Option == 3)
                {
                    Console.Clear();
                    DBControllerTask.ViewDBSqlLite(insert);
                    Console.WriteLine("Put the Id to edit:");
                    insert.id = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ID Selected!");
                    Console.ResetColor();
                    Console.WriteLine("New conclusion percent:");
                    Console.WriteLine("0% - 0");
                    Console.WriteLine("10% - 1");
                    Console.WriteLine("20% - 2");
                    Console.WriteLine("30% - 3");
                    Console.WriteLine("40% - 4");
                    Console.WriteLine("50% - 5");
                    Console.WriteLine("60% - 6");
                    Console.WriteLine("70% - 7");
                    Console.WriteLine("80% - 8");
                    Console.WriteLine("90% - 9");
                    Console.WriteLine("100% - 10");
                    Option = Convert.ToInt32(Console.ReadLine());
                    if (Option == 0)
                    {
                        insert.ConclusionPercent = 0;
                    }
                    if (Option == 1)
                    {
                        insert.ConclusionPercent = 10;
                    }
                    if (Option == 2)
                    {
                        insert.ConclusionPercent = 20;
                    }
                    if (Option == 3)
                    {
                        insert.ConclusionPercent = 30;
                    }
                    if (Option == 4)
                    {
                        insert.ConclusionPercent = 40;
                    }
                    if (Option == 5)
                    {
                        insert.ConclusionPercent = 50;
                    }
                    if (Option == 6)
                    {
                        insert.ConclusionPercent = 60;
                    }
                    if (Option == 7)
                    {
                        insert.ConclusionPercent = 70;
                    }
                    if (Option == 8)
                    {
                        insert.ConclusionPercent = 80;
                    }
                    if (Option == 9)
                    {
                        insert.ConclusionPercent = 90;
                    }
                    if (Option == 10)
                    {
                        insert.ConclusionPercent = 100;
                    }
                    DBControllerTask.EditConclusionPercentDBSqlLite(insert);
                    Console.Clear();
                    DBControllerTask.ViewDBSqlLite(insert);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Conclusion percent edited!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Edit();
                }
                if (Option == 4)
                {
                    Console.Clear();
                    ScreenTask.screenTask();
                }
            }
        }
    }
}
