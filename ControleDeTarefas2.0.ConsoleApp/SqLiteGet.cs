using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeTarefas2._0.ConsoleApp
{
    class SqLiteGet
    {
        public static SQLiteConnection sqliteConnection;

        public static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection(@"data source = C:\Users\lucas\source\repos\NewControlTask.ConsoleApp\DataBase.db");
            sqliteConnection.Open();
            return sqliteConnection;
        }

        public static void Add()
        {


            using (var cmd = DbConnection().CreateCommand())
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


            }
        }
    }
}
