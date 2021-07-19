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
    public partial class FormUpdateCompromises : Form
    {
        public FormUpdateCompromises()
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
                string query = "SELECT * FROM DBCOMPROMISE";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);

                dataGridView3.DataSource = dt;
            }
            txtUpdatedCompromise.Visible = false;
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
        public string Endhour { get; private set; }
        public string Starthour { get; private set; }
        public string CompromiseDate { get; private set; }
        public string Spot { get; private set; }
        public string Subject { get; private set; }

        List<String> GetOptions = new List<string>();

        private void btnUpdateBackScreenCompromise_Click(object sender, EventArgs e)
        {
            FormScreenCompromise screenCompromise = new FormScreenCompromise();
            screenCompromise.Visible = true;
            this.Close();
        }

        private void FormUpdateCompromises_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBTarefasDataSet1.DBCompromise' table. You can move, or remove it, as needed.
            this.dBCompromiseTableAdapter1.Fill(this.dBTarefasDataSet1.DBCompromise);
            // TODO: This line of code loads data into the 'dBTarefasDataSet.DBCompromise' table. You can move, or remove it, as needed.
            this.dBCompromiseTableAdapter.Fill(this.dBTarefasDataSet.DBCompromise);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Option = "SUBJECT";
            GetOptions.Add(Option);
            txtId.Enabled = true;
            txtNewUpdate.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Option = "SPOT";
            GetOptions.Add(Option);
            txtId.Enabled = true;
            txtNewUpdate.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Option = "COMPROMISE DATE";
            GetOptions.Add(Option);
            txtId.Enabled = true;
            txtNewUpdate.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Option = "START HOUR";
            GetOptions.Add(Option);
            txtId.Enabled = true;
            txtNewUpdate.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Option = "END HOUR";
            GetOptions.Add(Option);
            txtId.Enabled = true;
            txtNewUpdate.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (var item in GetOptions)
            {
                if (item == "SUBJECT")
                {
                    if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
                    {
                        DBAdd = @"UPDATE DBCOMPROMISE
                                SET
                                [Subject] = @Subject
                                WHERE 
                                [ID] = @id";


                        Sql = new SqlConnection(Adress);
                        Sql.Open();
                        SqlCommand command = new SqlCommand(DBAdd, Sql);
                        command.Parameters.AddWithValue("@id", SqlDbType.Text).Value = txtId.Text;
                        command.Parameters.AddWithValue("@Subject", SqlDbType.Text).Value = txtNewUpdate.Text;
                        command.ExecuteNonQuery();
                        Sql.Close();
                    }
                    if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
                    {
                        ID = txtId.Text;
                        Subject = txtNewUpdate.Text;

                        using (var cmd = DbConnection().CreateCommand())
                        {
                            cmd.CommandText = @"UPDATE DBCOMPROMISE
                                SET
                                [Subject] = @Subject
                                WHERE 
                                [ID] = @id";

                            cmd.Parameters.AddWithValue("@Id", ID);
                            cmd.Parameters.AddWithValue("@Subject", Subject);

                            Object id = cmd.ExecuteScalar();
                            object Id = Convert.ToInt32(id);
                        }
                    }
                }

                if (item == "SPOT")
                {
                    if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
                    {
                        DBAdd = @"UPDATE DBCOMPROMISE
                                SET
                                [Spot] = @Spot
                                WHERE 
                                [ID] = @id";


                        Sql = new SqlConnection(Adress);
                        Sql.Open();
                        SqlCommand command = new SqlCommand(DBAdd, Sql);
                        command.Parameters.AddWithValue("@id", SqlDbType.Text).Value = txtId.Text;
                        command.Parameters.AddWithValue("@Spot", SqlDbType.Text).Value = txtNewUpdate.Text;
                        command.ExecuteNonQuery();
                        Sql.Close();
                    }
                    if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
                    {
                        ID = txtId.Text;
                        Spot = txtNewUpdate.Text;

                        using (var cmd = DbConnection().CreateCommand())
                        {
                            cmd.CommandText = @"UPDATE DBCOMPROMISE
                                SET
                                [Spot] = @Spot
                                WHERE 
                                [ID] = @id";

                            cmd.Parameters.AddWithValue("@Id", ID);
                            cmd.Parameters.AddWithValue("@Spot", Spot);

                            Object id = cmd.ExecuteScalar();
                            object Id = Convert.ToInt32(id);
                        }
                    }
                }

                if (item == "COMPROMISE DATE")
                {
                    if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
                    {
                        DBAdd = @"UPDATE DBCOMPROMISE
                                SET
                                [Compromise Date] = @CompromiseDate
                                WHERE 
                                [ID] = @id";


                        Sql = new SqlConnection(Adress);
                        Sql.Open();
                        SqlCommand command = new SqlCommand(DBAdd, Sql);
                        command.Parameters.AddWithValue("@id", SqlDbType.Text).Value = txtId.Text;
                        command.Parameters.AddWithValue("@CompromiseDate", SqlDbType.Text).Value = txtNewUpdate.Text;
                        command.ExecuteNonQuery();
                        Sql.Close();
                    }
                    if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
                    {
                        ID = txtId.Text;
                        CompromiseDate = txtNewUpdate.Text;

                        using (var cmd = DbConnection().CreateCommand())
                        {
                            cmd.CommandText = @"UPDATE DBCOMPROMISE
                                SET
                                [Compromise Date] = @CompromiseDate
                                WHERE 
                                [ID] = @id";

                            cmd.Parameters.AddWithValue("@Id", ID);
                            cmd.Parameters.AddWithValue("@CompromiseDate", CompromiseDate);

                            Object id = cmd.ExecuteScalar();
                            object Id = Convert.ToInt32(id);
                        }
                    }
                }

                if (item == "START HOUR")
                {
                    if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
                    {
                        DBAdd = @"UPDATE DBCOMPROMISE
                                SET
                                [Start hour] = @Starthour
                                WHERE 
                                [ID] = @id";


                        Sql = new SqlConnection(Adress);
                        Sql.Open();
                        SqlCommand command = new SqlCommand(DBAdd, Sql);
                        command.Parameters.AddWithValue("@id", SqlDbType.Text).Value = txtId.Text;
                        command.Parameters.AddWithValue("@Starthour", SqlDbType.Text).Value = txtNewUpdate.Text;
                        command.ExecuteNonQuery();
                        Sql.Close();
                    }
                    if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
                    {
                        ID = txtId.Text;
                        Starthour = txtNewUpdate.Text;

                        using (var cmd = DbConnection().CreateCommand())
                        {
                            cmd.CommandText = @"UPDATE DBCOMPROMISE
                                SET
                                [Start hour] = @Starthour
                                WHERE 
                                [ID] = @id";

                            cmd.Parameters.AddWithValue("@Id", ID);
                            cmd.Parameters.AddWithValue("@Starthour", Starthour);

                            Object id = cmd.ExecuteScalar();
                            object Id = Convert.ToInt32(id);
                        }
                    }
                }

                if (item == "END HOUR")
                {
                    if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
                    {
                        DBAdd = @"UPDATE DBCOMPROMISE
                                SET
                                [End hour] = @Endhour
                                WHERE 
                                [ID] = @id";


                        Sql = new SqlConnection(Adress);
                        Sql.Open();
                        SqlCommand command = new SqlCommand(DBAdd, Sql);
                        command.Parameters.AddWithValue("@id", SqlDbType.Text).Value = txtId.Text;
                        command.Parameters.AddWithValue("@Endhour", SqlDbType.Text).Value = txtNewUpdate.Text;
                        command.ExecuteNonQuery();
                        Sql.Close();
                    }
                    if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
                    {
                        ID = txtId.Text;
                        Endhour = txtNewUpdate.Text;

                        using (var cmd = DbConnection().CreateCommand())
                        {
                            cmd.CommandText = @"UPDATE DBCOMPROMISE
                                SET
                                [End hour] = @Endhour
                                WHERE 
                                [ID] = @id";

                            cmd.Parameters.AddWithValue("@Id", ID);
                            cmd.Parameters.AddWithValue("@Endhour", Endhour);

                            Object id = cmd.ExecuteScalar();
                            object Id = Convert.ToInt32(id);
                        }
                    }
                }

                txtUpdatedCompromise.Visible = true;
            }
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
                
                txtUpdatedCompromise.Visible = false;
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.TextLength == 0)
            {
                btnUpdate.Enabled = false;
                
                txtUpdatedCompromise.Visible = false;
            }
        }
    }
}
