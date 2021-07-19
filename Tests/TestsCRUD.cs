using ControleDeTarefas2._0.ConsoleApp.Version1;
using ControleDeTarefas2._0.ConsoleApp.Version2;
using ControleDeTarefas2._0.ConsoleApp.Version3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;

namespace Tests
{
    [TestClass]
    public class TestTasks
    {
        private string id;
        public DateTime CreationDate { get; private set; }
        public int ConclusionPercent { get; private set; }
        InsertTask insert = new InsertTask();

        [TestMethod]
        public void TestView()
        {
            CreationDate = DateTime.Now;
            ConclusionPercent = 0;


            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithTask = new SqlConnection();
            connectionWithTask.ConnectionString = AdressDBtask;

            connectionWithTask.Open();

            SqlCommand commandGet = new SqlCommand();
            commandGet.Connection = connectionWithTask;

            string sqlGet =
                @"SELECT * FROM DBTASK
                   ";

            sqlGet +=
                @"SELECT SCOPE_IDENTITY();";

            commandGet.CommandText = sqlGet;

            using (SqlDataReader oReader = commandGet.ExecuteReader())
            {
                while (oReader.Read())
                {
                    id = oReader["ID"].ToString();
                    insert.NameOfTask = oReader["Task"].ToString();
                    CreationDate = (DateTime)oReader["Creation Date"];
                    insert.ConclusionDate = (DateTime)oReader["Conclusion Date"];
                    insert.ImportanceLevel = oReader["Importance Level"].ToString();
                    ConclusionPercent = (int)oReader["Conclusion Percent"];
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
            }
            connectionWithTask.Close();
            Console.ResetColor();
        }

        [TestMethod]
        public void TestInsert()
        {
            CreationDate = DateTime.Now;
            insert.NameOfTask = "Estudar";
            insert.ConclusionDate = DateTime.Now;
            insert.ImportanceLevel = "ALTO";
            insert.ConclusionPercent = 10;

            string AdressDBTask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithTask = new SqlConnection();
            connectionWithTask.ConnectionString = AdressDBTask;

            connectionWithTask.Open();

            SqlCommand commandInsert = new SqlCommand();
            commandInsert.Connection = connectionWithTask;

            string sqlInsert =
                @"INSERT INTO DBTASK 
                (
                    [Task],
                    [Creation Date],
                    [Conclusion Date],
                    [Importance Level],
                    [Conclusion Percent]
                )
                VALUES 
                (
                    @Task,
                    @CreationDate,
                    @ConclusionDate,
                    @ImportanceLevel,
                    @ConclusionPercent
                )";
            sqlInsert +=
                @"SELECT SCOPE_IDENTITY();";

            commandInsert.CommandText = sqlInsert;

            commandInsert.Parameters.AddWithValue("Task", insert.NameOfTask);
            commandInsert.Parameters.AddWithValue("CreationDate", CreationDate);
            commandInsert.Parameters.AddWithValue("ConclusionDate", insert.ConclusionDate);
            commandInsert.Parameters.AddWithValue("ImportanceLevel", insert.ImportanceLevel);
            commandInsert.Parameters.AddWithValue("ConclusionPercent", ConclusionPercent);

            object id = commandInsert.ExecuteScalar();

            object Id = Convert.ToInt32(id);

            connectionWithTask.Close();
        }

        [TestMethod]
        public void TestDelete()
        {

            string AdressDBTask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithTask = new SqlConnection();
            connectionWithTask.ConnectionString = AdressDBTask;

            connectionWithTask.Open();

            SqlCommand commandDelete = new SqlCommand();
            commandDelete.Connection = connectionWithTask;

            string sqlDelete =
                @"DELETE FROM DBTASK 
                        ";


            commandDelete.CommandText = sqlDelete;



            object id = commandDelete.ExecuteScalar();

            object Id = Convert.ToInt32(id);

            connectionWithTask.Close();
        }

        [TestMethod]
        public void TestUpdate()
        {
            id = "55";
            insert.NameOfTask = "Comer";

            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithTask = new SqlConnection();
            connectionWithTask.ConnectionString = AdressDBtask;

            connectionWithTask.Open();

            SqlCommand commandEdit = new SqlCommand();
            commandEdit.Connection = connectionWithTask;

            string sqlEdit =
               @"UPDATE DBTASK
                 SET
                 [Task] = @Task
                 WHERE 
                   [ID] = @id";

            commandEdit.CommandText = sqlEdit;

            commandEdit.Parameters.AddWithValue("@id", id);
            commandEdit.Parameters.AddWithValue("@Task", insert.NameOfTask);

            commandEdit.ExecuteNonQuery();

            connectionWithTask.Close();
        }

    }

    [TestClass]
    public class TestContacts
    {
        InsertContact contact = new InsertContact();

