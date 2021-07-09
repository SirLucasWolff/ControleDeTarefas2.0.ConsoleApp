using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeTarefas2._0.ConsoleApp.Version3
{
    class DBControllerLink
    {
        internal static void InsertDBSqlServer()
        {
            InsertLink link = new InsertLink();

            Console.WriteLine("Put the link:");
            link.Link = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Link registed with succsses, don't forget your compromise");
            Console.ResetColor();
            Console.ReadLine();

            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithLink = new SqlConnection();
            connectionWithLink.ConnectionString = AdressDBtask;

            connectionWithLink.Open();

            SqlCommand commandInsert = new SqlCommand();
            commandInsert.Connection = connectionWithLink;

            string sqlInsert =
            @"INSERT INTO DBLINK 
                (
                 [Link]
                )
                VALUES 
                (
                 @Link
                )";

            sqlInsert +=
                @"SELECT SCOPE_IDENTITY();";

            commandInsert.CommandText = sqlInsert;

            commandInsert.Parameters.AddWithValue("Link", link.Link);

            object id = commandInsert.ExecuteScalar();

            object Id = Convert.ToInt32(id);

            Console.WriteLine(commandInsert.ExecuteNonQuery());

            connectionWithLink.Close();
        }

        internal static void InsertDBSqlLite()
        {
            InsertLink link = new InsertLink();

            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"INSERT INTO DBLINK 
                    (
                    [Link]
                    )
                    VALUES 
                    (
                    @Link
                    )";

                cmd.Parameters.AddWithValue("@Subject", link.Link);

                Object id = cmd.ExecuteScalar();
                object Id = Convert.ToInt32(id);
            }
        }
    }
}
