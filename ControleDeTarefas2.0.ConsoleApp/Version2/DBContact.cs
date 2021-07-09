using ControleDeTarefas2._0.ConsoleApp.Version1;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeTarefas2._0.ConsoleApp.Version2
{
    class DBContact
    {
        public static int Option;

        public static void Insert()
        {
            InsertContact contact = new InsertContact();

            Console.Clear();
            Console.WriteLine("New name:");
            contact.Name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("New email:");
            contact.Email = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("New phone:");
            contact.Phone = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("New firm:");
            contact.Firm = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("New position:");
            contact.Position = Console.ReadLine();
            Console.Clear();

            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
            {
                DBCotrollerContacts.InsertDBSqlServer(contact);
            }
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
            {
                DBCotrollerContacts.InsertDBSqlLite(contact);
            }

            ScreenContact.screenContact();
        }

        public static void View()
        {
            Console.Clear();
            InsertContact contact = new InsertContact();
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
            {
                DBCotrollerContacts.ViewDBSqlServer(contact);
                Console.ReadLine();
            }
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
            {
                DBCotrollerContacts.ViewDBSqlLite(contact);
                Console.ReadLine();
            }
            ScreenContact.screenContact();
        }

        public static void Edit()
        {
            Console.Clear();
            InsertContact contact = new InsertContact();
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
            {
                DBCotrollerContacts.ViewDBSqlServer(contact);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("What you wish to edit?");
                Console.WriteLine("1 - Name");
                Console.WriteLine("2 - Email");
                Console.WriteLine("3 - Phone");
                Console.WriteLine("4 - Firm");
                Console.WriteLine("5 - Position");
                Console.WriteLine("6 - Return to menu");
                Console.ResetColor();
                Option = Convert.ToInt32(Console.ReadLine());
                if (Option == 1)
                {
                    Console.Clear();
                    DBCotrollerContacts.ViewDBSqlServer(contact);
                    Console.WriteLine("Put the Id to edit:");
                    contact.id = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ID Selected!");
                    Console.ResetColor();
                    Console.WriteLine("New name of contact:");
                    contact.Name = Console.ReadLine();
                    DBCotrollerContacts.EditContactNameDBSqlServer(contact);
                    Console.Clear();
                    DBCotrollerContacts.ViewDBSqlServer(contact);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Name of contact edited!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Edit();
                }
                if (Option == 2)
                {
                    Console.Clear();
                    DBCotrollerContacts.ViewDBSqlServer(contact);
                    Console.WriteLine("Put the Id to edit:");
                    contact.id = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ID Selected!");
                    Console.ResetColor();
                    Console.WriteLine("New email of contact:");
                    contact.Email = Console.ReadLine();
                    DBCotrollerContacts.EditContactEmailDBSqlServer(contact);
                    Console.Clear();
                    DBCotrollerContacts.ViewDBSqlServer(contact);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Email of contact edited!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Edit();
                }
                if (Option == 3)
                {
                    Console.Clear();
                    DBCotrollerContacts.ViewDBSqlServer(contact);
                    Console.WriteLine("Put the Id to edit:");
                    contact.id = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ID Selected!");
                    Console.ResetColor();
                    Console.WriteLine("New phone of contact:");
                    contact.Phone = Convert.ToInt32(Console.ReadLine());
                    DBCotrollerContacts.EditContactPhoneDBSqlServer(contact);
                    Console.Clear();
                    DBCotrollerContacts.ViewDBSqlServer(contact);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Phone of contact edited!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Edit();
                }
                if (Option == 4)
                {
                    Console.Clear();
                    DBCotrollerContacts.ViewDBSqlServer(contact);
                    Console.WriteLine("Put the Id to edit:");
                    contact.id = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ID Selected!");
                    Console.ResetColor();
                    Console.WriteLine("New firm of contact:");
                    contact.Firm = Console.ReadLine();
                    DBCotrollerContacts.EditContactFirmDBSqlServer(contact);
                    Console.Clear();
                    DBCotrollerContacts.ViewDBSqlServer(contact);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Firm of contact edited!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Edit();
                }
                if (Option == 5)
                {
                    Console.Clear();
                    DBCotrollerContacts.ViewDBSqlServer(contact);
                    Console.WriteLine("Put the Id to edit:");
                    contact.id = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ID Selected!");
                    Console.ResetColor();
                    Console.WriteLine("New position of contact:");
                    contact.Position = Console.ReadLine();
                    DBCotrollerContacts.EditContactPositionDBSqlServer(contact);
                    Console.Clear();
                    DBCotrollerContacts.ViewDBSqlServer(contact);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Position of contact edited!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Edit();
                }
                if (Option == 6)
                {
                    Console.Clear();
                    ScreenContact.screenContact();
                }
            }
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
            {
                DBCotrollerContacts.ViewDBSqlLite(contact);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("What you wish to edit?");
                Console.WriteLine("1 - Name");
                Console.WriteLine("2 - Email");
                Console.WriteLine("3 - Phone");
                Console.WriteLine("4 - Firm");
                Console.WriteLine("5 - Position");
                Console.WriteLine("6 - Return to menu");
                Console.ResetColor();
                Option = Convert.ToInt32(Console.ReadLine());
                if (Option == 1)
                {
                    Console.Clear();
                    DBCotrollerContacts.ViewDBSqlLite(contact);
                    Console.WriteLine("Put the Id to edit:");
                    contact.id = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ID Selected!");
                    Console.ResetColor();
                    Console.WriteLine("New name of contact:");
                    contact.Name = Console.ReadLine();
                    DBCotrollerContacts.EditContactNameDBSqlLite(contact);
                    Console.Clear();
                    DBCotrollerContacts.ViewDBSqlLite(contact);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Name of contact edited!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Edit();
                }
                if (Option == 2)
                {
                    Console.Clear();
                    DBCotrollerContacts.ViewDBSqlLite(contact);
                    Console.WriteLine("Put the Id to edit:");
                    contact.id = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ID Selected!");
                    Console.ResetColor();
                    Console.WriteLine("New email of contact:");
                    contact.Email = Console.ReadLine();
                    DBCotrollerContacts.EditContactEmailDBSqlLite(contact);
                    Console.Clear();
                    DBCotrollerContacts.ViewDBSqlLite(contact);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Email of contact edited!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Edit();
                }
                if (Option == 3)
                {
                    Console.Clear();
                    DBCotrollerContacts.ViewDBSqlLite(contact);
                    Console.WriteLine("Put the Id to edit:");
                    contact.id = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ID Selected!");
                    Console.ResetColor();
                    Console.WriteLine("New phone of contact:");
                    contact.Phone = Convert.ToInt32(Console.ReadLine());
                    DBCotrollerContacts.EditContactPhoneDBSqlLite(contact);
                    Console.Clear();
                    DBCotrollerContacts.ViewDBSqlLite(contact);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Phone of contact edited!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Edit();
                }
                if (Option == 4)
                {
                    Console.Clear();
                    DBCotrollerContacts.ViewDBSqlLite(contact);
                    Console.WriteLine("Put the Id to edit:");
                    contact.id = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ID Selected!");
                    Console.ResetColor();
                    Console.WriteLine("New firm of contact:");
                    contact.Firm = Console.ReadLine();
                    DBCotrollerContacts.EditContactFirmDBSqlLite(contact);
                    Console.Clear();
                    DBCotrollerContacts.ViewDBSqlLite(contact);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Firm of contact edited!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Edit();
                }
                if (Option == 5)
                {
                    Console.Clear();
                    DBCotrollerContacts.ViewDBSqlLite(contact);
                    Console.WriteLine("Put the Id to edit:");
                    contact.id = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ID Selected!");
                    Console.ResetColor();
                    Console.WriteLine("New position of contact:");
                    contact.Position = Console.ReadLine();
                    DBCotrollerContacts.EditContactPositionDBSqlLite(contact);
                    Console.Clear();
                    DBCotrollerContacts.ViewDBSqlLite(contact);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Position of contact edited!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Edit();
                }
                if (Option == 6)
                {
                    Console.Clear();
                    ScreenContact.screenContact();
                }
            }
        }

        internal static void Delete()
        {
            Console.Clear();
            InsertContact contact = new InsertContact();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("1 - Clear the list?");
            Console.WriteLine("3 - Delete with Id");
            Console.WriteLine("4 - Retur to menu");
            Console.ResetColor();
            Option = Convert.ToInt32(Console.ReadLine());
            if (Option == 1)
            {
                Console.Clear();
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
                {
                    DBCotrollerContacts.DeleteListDBSqlServer(contact);
                }
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
                {
                    DBCotrollerContacts.DeleteListDBSqlLite(contact);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The list of contacts are clear now!");
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
                    DBCotrollerContacts.ViewDBSqlServer(contact);
                    Console.WriteLine("Put the Id to delete");
                    contact.id = Console.ReadLine();
                    DBCotrollerContacts.DeleteIdDBSqlServer(contact);
                }
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
                {
                    DBCotrollerContacts.ViewDBSqlLite(contact);
                    Console.WriteLine("Put the Id to delete");
                    contact.id = Console.ReadLine();
                    DBCotrollerContacts.DeleteIdDBSqlLite(contact);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Id deleted!");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                ScreenTask.screenTask();
            }


        }
    }
}
