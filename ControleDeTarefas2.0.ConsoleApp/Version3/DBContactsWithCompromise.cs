using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeTarefas2._0.ConsoleApp.Version3
{
    class DBContactsWithCompromise
    {
        private static string id;

        public static string Subject { get; private set; }
        public static string Name { get; private set; }
        public static string Email { get; private set; }
        public static int Phone { get; private set; }
        public static string Firm { get; private set; }
        public static string Position { get; private set; }
        public static string NameofContact { get; set; }
        public static object Compromise { get; set; }
        public static object Status { get; set; }
        public static string OptionName { get; set; }
        public static int Option { get; private set; }
        public static object Pending { get; private set; }

        public static void Add()
        {
            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithContact = new SqlConnection();
            connectionWithContact.ConnectionString = AdressDBtask;

            connectionWithContact.Open();

            SqlCommand commandGet = new SqlCommand();
            commandGet.Connection = connectionWithContact;

            string sqlGet =
                @"SELECT * FROM DBCONTACTS
                   ";

            sqlGet +=
                @"SELECT SCOPE_IDENTITY();";

            commandGet.CommandText = sqlGet;

            using (SqlDataReader oReader = commandGet.ExecuteReader())
            {
                while (oReader.Read())
                {
                    id = oReader["ID"].ToString();
                    Name = oReader["Name"].ToString();
                    Email = oReader["Email"].ToString();
                    Phone = (int)oReader["Phone"];
                    Firm = oReader["Firm"].ToString();
                    Position = oReader["Position"].ToString();
                    Console.ForegroundColor = ConsoleColor.Yellow;

                }
            }
            connectionWithContact.Close();

            Console.Clear();
            Console.WriteLine("Name of contact:");
            NameofContact = Console.ReadLine();

            if (NameofContact == Name)
            {
                GetCompromise();
            }
            if (NameofContact != Name)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Contact not found!");
                Console.ReadLine();
                Console.ResetColor();
                Console.WriteLine("1 - Try again");
                Console.WriteLine("2 - Exit");
                Option = Convert.ToInt32(Console.ReadLine());
                if (Option == 1)
                {
                    Add();
                }
                if (Option == 2)
                {
                    ScreenCompromise.screenCompromise();
                }
                ScreenCompromise.screenCompromise();
            }


        }

        public static void GetCompromise()
        {
            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithCompromise = new SqlConnection();
            connectionWithCompromise.ConnectionString = AdressDBtask;

            connectionWithCompromise.Open();

            SqlCommand commandGet = new SqlCommand();
            commandGet.Connection = connectionWithCompromise;

            string sqlGet =
                @"SELECT * FROM DBCOMPROMISE
                   ";

            sqlGet +=
                @"SELECT SCOPE_IDENTITY();";

            commandGet.CommandText = sqlGet;

            using (SqlDataReader oReader = commandGet.ExecuteReader())
            {
                while (oReader.Read())
                {
                    id = oReader["ID"].ToString();
                    Subject = oReader["Subject"].ToString();
                }
            }
            connectionWithCompromise.Close();
            Console.ResetColor();


            Compromise = (Subject);


            InsertCC();
        }

        public static void Contact()
        {
            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithContact = new SqlConnection();
            connectionWithContact.ConnectionString = AdressDBtask;

            connectionWithContact.Open();

            SqlCommand commandGet = new SqlCommand();
            commandGet.Connection = connectionWithContact;

            string sqlGet =
                @"SELECT * FROM [TABLE]
                   ";

            sqlGet +=
                @"SELECT SCOPE_IDENTITY();";

            commandGet.CommandText = sqlGet;

            using (SqlDataReader oReader = commandGet.ExecuteReader())
            {
                while (oReader.Read())
                {
                    id = oReader["ID"].ToString();
                    NameofContact = oReader["Name"].ToString();
                    Compromise = oReader["Compromise"].ToString();
                    Status = oReader["Status"].ToString();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"| ID: {id}  | NOME OF CONTACT: {NameofContact} | COMPROMISE {Compromise} | STATUS: {Status} |");
                }
            }
            connectionWithContact.Close();
            Console.ResetColor();
            Console.WriteLine("1 - Delete all the contacts ready");
            Console.WriteLine("2 - Exit");
            Option = Convert.ToInt32(Console.ReadLine());
            if (Option == 1)
            {
                DeleteAllContactsReady();
            }
            if (Option == 2)
            {
                ScreenCompromise.screenCompromise();
            }
            Console.ReadLine();
            ScreenCompromise.screenCompromise();
        }

        public static void DeleteAllContactsReady()
        {
            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithContactsInCompromises = new SqlConnection();
            connectionWithContactsInCompromises.ConnectionString = AdressDBtask;

            connectionWithContactsInCompromises.Open();

            SqlCommand commandDelete = new SqlCommand();
            commandDelete.Connection = connectionWithContactsInCompromises;

            string sqlDelete =
                @"DELETE FROM [TABLE] 	                
	               WHERE
                    [Status] = 'Ready' ";

            commandDelete.CommandText = sqlDelete;

            commandDelete.ExecuteNonQuery();

            connectionWithContactsInCompromises.Close();

            Contact();
        }

        public static void ValidationName()
        {
            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithCC = new SqlConnection();
            connectionWithCC.ConnectionString = AdressDBtask;

            connectionWithCC.Open();

            SqlCommand commandValidation = new SqlCommand();
            commandValidation.Connection = connectionWithCC;

            string sqlValidation =
                @"SELECT * FROM DBCONTACTS 	                
	                WHERE 
		                [Name] = @Name";


            commandValidation.CommandText = sqlValidation;

            commandValidation.Parameters.AddWithValue("@Name", NameofContact);

            commandValidation.ExecuteNonQuery();

            connectionWithCC.Close();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Contact found!");
            Console.ReadLine();
            Console.ResetColor();

            InsertCC();
        }

        public static void CompromiseADD()
        {
            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithCompromise = new SqlConnection();
            connectionWithCompromise.ConnectionString = AdressDBtask;

            connectionWithCompromise.Open();

            SqlCommand commandGet = new SqlCommand();
            commandGet.Connection = connectionWithCompromise;

            string sqlGet =
                @"SELECT * FROM DBCOMPROMISE
                   ";

            sqlGet +=
                @"SELECT SCOPE_IDENTITY();";

            commandGet.CommandText = sqlGet;

            using (SqlDataReader oReader = commandGet.ExecuteReader())
            {
                while (oReader.Read())
                {
                    id = oReader["ID"].ToString();
                    Subject = oReader["Subject"].ToString();


                }
            }
            connectionWithCompromise.Close();
        }

        public static void InsertCC()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Contact found!");
            Console.Clear();
            Console.ReadLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("!Contact vinculed with your compromise");
            Console.ReadLine();
            Console.ResetColor();
            Status = ("Pending");
            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithCompromise = new SqlConnection();
            connectionWithCompromise.ConnectionString = AdressDBtask;

            connectionWithCompromise.Open();

            SqlCommand commandInsert = new SqlCommand();
            commandInsert.Connection = connectionWithCompromise;

            string sqlInsert =
            @"INSERT INTO [TABLE] 
                (
                 [Name],
                 [Compromise],
                 [Status]
                )
                VALUES 
                (
                 @Name,
                 @Compromise,
                 @Status
                )";

            sqlInsert +=
                @"SELECT SCOPE_IDENTITY();";

            commandInsert.CommandText = sqlInsert;

            commandInsert.Parameters.AddWithValue("Name", NameofContact);
            commandInsert.Parameters.AddWithValue("Compromise", Compromise);
            commandInsert.Parameters.AddWithValue("Status", Status);


            object id = commandInsert.ExecuteScalar();

            object Id = Convert.ToInt32(id);


            connectionWithCompromise.Close();
            ScreenCompromise.screenCompromise();
        }
    }
}
