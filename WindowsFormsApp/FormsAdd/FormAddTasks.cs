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
    public partial class FormAddTasks : Form
    {
        public FormAddTasks()
        {
            InitializeComponent();
            button1.Enabled = false;
            txtTaskAdded.Visible = false;
           
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
        
        public int ConclusionPercent { get; private set; }
        public string ImportanceLevel { get; private set; }
        public Button Option { get; private set; }
        public string NameOfTask { get; private set; }
        public DateTime CreationDate { get; private set; }
        public DateTime ConclusionDate { get; private set; }
        public string ImportanceLevelSqLite { get; private set; }
        public int Conclusion { get; private set; }
        public string TaskName { get; private set; }

        private string DBAdd = string.Empty;
 
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddBackScreenTask_Click(object sender, EventArgs e)
        {
            FormScreenTasks screenTasks = new FormScreenTasks();
            screenTasks.Visible = true;
            this.Close();
        }

        private void FormAddTasks_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAddTasks_Click(object sender, EventArgs e)
        {
            ConclusionPercent = 0;

            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
            {
                DBAdd = @"INSERT INTO DBTASK 
                (
                    [Task],
                    [Creation Date],   
                    [Importance Level],
                    [Conclusion Percent]
                )
                VALUES 
                (
                    @Task,
                    @CreationDate,
                    @ImportanceLevel,
                    @ConclusionPercent
                )";

                Sql = new SqlConnection(Adress);
                SqlCommand command = new SqlCommand(DBAdd, Sql);

                command.Parameters.AddWithValue("@Task", SqlDbType.Text).Value = textBox1.Text;
                command.Parameters.AddWithValue("@CreationDate", DateTime.Now);
                command.Parameters.AddWithValue("@ImportanceLevel", ImportanceLevel);
                command.Parameters.AddWithValue("@ConclusionPercent", ConclusionPercent);

                Sql.Open();
                command.ExecuteNonQuery();
                Sql.Close();

                txtTaskAdded.Visible = true;
            }
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
            {
                TaskName = textBox1.Text;

                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO DBTASK 
                    (
                    [Task],
                    [Creation Date],
                    [Importance Level],
                    [Conclusion Percent]
                    )
                    VALUES 
                    (
                    @Task,
                    @CreationDate,
                    @ImportanceLevel,
                    @ConclusionPercent
                    )";

                    cmd.Parameters.AddWithValue("@Task", TaskName);
                    cmd.Parameters.AddWithValue("@CreationDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@ImportanceLevel", ImportanceLevel);
                    cmd.Parameters.AddWithValue("@ConclusionPercent", ConclusionPercent);

                    
                    Object id = cmd.ExecuteScalar();
                    object Id = Convert.ToInt32(id);

                    txtTaskAdded.Visible = true;
                }
            }
        }

        public void textBoxAddTask_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 1)
            {
                if (ImportanceLevel == "LOW")
                {
                    button1.Enabled = true;
                }
                if (ImportanceLevel == "NORMAL")
                {
                    button1.Enabled = true;
                }
                if (ImportanceLevel == "HIGH")
                {
                    button1.Enabled = true;
                }
                
            }
            if (textBox1.TextLength == 0)
            {
                if (ImportanceLevel == "")
                {
                    button1.Enabled = false;
                }
                if (ImportanceLevel == "")
                {
                    button1.Enabled = false;
                }
                if (ImportanceLevel == "")
                {
                    button1.Enabled = false;
                }
            }

            if (textBox1.TextLength == 0)
            {
                txtTaskAdded.Visible = false;
                button1.Enabled = false;
            }
        }

        public void btnImportanceLevelLow_Click(object sender, EventArgs e)
        {
            ImportanceLevel = "LOW";
            if (textBox1.TextLength>1)
            {
                button1.Enabled = true;
            }
        }

        private void btnImportanceLevelNormal_Click(object sender, EventArgs e)
        {
            ImportanceLevel = "NORMAL";
            if (textBox1.TextLength > 1)
            {
                button1.Enabled = true;
            }
        }

        private void btnImportanceLevelHigh_Click(object sender, EventArgs e)
        {
            ImportanceLevel = "HIGH";
            if (textBox1.TextLength > 1)
            {
                button1.Enabled = true;
            }
        }

        public void HOVER(object sender, EventArgs e)
        {
           
        }

        private void HoverBtnNormal(object sender, EventArgs e)
        {
           
        }

        private void HoverBtnHigh(object sender, EventArgs e)
        {
           
        }
    }
}
