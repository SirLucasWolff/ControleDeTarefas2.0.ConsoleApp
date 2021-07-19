using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeTarefas2._0.ConsoleApp.Version3
{
    class DBCotrollerContacts
    {
        private static string id;

        internal static void InsertDBSqlServer(InsertContact contact)
        {
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

        internal static void InsertDBSqlLite(InsertContact contact)
        {
            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"INSERT INTO DBCONTACTS 
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

                cmd.Parameters.AddWithValue("@Name", contact.Name);
                cmd.Parameters.AddWithValue("@Email", contact.Email);
                cmd.Parameters.AddWithValue("@Phone", contact.Phone);
                cmd.Parameters.AddWithValue("@Firm", contact.Firm);
                cmd.Parameters.AddWithValue("@Position", contact.Position);
                Object id = cmd.ExecuteScalar();
                object Id = Convert.ToInt32(id);

            }
        }

        public static void ViewOnlyNameSqlLite(InsertContact contact)
        {
            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"SELECT * FROM DBCONTACTS
                                               ";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = reader["Id"].ToString();
                        contact.Name = reader["Name"].ToString();
                        contact.Email = reader["Email"].ToString();
                        contact.Phone = (int)reader["Phone"];
                        contact.Firm = reader["Firm"].ToString();
                        contact.Position = reader["Position"].ToString();
                        Console.WriteLine($"| ID: {id}  | NAME: {contact.Name} |");
                    }
                }
            }
        }

        public static void ViewOnlyNameSqlServer(InsertContact contact)
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
                    Console.WriteLine($"| ID: {id}  |NOME: {contact.Name} |");
                }
            }
            connectionWithContact.Close();
            Console.ResetColor();
        }

        internal static void ViewDBSqlServer(InsertContact contact)
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
                    Console.WriteLine($"| ID: {id}  |NOME: {contact.Name} | EMAIL: {contact.Email} | PHONE: {contact.Phone} | FIRM: {contact.Firm} | POSITION: {contact.Position} |");
                }
            }
            connectionWithContact.Close();
            Console.ResetColor();
        }

        internal static void EditContactNameDBSqlServer(InsertContact contact)
        {
            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithContact = new SqlConnection();
            connectionWithContact.ConnectionString = AdressDBtask;

            connectionWithContact.Open();

            SqlCommand commandEdit = new SqlCommand();
            commandEdit.Connection = connectionWithContact;

            string sqlEdit =
                @"UPDATE DBCONTACTS
                 SET
                   [Name] = @Name
                 WHERE
                   [ID] = @id";

            commandEdit.CommandText = sqlEdit;

            commandEdit.Parameters.AddWithValue("@id", id);
            commandEdit.Parameters.AddWithValue("@Name", contact.Name);

            commandEdit.ExecuteNonQuery();

            connectionWithContact.Close();
        }

        internal static void EditContactEmailDBSqlServer(InsertContact contact)
        {
            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithContact = new SqlConnection();
            connectionWithContact.ConnectionString = AdressDBtask;

            connectionWithContact.Open();

            SqlCommand commandEdit = new SqlCommand();
            commandEdit.Connection = connectionWithContact;

            string sqlEdit =
                @"UPDATE DBCONTACTS
                 SET
                   [Email] = @Email
                 WHERE
                   [ID] = @id";

            commandEdit.CommandText = sqlEdit;

            commandEdit.Parameters.AddWithValue("@id", id);
            commandEdit.Parameters.AddWithValue("@Email", contact.Email);

            commandEdit.ExecuteNonQuery();

            connectionWithContact.Close();
        }

        internal static void EditContactPhoneDBSqlServer(InsertContact contact)
        {
            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithContact = new SqlConnection();
            connectionWithContact.ConnectionString = AdressDBtask;

            connectionWithContact.Open();

            SqlCommand commandEdit = new SqlCommand();
            commandEdit.Connection = connectionWithContact;

            string sqlEdit =
                @"UPDATE DBCONTACTS
                 SET
                   [Phone] = @Phone
                 WHERE
                   [ID] = @id";

            commandEdit.CommandText = sqlEdit;

            commandEdit.Parameters.AddWithValue("@id", id);
            commandEdit.Parameters.AddWithValue("@Phone", contact.Phone);

            commandEdit.ExecuteNonQuery();

            connectionWithContact.Close();
        }

        internal static void EditContactFirmDBSqlServer(InsertContact contact)
        {
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

            commandEdit.Parameters.AddWithValue("@id", id);
            commandEdit.Parameters.AddWithValue("@Firm", contact.Firm);

            commandEdit.ExecuteNonQuery();

            connectionWithContact.Close();
        }

        internal static void DeleteListDBSqlLite(InsertContact contact)
        {
            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"DELETE FROM DBCONTACTS 
                                         ";

                cmd.ExecuteNonQuery();
            }
        }

        internal static void EditContactNameDBSqlLite(InsertContact contact)
        {
            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"UPDATE DBCONTACTS 
                                         SET [Name] = @Name
                                         WHERE [ID] = @id";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Name", contact.Name);
                cmd.ExecuteNonQuery();
            }
        }

        internal static void DeleteListDBSqlServer(InsertContact contact)
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

        internal static void EditContactEmailDBSqlLite(InsertContact contact)
        {
            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"UPDATE DBCONTACTS 
                                         SET [Email] = @Email
                                         WHERE [ID] = @id";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Email", contact.Email);
                cmd.ExecuteNonQuery();
            }
        }

        internal static void DeleteIdDBSqlLite(InsertContact contact)
        {
            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"DELETE FROM DBCONTACTS 
                                        WHERE [ID] = @Id";
                cmd.Parameters.AddWithValue("@Id", contact.id);
                cmd.ExecuteNonQuery();
            }
        }

        internal static void DeleteIdDBSqlServer(InsertContact contact)
        {
            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithContact = new SqlConnection();
            connectionWithContact.ConnectionString = AdressDBtask;

            connectionWithContact.Open();

            SqlCommand commandDelete = new SqlCommand();
            commandDelete.Connection = connectionWithContact;

            string sqlDelete =
                @"DELETE FROM DBCONTACTS 
                         WHERE [ID] = @Id";

            commandDelete.CommandText = sqlDelete;

            commandDelete.Parameters.AddWithValue("@Id", contact.id);
            commandDelete.ExecuteNonQuery();

            connectionWithContact.Close();
        }

        internal static void EditContactPhoneDBSqlLite(InsertContact contact)
        {
            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"UPDATE DBCONTACTS 
                                         SET [Phone] = @Phone
                                         WHERE [ID] = @id";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Phone", contact.Phone);
                cmd.ExecuteNonQuery();
            }
        }

        internal static void EditContactFirmDBSqlLite(InsertContact contact)
        {
            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"UPDATE DBCONTACTS 
                                         SET [Firm] = @Firm
                                         WHERE [ID] = @id";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Firm", contact.Firm);
                cmd.ExecuteNonQuery();
            }
        }

        internal static void EditContactPositionDBSqlServer(InsertContact contact)
        {
            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithContact = new SqlConnection();
            connectionWithContact.ConnectionString = AdressDBtask;

            connectionWithContact.Open();

            SqlCommand commandEdit = new SqlCommand();
            commandEdit.Connection = connectionWithContact;

            string sqlEdit =
                @"UPDATE DBCONTACTS
                 SET
                   [Position] = @Position
                 WHERE
                   [ID] = @id";

            commandEdit.CommandText = sqlEdit;

            commandEdit.Parameters.AddWithValue("@id", id);
            commandEdit.Parameters.AddWithValue("@Position", contact.Position);

            commandEdit.ExecuteNonQuery();

            connectionWithContact.Close();
        }

        internal static void EditContactPositionDBSqlLite(InsertContact contact)
        {
            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"UPDATE DBCONTACTS 
                                         SET [Position] = @Position
                                         WHERE [ID] = @id";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Position", contact.Position);
                cmd.ExecuteNonQuery();
            }
        }

        internal static void ViewDBSqlLite(InsertContact contact)
        {
            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"SELECT * FROM DBCONTACTS
                                               ";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = reader["Id"].ToString();
                        contact.Name = reader["Name"].ToString();
                        contact.Email = reader["Email"].ToString();
                        contact.Phone = (int)reader["Phone"];
                        contact.Firm = reader["Firm"].ToString();
                        contact.Position = reader["Position"].ToString();
                        Console.WriteLine($"| ID: {id}  | NAME: {contact.Name} | EMAIL: {contact.Email} | PHONE: {contact.Phone} | FIRM: {contact.Firm} | POSITION: {contact.Position} |");
                    }
                }
            }
        }
    }
}