        [TestMethod]
        public void TestInsert()
        {
            contact.Name = "Lucas";
            contact.Email = "lucaswolff2014@hotmail.com";
            contact.Phone = 32233221;
            contact.Firm = "Nasa";
            contact.Position = "Chefe";

            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithContact = new SqlConnection();
            connectionWithContact.ConnectionString = AdressDBtask;

            connectionWithContact.Open();

            SqlCommand commandInsert = new SqlCommand();
            commandInsert.Connection = connectionWithContact;

            string sqlInsert =
                @"INSERT INTO DBCONTACTS 
                (
                 [Name],
                 [Email],
                 [Phone],
                 [Firm],
                 [Position]
                )
                VALUES 
                (
                 @Name,
                 @Email,
                 @Phone,
                 @Firm,
                 @Position
                )";

            sqlInsert +=
                @"SELECT SCOPE_IDENTITY();";

            commandInsert.CommandText = sqlInsert;

            commandInsert.Parameters.AddWithValue("NAME", contact.Name);
            commandInsert.Parameters.AddWithValue("EMAIL", contact.Email);
            commandInsert.Parameters.AddWithValue("PHONE", contact.Phone);
            commandInsert.Parameters.AddWithValue("FIRM", contact.Firm);
            commandInsert.Parameters.AddWithValue("POSITION", contact.Position);

            object id = commandInsert.ExecuteScalar();

            object Id = Convert.ToInt32(id);

            connectionWithContact.Close();
        }

        [TestMethod]
        public void TestView()
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
                    contact.id = oReader["ID"].ToString();
                    contact.Name = oReader["Name"].ToString();
                    contact.Email = oReader["Email"].ToString();
                    contact.Phone = (int)oReader["Phone"];
                    contact.Firm = oReader["Firm"].ToString();
                    contact.Position = oReader["Position"].ToString();
                    Console.ForegroundColor = ConsoleColor.Yellow;

                }
            }
            connectionWithContact.Close();
            Console.ResetColor();
        }

        [TestMethod]
        public void TestDelete()
        {
            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithContact = new SqlConnection();
            connectionWithContact.ConnectionString = AdressDBtask;

            connectionWithContact.Open();

            SqlCommand commandDelete = new SqlCommand();
            commandDelete.Connection = connectionWithContact;

            string sqlDelete =
                @"DELETE FROM DBCONTACTS 
                   ";

            commandDelete.CommandText = sqlDelete;


            commandDelete.ExecuteNonQuery();

            connectionWithContact.Close();
        }

        [TestMethod]
        public void TestUpdate()
        {
            contact.id = "55";
            contact.Firm = "Nike";

            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithContact = new SqlConnection();
            connectionWithContact.ConnectionString = AdressDBtask;

            connectionWithContact.Open();

            SqlCommand commandEdit = new SqlCommand();
            commandEdit.Connection = connectionWithContact;

            string sqlEdit =
                @"UPDATE DBCONTACTS
                 SET
                   [Firm] = @Firm
                 WHERE
                   [ID] = @id";

            commandEdit.CommandText = sqlEdit;

            commandEdit.Parameters.AddWithValue("@id", contact.id);
            commandEdit.Parameters.AddWithValue("@Firm", contact.Firm);

            commandEdit.ExecuteNonQuery();

            connectionWithContact.Close();
        }
    }

    [TestClass]
    public class TestCompromise
    {
        InsertCompromise compromise = new InsertCompromise();
        private string id;

        [TestMethod]
        public void TestInsert()
        {
            compromise.Subject = "Auto feedback";
            compromise.Spot = "Universidade";
            compromise.CompromiseDate = DateTime.Now;
            compromise.StartHour = "14:00";
            compromise.EndHour = "15:00";
            compromise.KindCompromise = "Remoto";

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

        [TestMethod]
        public void TestView()
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

                }
            }
            connectionWithCompromise.Close();
            Console.ResetColor();
        }

        [TestMethod]
        public void TestDelete()
        {
            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithCompromise = new SqlConnection();
            connectionWithCompromise.ConnectionString = AdressDBtask;

            connectionWithCompromise.Open();

            SqlCommand commandEdit = new SqlCommand();
            commandEdit.Connection = connectionWithCompromise;

            string sqlEdit =
               @"DELETE FROM DBCOMPROMISE
                         ";

            commandEdit.CommandText = sqlEdit;


            commandEdit.ExecuteNonQuery();

            connectionWithCompromise.Close();
        }

        [TestMethod]
        public void TestUpdate()
        {
            compromise.id = "55";
            compromise.EndHour = "18";

            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithCompromise = new SqlConnection();
            connectionWithCompromise.ConnectionString = AdressDBtask;

            connectionWithCompromise.Open();

            SqlCommand commandEdit = new SqlCommand();
            commandEdit.Connection = connectionWithCompromise;

            string sqlEdit =
               @"UPDATE DBCOMPROMISE
                 SET
                 [End Hour] = @EndHour
                 WHERE
                   [ID] = @id";

            commandEdit.CommandText = sqlEdit;
            commandEdit.Parameters.AddWithValue("@id", compromise.id);
            commandEdit.Parameters.AddWithValue("@EndHour", compromise.EndHour);

            commandEdit.ExecuteNonQuery();

            connectionWithCompromise.Close();
        }
    }
}
