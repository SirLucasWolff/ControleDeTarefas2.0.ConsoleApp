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
    public partial class FormDeleteCompromises : Form
    {
        public FormDeleteCompromises()
        {
            InitializeComponent();
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
            {
                dataGridView3.Visible = false;
            }
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
            {
                dataGridView2.Visible = false;
                dataGridView3.Visible = true;
                SQLiteConnection con = new SQLiteConnection(@"data source=C:\Users\lucas\source\repos\ControleDeTarefas2.0.ConsoleApp\ControleDeTarefas2.0.ConsoleApp\bin\DataBase\bancoDedados.db");
                con.Open();
                string query = "SELECT * FROM DBCOMPROMISE";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);

                dataGridView3.DataSource = dt;
            }
            txtDeletedCompromise.Visible = false;
            btnWithId.Enabled = false;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteBackScreenCompromise_Click(object sender, EventArgs e)
        {
            FormScreenCompromise formScreen = new FormScreenCompromise();
            formScreen.Visible = true;
            this.Close();
        }

        private void FormDeleteCompromises_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBTarefasDataSet.DBCompromise' table. You can move, or remove it, as needed.
            this.dBCompromiseTableAdapter.Fill(this.dBTarefasDataSet.DBCompromise);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
            {
                DBAdd = @"DELETE  FROM DBCOMPROMISE 
                      WHERE [ID] = @id ";

                Sql = new SqlConnection(Adress);
                Sql.Open();
                SqlCommand command = new SqlCommand(DBAdd, Sql);
                command.Parameters.AddWithValue("@id", SqlDbType.Text).Value = txtId.Text;

                command.ExecuteNonQuery();
                Sql.Close();
            }
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
            {
                ID = txtId.Text;

                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = @"DELETE  FROM DBCOMPROMISE 
                      WHERE [ID] = @Id ";

                    cmd.Parameters.AddWithValue("@id", ID);

                    Object id = cmd.ExecuteScalar();
                    object Id = Convert.ToInt32(id);
                }
            }

            UpdateView();
            txtDeletedCompromise.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
            {
                DBAdd = @"DELETE FROM DBCOMPROMISE 
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
                    cmd.CommandText = @"DELETE  FROM DBCOMPROMISE 
                                                    ";

                    Object id = cmd.ExecuteScalar();
                    object Id = Convert.ToInt32(id);
                }
            }
            UpdateView();
            txtDeletedCompromise.Visible = true;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.TextLength>0)
            {
                btnWithId.Enabled = true;
            }

            if (txtId.TextLength == 0)
            {
                btnWithId.Enabled = false;
                txtDeletedCompromise.Visible = false;
            }
        }

        private void btnDeleteAll_MouseHover(object sender, EventArgs e)
        {
            txtDeletedCompromise.Visible = false;
        }

        private void UpdateView()
        {
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False");
                con.Open();
                string query = "SELECT * FROM DBCOMPROMISE";
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
                string query = "SELECT * FROM DBCOMPROMISE";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);

                dataGridView3.DataSource = dt;
            }
        }
    }
}
