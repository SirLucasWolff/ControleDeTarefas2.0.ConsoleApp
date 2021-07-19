using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormUpdateTasks : Form
    {
        public FormUpdateTasks()
        {
            InitializeComponent();
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
            {
                dataGridView4.Visible = false;
            }
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
            {
                dataGridView2.Visible = false;
                SQLiteConnection con = new SQLiteConnection(@"data source=C:\Users\lucas\source\repos\ControleDeTarefas2.0.ConsoleApp\ControleDeTarefas2.0.ConsoleApp\bin\DataBase\bancoDedados.db");
                con.Open();
                string query = "SELECT * FROM DBTASK";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);

                dataGridView4.DataSource = dt;
            }
            txtUpdated.Visible = false;
            btnUpdate.Enabled = false;
            
        }

        public static SQLiteConnection sqliteConnection;

        public static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection(@"data source=C:\Users\lucas\source\repos\ControleDeTarefas2.0.ConsoleApp\ControleDeTarefas2.0.ConsoleApp\bin\DataBase\bancoDedados.db");
            sqliteConnection.Open();
            return sqliteConnection;
        }

        SqlConnection Sql = null;
        private string Adress = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";
        private string DBAdd = string.Empty;
        private string keyUpdatePercent;
        List<String> GetKey = new List<string>();
        List<Int32> GetUpdate = new List<int>();
        public object ImportanceLevel { get; private set; }
        public static string Option { get; set; }
        public string KeyUpdateTask { get; set; }
        public string KeyUpdatePercent { get; private set; }
        public string GetValuue { get; private set; }
        public int UpdatePercent { get; private set; }
        public string ID { get; private set; }
        public DateTime ConclusionDate { get; private set; }
        public string TaskName { get; private set; }

        private void btnUpdateBackScreenTask_Click(object sender, EventArgs e)
        {
            FormScreenTasks form = new FormScreenTasks();
            form.Visible = true;
            this.Close();
        }

        private void FormUpdateTasks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBTarefasDataSet.DBTask' table. You can move, or remove it, as needed.
            this.dBTaskTableAdapter.Fill(this.dBTarefasDataSet.DBTask);

        }

        public static void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button7_Click(object sender, EventArgs e)
        {


            if (KeyUpdateTask == "UPDATETASK")
            {
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
                {
                    DBAdd = @"UPDATE DBTASK
                                   SET
                                   [Task] = @Task
                                   WHERE 
                                   [ID] = @id";


                    Sql = new SqlConnection(Adress);
                    Sql.Open();
                    SqlCommand command = new SqlCommand(DBAdd, Sql);
                    command.Parameters.AddWithValue("@id", SqlDbType.Text).Value = textBox1.Text;
                    command.Parameters.AddWithValue("@Task", SqlDbType.Text).Value = textBox2.Text;
                    command.ExecuteNonQuery();
                    Sql.Close();
                }
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
                {
                    ID = textBox1.Text;
                    TaskName = textBox2.Text;

                    using (var cmd = DbConnection().CreateCommand())
                    {
                        cmd.CommandText = @"UPDATE DBTASK
                                   SET
                                   [Task] = @Task
                                   WHERE 
                                   [ID] = @id";

                        cmd.Parameters.AddWithValue("@Id", ID);
                        cmd.Parameters.AddWithValue("@Task", TaskName);

                        Object id = cmd.ExecuteScalar();
                        object Id = Convert.ToInt32(id);
                    }
                }

                KeyUpdateTask = "";
            }

            if (keyUpdatePercent == "UPDATEPERCENT")
            {
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
                {
                    ConclusionDate = DateTime.Now;

                    DBAdd = @"UPDATE DBTASK
                                   SET
                                   [Conclusion Percent] = @ConclusionPercent,
                                   [Conclusion Date] = @ConclusionDate
                                   WHERE 
                                   [ID] = @id";


                    Sql = new SqlConnection(Adress);
                    Sql.Open();
                    SqlCommand command = new SqlCommand(DBAdd, Sql);
                    command.Parameters.AddWithValue("@id", SqlDbType.Text).Value = textBox1.Text;
                    command.Parameters.AddWithValue("@ConclusionPercent", UpdatePercent);
                    command.Parameters.AddWithValue("@ConclusionDate", ConclusionDate);
                    command.ExecuteNonQuery();
                    Sql.Close();
                }
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
                {
                    ID = textBox1.Text;
                    ConclusionDate = DateTime.Now;


                    using (var cmd = DbConnection().CreateCommand())
                    {
                        cmd.CommandText = @"UPDATE DBTASK
                                   SET
                                   [Conclusion Percent] = @ConclusionPercent,
                                   [Conclusion Date] = @ConclusionDate
                                   WHERE 
                                   [ID] = @id";

                        cmd.Parameters.AddWithValue("@id", ID);
                        cmd.Parameters.AddWithValue("@ConclusionPercent", UpdatePercent);
                        cmd.Parameters.AddWithValue("@ConclusionDate", ConclusionDate);

                        Object id = cmd.ExecuteScalar();
                        object Id = Convert.ToInt32(id);
                    }
                }
                keyUpdatePercent = "";
            }

            if (ImportanceLevel == "LOW")
            {
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
                {
                    DBAdd = @"UPDATE DBTASK
                                    SET
                                    [Importance Level] = @ImportanceLevel
                                    WHERE 
                                   [ID] = @id";


                    Sql = new SqlConnection(Adress);
                    Sql.Open();
                    SqlCommand command = new SqlCommand(DBAdd, Sql);
                    command.Parameters.AddWithValue("@id", SqlDbType.Text).Value = textBox1.Text;
                    command.Parameters.AddWithValue("@ImportanceLevel", ImportanceLevel);
                    command.ExecuteNonQuery();
                    Sql.Close();
                }
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
                {
                    ID = textBox1.Text;

                    using (var cmd = DbConnection().CreateCommand())
                    {
                        cmd.CommandText = @"UPDATE DBTASK
                                    SET
                                    [Importance Level] = @ImportanceLevel
                                    WHERE 
                                   [ID] = @id";

                        cmd.Parameters.AddWithValue("@id", ID);
                        cmd.Parameters.AddWithValue("@ImportanceLevel", ImportanceLevel);

                        Object id = cmd.ExecuteScalar();
                        object Id = Convert.ToInt32(id);
                    }
                }
                ImportanceLevel = "";
            }

            if (ImportanceLevel == "NORMAL")
            {
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
                {
                    DBAdd = @"UPDATE DBTASK
                                      SET
                                      [Importance Level] = @ImportanceLevel
                                      WHERE 
                                      [ID] = @id";


                    Sql = new SqlConnection(Adress);
                    Sql.Open();
                    SqlCommand command = new SqlCommand(DBAdd, Sql);
                    command.Parameters.AddWithValue("@id", SqlDbType.Text).Value = textBox1.Text;
                    command.Parameters.AddWithValue("@ImportanceLevel", ImportanceLevel);
                    command.ExecuteNonQuery();
                    Sql.Close();
                }
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
                {
                    ID = textBox1.Text;

                    using (var cmd = DbConnection().CreateCommand())
                    {
                        cmd.CommandText = @"UPDATE DBTASK
                                    SET
                                    [Importance Level] = @ImportanceLevel
                                    WHERE 
                                   [ID] = @id";

                        cmd.Parameters.AddWithValue("@id", ID);
                        cmd.Parameters.AddWithValue("@ImportanceLevel", ImportanceLevel);

                        Object id = cmd.ExecuteScalar();
                        object Id = Convert.ToInt32(id);
                    }
                }

                ImportanceLevel = "";
            }

            if (ImportanceLevel == "HIGH")
            {
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
                {
                    DBAdd = @"UPDATE DBTASK
                                     SET
                                     [Importance Level] = @ImportanceLevel
                                     WHERE 
                                     [ID] = @id";


                    Sql = new SqlConnection(Adress);
                    Sql.Open();
                    SqlCommand command = new SqlCommand(DBAdd, Sql);
                    command.Parameters.AddWithValue("@id", SqlDbType.Text).Value = textBox1.Text;
                    command.Parameters.AddWithValue("@ImportanceLevel", ImportanceLevel);
                    command.ExecuteNonQuery();
                    Sql.Close();
                }
                if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
                {
                    ID = textBox1.Text;

                    using (var cmd = DbConnection().CreateCommand())
                    {
                        cmd.CommandText = @"UPDATE DBTASK
                                    SET
                                    [Importance Level] = @ImportanceLevel
                                    WHERE 
                                   [ID] = @id";

                        cmd.Parameters.AddWithValue("@id", ID);
                        cmd.Parameters.AddWithValue("@ImportanceLevel", ImportanceLevel);

                        Object id = cmd.ExecuteScalar();
                        object Id = Convert.ToInt32(id);
                    }
                }
                ImportanceLevel = "";
            }

            UpdateView();
            txtUpdated.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ImportanceLevel = "LOW";
            GetKey.Add((string)ImportanceLevel);
            if (textBox1.TextLength>0)
            {
                btnUpdate.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ImportanceLevel = "NORMAL";
            GetKey.Add((string)ImportanceLevel);
            if (textBox1.TextLength > 1)
            {
                btnUpdate.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ImportanceLevel = "HIGH";
            GetKey.Add((string)ImportanceLevel);
            if (textBox1.TextLength > 1)
            {
                btnUpdate.Enabled = true;
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            KeyUpdateTask = "UPDATETASK";
            GetKey.Add(KeyUpdateTask);
            if (textBox1.TextLength > 0)
            {
                if (textBox2.TextLength>1)
                {
                    btnUpdate.Enabled = true;
                }
               
            }
            if (textBox2.TextLength == 0)
            {
                btnUpdate.Enabled = false;
                txtUpdated.Visible = false;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            keyUpdatePercent = "UPDATEPERCENT";
            GetKey.Add(keyUpdatePercent);
            GetValuue = trackBar1.Value.ToString();
            GetUpdate.Add(trackBar1.Value);
            if (textBox1.TextLength > 1)
            {
                btnUpdate.Enabled = true;

            }
            foreach (var item in GetUpdate)
            {
                if (item == 1)
                {
                    UpdatePercent = 10; 
                }
                if (item == 2)
                {
                    UpdatePercent = 20;
                }
                if (item == 3)
                {
                    UpdatePercent = 30;
                }
                if (item == 4)
                {
                    UpdatePercent = 40;
                }
                if (item == 5)
                {
                    UpdatePercent = 50;
                }
                if (item == 6)
                {
                    UpdatePercent = 60;
                }
                if (item == 7)
                {
                    UpdatePercent = 70;
                }
                if (item == 8)
                {
                    UpdatePercent = 80;
                }
                if (item == 9)
                {
                    UpdatePercent = 90;
                }
                if (item == 10)
                {
                    UpdatePercent = 100;
                }
            }
        }

        private void dataGridView2_MouseHover(object sender, EventArgs e)
        {
            txtUpdated.Visible = false;
            btnUpdate.Enabled = false;
        }

        private void dataGridView4_SortStringChanged(object sender, EventArgs e)
        {
            this.dBTaskBindingSource.Sort = this.dataGridView4.SortString;
        }

        private void dataGridView4_FilterStringChanged(object sender, EventArgs e)
        {
            this.dBTaskBindingSource1.Filter = this.dataGridView4.FilterString;
        }

        private void UpdateView()
        {
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False");
                con.Open();
                string query = "SELECT * FROM DBTASK";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                dataGridView2.DataSource = dt;

            }
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
            {

                SQLiteConnection con = new SQLiteConnection(@"data source=C:\Users\lucas\source\repos\ControleDeTarefas2.0.ConsoleApp\ControleDeTarefas2.0.ConsoleApp\bin\DataBase\bancoDedados.db");
                con.Open();
                string query = "SELECT * FROM DBTASK";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);

                dataGridView4.DataSource = dt;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0)
            {
                btnUpdate.Enabled = false;
                txtUpdated.Visible = false;
            }
        }
    }
}
