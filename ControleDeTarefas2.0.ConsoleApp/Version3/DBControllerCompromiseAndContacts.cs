using System;
using System.Data.SqlClient;

namespace ControleDeTarefas2._0.ConsoleApp.Version3
{
    public class DBControllerCompromiseAndContacts
    {
        internal static void ViewDBSqlServer(InsertContact contact, InsertCompromise compromise)
        {
            foreach(var item in compromise.GetId )
            {
                string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

                SqlConnection connectionWithContact = new SqlConnection();
                connectionWithContact.ConnectionString = AdressDBtask;

                connectionWithContact.Open();

                SqlCommand commandGet = new SqlCommand();
                commandGet.Connection = connectionWithContact;

                string sqlGet =
                    @"SELECT * FROM DBCONTACTS
                  WHERE [ID] = @id ";

                sqlGet +=
                    @"SELECT SCOPE_IDENTITY();";

                commandGet.CommandText = sqlGet;
                commandGet.Parameters.AddWithValue("@id", item);

                using (SqlDataReader oReader = commandGet.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        contact.id = oReader["ID"].ToString();
                        contact.Name = oReader["Name"].ToString();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"| ID: {item}  |NOME: {contact.Name} |");
                    }
                }
                connectionWithContact.Close();
                Console.ResetColor();
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
                        contact.id = reader["Id"].ToString();
                        contact.Name = reader["Name"].ToString();
                        contact.Email = reader["Email"].ToString();
                        contact.Phone = (int)reader["Phone"];
                        contact.Firm = reader["Firm"].ToString();
                        contact.Position = reader["Position"].ToString();
                        Console.WriteLine($"| ID: {contact.id}  | NAME: {contact.Name} |");
                    }
                }
            }
        }
    }
}