using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeTarefas2._0.ConsoleApp.Version1
{
    class DBControllerTask
    {
        public static DateTime CreationDate { get; private set; }
        public static int ConclusionPercent { get; private set; }
        public static string id { get; private set; }

        public static void InsertDBSqlServer(InsertTask insert)
        {
            CreationDate = DateTime.Now;
            ConclusionPercent = 0;

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
            Console.Clear();
            ScreenStart.screenStart();
        }

        internal static void InserDBSqlLite(InsertTask insert)
        {
            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"INSERT INTO DBTASK 
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

                cmd.Parameters.AddWithValue("@Task", insert.NameOfTask);
                cmd.Parameters.AddWithValue("@CreationDate", CreationDate);
                cmd.Parameters.AddWithValue("@ConclusionDate", insert.ConclusionDate);
                cmd.Parameters.AddWithValue("@ImportanceLevel", insert.ImportanceLevel);
                cmd.Parameters.AddWithValue("@ConclusionPercent", ConclusionPercent);
                Object id = cmd.ExecuteScalar();
                object Id = Convert.ToInt32(id);

                ScreenTask.screenTask();
            }
        }

        internal static void DeleteListDBSqlServer(InsertTask insert)
        {
            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithTask = new SqlConnection();
            connectionWithTask.ConnectionString = AdressDBtask;

            connectionWithTask.Open();

            SqlCommand commandDelete = new SqlCommand();
            commandDelete.Connection = connectionWithTask;

            string sqlDelete =
                @"DELETE FROM DBTASK 	                
	               ";


            commandDelete.CommandText = sqlDelete;



            commandDelete.ExecuteNonQuery();

            connectionWithTask.Close();
        }

        internal static void DeleteCompleteTasksDBSqlServer(InsertTask insert)
        {
            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithTask = new SqlConnection();
            connectionWithTask.ConnectionString = AdressDBtask;

            connectionWithTask.Open();

            SqlCommand commandDelete = new SqlCommand();
            commandDelete.Connection = connectionWithTask;

            string sqlDelete =
                @"DELETE FROM DBTASK 	                
	               WHERE
                 [Conclusion Percent] = 100";


            commandDelete.CommandText = sqlDelete;

            commandDelete.ExecuteNonQuery();

            connectionWithTask.Close();
        }

        internal static void DeleteIdTasksDBSqlServer(InsertTask insert)
        {
            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithTask = new SqlConnection();
            connectionWithTask.ConnectionString = AdressDBtask;

            connectionWithTask.Open();

            SqlCommand commandDelete = new SqlCommand();
            commandDelete.Connection = connectionWithTask;

            string sqlDelete =
                @"DELETE FROM DBTASK 	                
	                WHERE 
		                [ID] = @id";


            commandDelete.CommandText = sqlDelete;

            commandDelete.Parameters.AddWithValue("@id", insert.id);

            commandDelete.ExecuteNonQuery();

            connectionWithTask.Close();
        }

        internal static void DeleteIdTasksDBSqlLite(InsertTask insert)
        {
            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"DELETE FROM DBTASK 
                                         WHERE [Id] = @id  ";
                cmd.Parameters.AddWithValue("@id", insert.id);
                cmd.ExecuteNonQuery();

            }
        }

        internal static void EditTaskDBSqlServer(InsertTask insert)
        {
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

            commandEdit.Parameters.AddWithValue("@id", insert.id);
            commandEdit.Parameters.AddWithValue("@Task", insert.NameOfTask);

            commandEdit.ExecuteNonQuery();

            connectionWithTask.Close();
        }

        internal static void DeleteCompleteTasksDBSqlLite(InsertTask insert)
        {
            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"DELETE FROM DBTASK 
                          WHERE [Conclusion Percent] = 100  ";
                cmd.ExecuteNonQuery();
            }
        }

        internal static void DeleteListDBSqlLite(InsertTask insert)
        {
            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"DELETE FROM DBTASK 
                                           ";
                cmd.ExecuteNonQuery();
                ScreenTask.screenTask();
            }
        }

        internal static void EditConclusionDateDBSqlServer(InsertTask insert)
        {
            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithTask = new SqlConnection();
            connectionWithTask.ConnectionString = AdressDBtask;

            connectionWithTask.Open();

            SqlCommand commandEdit = new SqlCommand();
            commandEdit.Connection = connectionWithTask;

            string sqlEdit =
               @"UPDATE DBTASK
                 SET
                 [Conclusion Date] = @Conclusion Date
                 WHERE 
                   [ID] = @id";

            commandEdit.CommandText = sqlEdit;

            commandEdit.Parameters.AddWithValue("@id", insert.id);
            commandEdit.Parameters.AddWithValue("@Conclusion Date", insert.ConclusionDate);

            commandEdit.ExecuteNonQuery();

            connectionWithTask.Close();
        }

        internal static void ViewDBSqlServer(InsertTask insert)
        {
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
                    Console.WriteLine($"| ID: {id}  |TASK: {insert.NameOfTask} | CREATION DATE: {CreationDate.ToShortDateString()} | CONCLUSION DATE: {insert.ConclusionDate.ToShortDateString()} | IMPORTANCE LEVEL: {insert.ImportanceLevel} | CONCLUSION PERCENT: {ConclusionPercent}% |");
                }
            }
            connectionWithTask.Close();
            Console.ResetColor();
        }

        internal static void ViewDBSqlLite(InsertTask insert)
        {
            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"SELECT * FROM DBTASK 
                                               ";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = reader["Id"].ToString();
                        insert.NameOfTask = reader["Task"].ToString();
                        CreationDate = (DateTime)reader["Creation Date"];
                        insert.ConclusionDate = (DateTime)reader["Conclusion Date"];
                        insert.ImportanceLevel = reader["Importance Level"].ToString();
                        ConclusionPercent = (int)reader["Conclusion Percent"];
                        Console.WriteLine($"| ID: {id}  |TASK: {insert.NameOfTask} | CREATION DATE: {CreationDate.ToShortDateString()} | CONCLUSION DATE: {insert.ConclusionDate.ToShortDateString()} | IMPORTANCE LEVEL: {insert.ImportanceLevel} | CONCLUSION PERCENT: {ConclusionPercent}% |");
                    }
                }


            }
        }

        internal static void EditConclusionPercentDBSqlServer(InsertTask insert)
        {
            string AdressDBtask = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithTask = new SqlConnection();
            connectionWithTask.ConnectionString = AdressDBtask;

            connectionWithTask.Open();

            SqlCommand commandEdit = new SqlCommand();
            commandEdit.Connection = connectionWithTask;

            string sqlEdit =
               @"UPDATE DBTASK
                 SET
                 [Conclusion Percent] = @Conclusion Percent
                 WHERE 
                   [ID] = @id";

            commandEdit.CommandText = sqlEdit;

            commandEdit.Parameters.AddWithValue("@id", insert.id);
            commandEdit.Parameters.AddWithValue("@CConclusion Percent", insert.ConclusionPercent);

            commandEdit.ExecuteNonQuery();

            connectionWithTask.Close();
        }

        internal static void EditTaskDBSqlLite(InsertTask insert)
        {
            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"UPDATE DBTASK 
                                         SET [Task] = @Task
                                         WHERE [ID] = @id";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Task", insert.NameOfTask);
                cmd.ExecuteNonQuery();
            }
        }

        internal static void EditConclusionDateDBSqlLite(InsertTask insert)
        {
            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"UPDATE DBTASK 
                                         SET [Conclusion Date] = @Conclusion Date
                                         WHERE [ID] = @id";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Conclusion Date", insert.ConclusionDate);
                cmd.ExecuteNonQuery();
            }
        }

        internal static void EditConclusionPercentDBSqlLite(InsertTask insert)
        {
            SqLiteGet.DbConnection();

            using (var cmd = SqLiteGet.DbConnection().CreateCommand())
            {
                cmd.CommandText = @"UPDATE DBTASK 
                                         SET [Conclusion Percent] = @Conclusion Percent
                                         WHERE [ID] = @id";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Conclusion Percent", insert.ConclusionPercent);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

