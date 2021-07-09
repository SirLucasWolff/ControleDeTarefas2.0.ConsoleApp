using ControleDeTarefas2._0.ConsoleApp.Version2;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeTarefas2._0.ConsoleApp.Version3
{
    class DBControllerCompromise
    {
        private static string id;

        public static int Option { get; private set; }
        public static string NameofContact { get; private set; }
        public static string Status { get; private set; }
        public static object Compromise { get; private set; }

        internal static void InsertDBSqlServer(InsertCompromise compromise)
        {
            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithCompromise = new SqlConnection();
            connectionWithCompromise.ConnectionString = AdressDBtask;

            connectionWithCompromise.Open();

            SqlCommand commandInsert = new SqlCommand();
            commandInsert.Connection = connectionWithCompromise;

            string sqlInsert = @"INSERT INTO DBCOMPROMISE 
                (
                 [Subject],
                 [Spot],
                 [Compromise Date],
                 [Start hour],
                 [End hour],
                 [Kind of compromise]
                )
                VALUES 
                (
                 @Subject,
                 @Spot,
                 @CompromiseDate,
                 @Starthour,
                 @Endhour,
                 @Kindofcompromise
                )";

            sqlInsert +=
                @"SELECT SCOPE_IDENTITY();";

            commandInsert.CommandText = sqlInsert;

            commandInsert.Parameters.AddWithValue("Subject", compromise.Subject);
            commandInsert.Parameters.AddWithValue("Spot", compromise.Spot);
            commandInsert.Parameters.AddWithValue("CompromiseDate", compromise.CompromiseDate);
            commandInsert.Parameters.AddWithValue("Starthour", compromise.StartHour);
            commandInsert.Parameters.AddWithValue("Endhour", compromise.EndHour);
            commandInsert.Parameters.AddWithValue("Kindofcompromise", compromise.KindCompromise);

            object id = commandInsert.ExecuteScalar();

            object Id = Convert.ToInt32(id);

            Console.WriteLine(commandInsert.ExecuteNonQuery());

            connectionWithCompromise.Close();
        }

        internal static void InsertDBSqlLite(InsertCompromise compromise)
        {
            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"INSERT INTO DBCOMPROMISE 
                    (
                    [Subject],
                    [Spot],
                    [Compromise Date],
                    [Start hour],
                    [End hour],
                    [Kind of compromise]
                    )
                    VALUES 
                    (
                    @Subject,
                    @Spot,
                    @CompromiseDate,
                    @Starthour,
                    @Endhour,
                    @Kindofcompromise
                    )";

                cmd.Parameters.AddWithValue("@Subject", compromise.Subject);
                cmd.Parameters.AddWithValue("@Spot", compromise.Spot);
                cmd.Parameters.AddWithValue("@CompromiseDate", compromise.CompromiseDate);
                cmd.Parameters.AddWithValue("@Starthour", compromise.StartHour);
                cmd.Parameters.AddWithValue("@Endhour", compromise.EndHour);
                cmd.Parameters.AddWithValue("@Kindofcompromise", compromise.KindCompromise);
                Object id = cmd.ExecuteScalar();
                object Id = Convert.ToInt32(id);
            }
        }

        internal static void InsertDBFutureSqlServer(InsertCompromise compromise)
        {
            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithCompromise = new SqlConnection();
            connectionWithCompromise.ConnectionString = AdressDBtask;

            connectionWithCompromise.Open();

            SqlCommand commandInsert = new SqlCommand();
            commandInsert.Connection = connectionWithCompromise;

            string sqlInsert =
            @"INSERT INTO DBCOMPROMISEFUTURE 
                (
                 [Subject],
                 [Spot],
                 [Compromise Date],
                 [Start hour],
                 [End hour],
                 [Kind of compromise]
                )
                VALUES 
                (
                 @Subject,
                 @Spot,
                 @CompromiseDate,
                 @Starthour,
                 @Endhour,
                 @Kindofcompromise
                )";

            sqlInsert +=
                @"SELECT SCOPE_IDENTITY();";

            commandInsert.CommandText = sqlInsert;

            commandInsert.Parameters.AddWithValue("Subject", compromise.Subject);
            commandInsert.Parameters.AddWithValue("Spot", compromise.Spot);
            commandInsert.Parameters.AddWithValue("CompromiseDate", compromise.CompromiseDate);
            commandInsert.Parameters.AddWithValue("Starthour", compromise.StartHour);
            commandInsert.Parameters.AddWithValue("Endhour", compromise.EndHour);
            commandInsert.Parameters.AddWithValue("Kindofcompromise", compromise.KindCompromise);

            object id = commandInsert.ExecuteScalar();

            object Id = Convert.ToInt32(id);

            Console.WriteLine(commandInsert.ExecuteNonQuery());

            connectionWithCompromise.Close();
        }

        internal static void ViewDBSqlServer(InsertCompromise compromise)
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
                    compromise.Subject = oReader["Subject"].ToString();
                    compromise.Spot = oReader["Spot"].ToString();
                    compromise.StartHour = oReader["Start Hour"].ToString();
                    compromise.EndHour = oReader["End Hour"].ToString();
                    compromise.KindCompromise = oReader["Kind of Compromise"].ToString();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"| ID: {id}  | SUBJECT: {compromise.Subject} | SPOT: {compromise.Spot} | START HOUR: {compromise.StartHour} | END HOUR: {compromise.EndHour} | KIND OF COMPROMISE: {compromise.KindCompromise} |");
                }
            }
            connectionWithCompromise.Close();
            Console.ResetColor();
        }

        internal static void ViewDBSqlLite(InsertCompromise compromise)
        {
            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"SELECT * FROM DBCOMPROMISE
                                               ";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = reader["Id"].ToString();
                        compromise.Subject = reader["Subject"].ToString();
                        compromise.Spot = reader["Spot"].ToString();
                        compromise.StartHour = reader["Start Hour"].ToString();
                        compromise.EndHour = reader["End Hour"].ToString();
                        compromise.KindCompromise = reader["Kind of Compromise"].ToString();
                        Console.WriteLine($"| ID: {id}  | SUBJECT: {compromise.Subject} | SPOT: {compromise.Spot} | START HOUR: {compromise.StartHour} | END HOUR: {compromise.EndHour} | KIND OF COMPROMISE: {compromise.KindCompromise} |");
                    }
                }

            }
        }

        internal static void InsertDBContactsSqlLite(InsertCompromise compromise)
        {
            throw new NotImplementedException();
        }

        internal static void InsertDBContactsSqlServer(InsertContact contact, InsertCompromise compromise)
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
                    contact.Name = oReader["Name"].ToString();
                    contact.Email = oReader["Email"].ToString();
                    contact.Phone = (int)oReader["Phone"];
                    contact.Firm = oReader["Firm"].ToString();
                    contact.Position = oReader["Position"].ToString();
                    Console.ForegroundColor = ConsoleColor.Yellow;

                }
            }
            connectionWithContact.Close();

            Console.Clear();
            Console.WriteLine("Name of contact:");
            NameofContact = Console.ReadLine();

            if (NameofContact == contact.Name)
            {
                GetCompromiseSqlServer(compromise);
            }
            if (NameofContact != contact.Name)
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
                    InsertDBContactsSqlServer(contact, compromise);
                }
                if (Option == 2)
                {
                    ScreenCompromise.screenCompromise();
                }
                ScreenCompromise.screenCompromise();
            }
        }

        private static void GetCompromiseSqlServer(InsertCompromise compromise)
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
                    compromise.Subject = oReader["Subject"].ToString();
                }
            }
            connectionWithCompromise.Close();
            Console.ResetColor();

            InsertCompromiseWithContactSqlServer();
        }

        private static void InsertCompromiseWithContactSqlServer()
        {
            Compromise = "dede";

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
        }

        internal static void InsertDBFutureSqlLite(InsertCompromise compromise)
        {
            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"INSERT INTO DBCOMPROMISEFUTURE 
                    (
                    [Subject],
                    [Spot],
                    [Compromise Date],
                    [Start hour],
                    [End hour],
                    [Kind of compromise]
                    )
                    VALUES 
                    (
                    @Subject,
                    @Spot,
                    @CompromiseDate,
                    @Starthour,
                    @Endhour,
                    @Kindofcompromise
                    )";

                cmd.Parameters.AddWithValue("@Subject", compromise.Subject);
                cmd.Parameters.AddWithValue("@Spot", compromise.Spot);
                cmd.Parameters.AddWithValue("@CompromiseDate", compromise.CompromiseDate);
                cmd.Parameters.AddWithValue("@Starthour", compromise.StartHour);
                cmd.Parameters.AddWithValue("@Endhour", compromise.EndHour);
                cmd.Parameters.AddWithValue("@Kindofcompromise", compromise.KindCompromise);
                Object id = cmd.ExecuteScalar();
                object Id = Convert.ToInt32(id);
            }
        }

        internal static void EditSpotDBSqlServer(InsertCompromise compromise)
        {
            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithCompromise = new SqlConnection();
            connectionWithCompromise.ConnectionString = AdressDBtask;

            connectionWithCompromise.Open();

            SqlCommand commandEdit = new SqlCommand();
            commandEdit.Connection = connectionWithCompromise;
            Console.Clear();


            string sqlEdit =
               @"UPDATE DBCOMPROMISE
                 SET
                 [Spot] = @Spot
                 WHERE
                   [ID] = @id";

            commandEdit.CommandText = sqlEdit;
            commandEdit.Parameters.AddWithValue("@id", id);
            commandEdit.Parameters.AddWithValue("@Spot", compromise.Spot);

            commandEdit.ExecuteNonQuery();

            connectionWithCompromise.Close();

        }

        internal static void EditCompromiseDateDBSqlServer(InsertCompromise compromise)
        {
            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithCompromise = new SqlConnection();
            connectionWithCompromise.ConnectionString = AdressDBtask;

            connectionWithCompromise.Open();

            SqlCommand commandEdit = new SqlCommand();
            commandEdit.Connection = connectionWithCompromise;
            Console.Clear();


            string sqlEdit =
               @"UPDATE DBCOMPROMISE
                 SET
                 [Compromise Date] = @CompromiseDate
                 WHERE
                   [ID] = @id";

            commandEdit.CommandText = sqlEdit;
            commandEdit.Parameters.AddWithValue("@id", id);
            commandEdit.Parameters.AddWithValue("@CompromiseDate", compromise.CompromiseDate);

            commandEdit.ExecuteNonQuery();

            connectionWithCompromise.Close();

        }

        internal static void EditStartHourDBSqlServer(InsertCompromise compromise)
        {
            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithCompromise = new SqlConnection();
            connectionWithCompromise.ConnectionString = AdressDBtask;

            connectionWithCompromise.Open();

            SqlCommand commandEdit = new SqlCommand();
            commandEdit.Connection = connectionWithCompromise;
            Console.Clear();


            string sqlEdit =
               @"UPDATE DBCOMPROMISE
                 SET
                 [Start Hour] = @Start Hour
                 WHERE
                   [ID] = @id";

            commandEdit.CommandText = sqlEdit;
            commandEdit.Parameters.AddWithValue("@id", id);
            commandEdit.Parameters.AddWithValue("@Start Hour", compromise.StartHour);

            commandEdit.ExecuteNonQuery();

            connectionWithCompromise.Close();
        }

        internal static void EditEndHourDBSqlServer(InsertCompromise compromise)
        {
            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithCompromise = new SqlConnection();
            connectionWithCompromise.ConnectionString = AdressDBtask;

            connectionWithCompromise.Open();

            SqlCommand commandEdit = new SqlCommand();
            commandEdit.Connection = connectionWithCompromise;
            Console.Clear();


            string sqlEdit =
               @"UPDATE DBCOMPROMISE
                 SET
                 [End Hour] = @EndHour
                 WHERE
                   [ID] = @id";

            commandEdit.CommandText = sqlEdit;
            commandEdit.Parameters.AddWithValue("@id", id);
            commandEdit.Parameters.AddWithValue("@EndHour", compromise.EndHour);

            commandEdit.ExecuteNonQuery();

            connectionWithCompromise.Close();
        }

        internal static void DeleteIdDBSqlLite(InsertCompromise compromise)
        {
            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"DELETE FROM DBCOMPROMISE 
                                          WHERE [ID] = @Id";

                cmd.ExecuteNonQuery();
            }
        }

        internal static void DeleteIdDBSqlServer(InsertCompromise compromise)
        {
            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithCompromise = new SqlConnection();
            connectionWithCompromise.ConnectionString = AdressDBtask;

            connectionWithCompromise.Open();

            SqlCommand commandEdit = new SqlCommand();
            commandEdit.Connection = connectionWithCompromise;
            Console.Clear();


            string sqlEdit =
               @"DELETE FROM DBCOMPROMISE
                 WHERE
                   [ID] = @id";

            commandEdit.CommandText = sqlEdit;
            commandEdit.Parameters.AddWithValue("@id", id);

            commandEdit.ExecuteNonQuery();

            connectionWithCompromise.Close();
        }

        internal static void DeleteListDBSqlLite(InsertCompromise compromise)
        {
            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"DELETE FROM DBCOMPROMISE 
                                           ";

                cmd.ExecuteNonQuery();
            }
        }

        internal static void DeleteListDBSqlServer(InsertCompromise compromise)
        {
            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithCompromise = new SqlConnection();
            connectionWithCompromise.ConnectionString = AdressDBtask;

            connectionWithCompromise.Open();

            SqlCommand commandEdit = new SqlCommand();
            commandEdit.Connection = connectionWithCompromise;
            Console.Clear();


            string sqlEdit =
               @"DELETE FROM DBCOMPROMISE
                    ";

            commandEdit.CommandText = sqlEdit;

            commandEdit.ExecuteNonQuery();

            connectionWithCompromise.Close();
        }

        internal static void EditSubjectDBSqlServer(InsertCompromise compromise)
        {
            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithCompromise = new SqlConnection();
            connectionWithCompromise.ConnectionString = AdressDBtask;

            connectionWithCompromise.Open();

            SqlCommand commandEdit = new SqlCommand();
            commandEdit.Connection = connectionWithCompromise;
            Console.Clear();


            string sqlEdit =
               @"UPDATE DBCOMPROMISE
                 SET
                 [Subject] = @Subject
                 WHERE
                   [ID] = @id";

            commandEdit.CommandText = sqlEdit;
            commandEdit.Parameters.AddWithValue("@id", id);
            commandEdit.Parameters.AddWithValue("@Subject", compromise.Subject);

            commandEdit.ExecuteNonQuery();

            connectionWithCompromise.Close();

        }

        internal static void EditSpotDBSqlLite(InsertCompromise compromise)
        {
            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"UPDATE DBCOMPROMISE 
                                         SET [Spot] = @Spot
                                         WHERE [ID] = @id";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Spot", compromise.Spot);
                cmd.ExecuteNonQuery();
            }
        }

        internal static void EditSubjectDBSqlLite(InsertCompromise compromise)
        {
            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"UPDATE DBCOMPROMISE 
                                         SET [Subject] = @Subject
                                         WHERE [ID] = @id";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Subject", compromise.Subject);
                cmd.ExecuteNonQuery();
            }
        }

        internal static void EditCompromiseDateDBSqlLite(InsertCompromise compromise)
        {
            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"UPDATE DBCOMPROMISE 
                                         SET [Compromise Date] = @CompromiseDate
                                         WHERE [ID] = @id";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@CompromiseDate", compromise.CompromiseDate);
                cmd.ExecuteNonQuery();
            }
        }

        internal static void EditStartHourDBSqlLite(InsertCompromise compromise)
        {
            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"UPDATE DBCOMPROMISE 
                                         SET [Start Hour] = @StartHour
                                         WHERE [ID] = @id";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@StartHour", compromise.StartHour);
                cmd.ExecuteNonQuery();
            }
        }

        internal static void EditEndHourDBSqlLite(InsertCompromise compromise)
        {
            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"UPDATE DBCOMPROMISE 
                                         SET [End Hour] = @End Hour
                                         WHERE [ID] = @id";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@End Hour", compromise.EndHour);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
