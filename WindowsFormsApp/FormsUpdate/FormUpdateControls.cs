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
    public partial class FormUpdateControls : Form
    {
        public FormUpdateControls()
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
                string query = "SELECT * FROM DBCONTACTS";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);

                dataGridView3.DataSource = dt;
            }
            txtUpdatedContact.Visible = false;
            btnUpdate.Enabled = false;
            txtId.Enabled = false;
            txtNewUpdate.Enabled = false;
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
        public string Option { get; private set; }
        public string ID { get; private set; }
        public string Position { get; private set; }
        public string Firm { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }

        List<String> GetOptions = new List<string>();
        private void btnUpdateBackScreenContact_Click(object sender, EventArgs e)
        {
            FormScreenContact formScreen = new FormScreenContact();
            formScreen.Visible = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtNewUpdate.Enabled = true;
            Option = "NAME";
            GetOptions.Add(Option);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtNewUpdate.Enabled = true;
            Option = "EMAIL";
            GetOptions.Add(Option);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtNewUpdate.Enabled = true;
            Option = "PHONE";
            GetOptions.Add(Option);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtNewUpdate.Enabled = true;
            Option = "FIRM";
            GetOptions.Add(Option);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtNewUpdate.Enabled = true;
            Option = "POSITION";
            GetOptions.Add(Option);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
                if (Option == "NAME")
                {
                    if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
                    {
                        DBAdd = @"UPDATE DBCONTACTS
                                      SET
                                      [Name] = @Name
                                      WHERE 
                                      [ID] = @id";


                        Sql = new SqlConnection(Adress);
                        Sql.Open();
                        SqlCommand command = new SqlCommand(DBAdd, Sql);
                        command.Parameters.AddWithValue("@id", SqlDbType.Text).Value = txtId.Text;
                        command.Parameters.AddWithValue("@Name", SqlDbType.Text).Value = txtNewUpdate.Text;
                        command.ExecuteNonQuery();
                        Sql.Close();
                    }
                    if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
                    {
                        ID = txtId.Text;
                        Name = txtNewUpdate.Text;

                        using (var cmd = DbConnection().CreateCommand())
                        {
                            cmd.CommandText = @"UPDATE DBCONTACTS
                                      SET
                                      [Name] = @Name
                                      WHERE 
                                      [ID] = @id";

                            cmd.Parameters.AddWithValue("@id", ID);
                            cmd.Parameters.AddWithValue("@Name", Name);

                            Object id = cmd.ExecuteScalar();
                            object Id = Convert.ToInt32(id);
                        }
                    }

                   
                }

                if (Option == "EMAIL")
                {
                    if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
                    {
                        DBAdd = @"UPDATE DBCONTACTS
                                SET
                                [Email] = @Email
                                WHERE 
                                [ID] = @id";


                        Sql = new SqlConnection(Adress);
                        Sql.Open();
                        SqlCommand command = new SqlCommand(DBAdd, Sql);
                        command.Parameters.AddWithValue("@id", SqlDbType.Text).Value = txtId.Text;
                        command.Parameters.AddWithValue("@Email", SqlDbType.Text).Value = txtNewUpdate.Text;
                        command.ExecuteNonQuery();
                        Sql.Close();
                    }
                    if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
                    {
                        ID = txtId.Text;
                        Email = txtNewUpdate.Text;

                        using (var cmd = DbConnection().CreateCommand())
                        {
                            cmd.CommandText = @"UPDATE DBCONTACTS
                                      SET
                                      [Email] = @Email
                                      WHERE 
                                      [ID] = @id";

                            cmd.Parameters.AddWithValue("@id", ID);
                            cmd.Parameters.AddWithValue("@Email", Email);

                            Object id = cmd.ExecuteScalar();
                            object Id = Convert.ToInt32(id);
                        }
                    }
                }

                if (Option == "PHONE")
                {
                    if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
                    {
                        DBAdd = @"UPDATE DBCONTACTS
                                SET
                                [Phone] = @Phone
                                WHERE 
                                [ID] = @id";


                        Sql = new SqlConnection(Adress);
                        Sql.Open();
                        SqlCommand command = new SqlCommand(DBAdd, Sql);
                        command.Parameters.AddWithValue("@id", SqlDbType.Text).Value = txtId.Text;
                        command.Parameters.AddWithValue("@Phone", SqlDbType.Text).Value = txtNewUpdate.Text;
                        command.ExecuteNonQuery();
                        Sql.Close();
                    }
                    if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
                    {
                        ID = txtId.Text;
                        Phone = txtNewUpdate.Text;

                        using (var cmd = DbConnection().CreateCommand())
                        {
                            cmd.CommandText = @"UPDATE DBCONTACTS
                                      SET
                                      [Phone] = @Phone
                                      WHERE 
                                      [ID] = @id";

                            cmd.Parameters.AddWithValue("@id", ID);
                            cmd.Parameters.AddWithValue("@Phone", Phone);

                            Object id = cmd.ExecuteScalar();
                            object Id = Convert.ToInt32(id);
                        }
                    }
                }

                if (Option == "FIRM")
                {
                    if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
                    {
                        DBAdd = @"UPDATE DBCONTACTS
                                SET
                                [Firm] = @Firm
                                WHERE 
                                [ID] = @id";


                        Sql = new SqlConnection(Adress);
                        Sql.Open();
                        SqlCommand command = new SqlCommand(DBAdd, Sql);
                        command.Parameters.AddWithValue("@id", SqlDbType.Text).Value = txtId.Text;
                        command.Parameters.AddWithValue("@Firm", SqlDbType.Text).Value = txtNewUpdate.Text;
                        command.ExecuteNonQuery();
                        Sql.Close();
                    }
                    if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
                    {
                        ID = txtId.Text;
                        Firm = txtNewUpdate.Text;

                        using (var cmd = DbConnection().CreateCommand())
                        {
                            cmd.CommandText = @"UPDATE DBCONTACTS
                                      SET
                                      [Firm] = @Firm
                                      WHERE 
                                      [ID] = @id";

                            cmd.Parameters.AddWithValue("@id", ID);
                            cmd.Parameters.AddWithValue("@Firm", Firm);

                            Object id = cmd.ExecuteScalar();
                            object Id = Convert.ToInt32(id);
                        }
                    }
                }

                if (Option == "POSITION")
                {
                    if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
                    {
                        DBAdd = @"UPDATE DBCONTACTS
                                SET
                                [Position] = @Position
                                WHERE 
                                [ID] = @id";


                        Sql = new SqlConnection(Adress);
                        Sql.Open();
                        SqlCommand command = new SqlCommand(DBAdd, Sql);
                        command.Parameters.AddWithValue("@id", SqlDbType.Text).Value = txtId.Text;
                        command.Parameters.AddWithValue("@Position", SqlDbType.Text).Value = txtNewUpdate.Text;
                        command.ExecuteNonQuery();
                        Sql.Close();
                    }
                    if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
                    {
                        ID = txtId.Text;
                        Position = txtNewUpdate.Text;

                        using (var cmd = DbConnection().CreateCommand())
                        {
                            cmd.CommandText = @"UPDATE DBCONTACTS
                                      SET
                                      [Position] = @Position
                                      WHERE 
                                      [ID] = @id";

                            cmd.Parameters.AddWithValue("@id", ID);
                            cmd.Parameters.AddWithValue("@Position", Position);

                            Object id = cmd.ExecuteScalar();
                            object Id = Convert.ToInt32(id);
                        }
                    }
                }
            
            UpdateView();
            txtUpdatedContact.Visible = true;
        }

        private void FormUpdateControls_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBTarefasDataSet.DBContacts' table. You can move, or remove it, as needed.
            this.dBContactsTableAdapter.Fill(this.dBTarefasDataSet.DBContacts);

        }

        private void txtNewUpdate_TextChanged(object sender, EventArgs e)
        {
            if (txtId.TextLength>0)
            {
                if (txtNewUpdate.TextLength>0)
                {
                    btnUpdate.Enabled = true;
                }
            }

            if (txtNewUpdate.TextLength == 0)
            {
                btnUpdate.Enabled = false;
                txtUpdatedContact.Visible = false;
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtNewUpdate.TextLength>1)
            {
                if (txtId.TextLength>1)
                {
                    btnUpdate.Enabled = true;
                    txtUpdatedContact.Visible = false;
                }
            }

            if (txtId.TextLength == 0)
            {
                btnUpdate.Enabled = false;
                txtUpdatedContact.Visible = false;
            }
        }

        public static void IntNumber(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtNewUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Option == "PHONE")
            {
                IntNumber(e);
            }
            
        }

        private void UpdateView()
        {
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False");
                con.Open();
                string query = "SELECT * FROM DBCONTACTS";
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
                string query = "SELECT * FROM DBCONTACTS";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);

                dataGridView3.DataSource = dt;
            }
        }
    }
}
