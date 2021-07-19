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
    public partial class FormDeleteTasks : Form
    {
        public FormDeleteTasks()
        {
            InitializeComponent();
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
            {
                dataGridView3.Visible = false;
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

                dataGridView3.DataSource = dt;

            }
            txtDeleted.Visible = false;
            btnWithID.Enabled = false;
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

        public string ID { get; private set; }

        private void btnDeleteBackScreenTask_Click(object sender, EventArgs e)
        {
            FormScreenTasks screenTasks = new FormScreenTasks();
            screenTasks.Visible = true;
            this.Close();
        }

        private void btnDeleteTaskWithID_Click(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
            {
                DBAdd = @"DELETE  FROM DBTASK 
                      WHERE [ID] = @Id ";

                Sql = new SqlConnection(Adress);
                Sql.Open();
                SqlCommand command = new SqlCommand(DBAdd, Sql);
                command.Parameters.AddWithValue("@Id", SqlDbType.Text).Value = textBox1.Text;

                command.ExecuteNonQuery();
                Sql.Close();
            }
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
            {
                ID = textBox1.Text;

                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = @"DELETE  FROM DBTASK 
                      WHERE [ID] = @Id ";

                    cmd.Parameters.AddWithValue("@Id", ID);

                    Object id = cmd.ExecuteScalar();
                    object Id = Convert.ToInt32(id);
                }
            }

                txtDeleted.Visible = true;
            UpdateView();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
            {
                DBAdd = @"DELETE FROM DBTASK 
                            ";

                Sql = new SqlConnection(Adress);
                Sql.Open();
                SqlCommand command = new SqlCommand(DBAdd, Sql);


                command.ExecuteNonQuery();
                Sql.Close();
            }
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = @"DELETE  FROM DBTASK 
                                               ";

                    Object id = cmd.ExecuteScalar();
                    object Id = Convert.ToInt32(id);
                }
            }

            UpdateView();
                txtDeleted.Visible = true;
        }

        private void FormDeleteTasks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBTarefasDataSet.DBTask' table. You can move, or remove it, as needed.
            this.dBTaskTableAdapter.Fill(this.dBTarefasDataSet.DBTask);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = Visible = true;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength>1)
            {
                btnWithID.Enabled = true;
            }
            if (textBox1.TextLength == 0)
            {
                btnWithID.Enabled = false;
                txtDeleted.Visible = false;
            }
        }

        private void btnDeleteAll_MouseHover(object sender, EventArgs e)
        {
            txtDeleted.Visible = false;
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

                dataGridView3.DataSource = dt;
            }
        }
    }
}
