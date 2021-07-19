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
    public partial class FormAddCompromises : Form
    {
        public FormAddCompromises()
        {
            InitializeComponent();
            txtAddedCompromise.Visible = false;
            btnAdd.Enabled = false;
        }
        SqlConnection Sql = null;

        public static SQLiteConnection sqliteConnection;

        public static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection(@"data source=C:\Users\lucas\source\repos\ControleDeTarefas2.0.ConsoleApp\ControleDeTarefas2.0.ConsoleApp\bin\DataBase\bancoDedados.db");
            sqliteConnection.Open();
            return sqliteConnection;
        }


        private string Adress = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";
        private string DBAddCompromise = string.Empty;

        public string KindOfCompromise { get; private set; }
        public string Link { get; set; }
        public string Subject { get; private set; }
        public string Spot { get; private set; }
        public DateTime CompromiseDate { get; private set; }
        public string StarHour { get; private set; }
        public string EndHour { get; private set; }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void btnAddBackScreenCompromise_Click(object sender, EventArgs e)
        {
            FormScreenCompromise formScreenCompromise = new FormScreenCompromise();
            formScreenCompromise.Visible = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
            {
                DBAddCompromise = @"INSERT INTO DBCOMPROMISE 
                (
                 [Subject],
                 [Spot],
                 [Compromise Date],
                 [Start hour],
                 [End hour],
                 [Kind of compromise],
                 [Link]
                )
                VALUES 
                (
                 @Subject,
                 @Spot,
                 @CompromiseDate,
                 @Starthour,
                 @Endhour,
                 @Kindofcompromise,
                 @Link
                )";

                Sql = new SqlConnection(Adress);

                SqlCommand command = new SqlCommand(DBAddCompromise, Sql);

                command.Parameters.AddWithValue("@Subject", SqlDbType.Text).Value = txtSubject.Text;
                command.Parameters.AddWithValue("@Spot", SqlDbType.Text).Value = txtSpot.Text;
                command.Parameters.AddWithValue("@CompromiseDate", SqlDbType.DateTime).Value = maskedCompromiseDate.Value;
                command.Parameters.AddWithValue("@Starthour", SqlDbType.Text).Value = txtStartHour.Text;
                command.Parameters.AddWithValue("@Endhour", SqlDbType.Text).Value = txtEndHour.Text;
                command.Parameters.AddWithValue("@Kindofcompromise", KindOfCompromise);
                if (rbRemote.Checked)
                {
                    command.Parameters.AddWithValue("@Link", SqlDbType.Text).Value = txtLink.Text;
                }
                if (rbMeeting.Checked)
                {
                    Link = "";
                    command.Parameters.AddWithValue("@Link", Link);
                }

                Sql.Open();
                command.ExecuteNonQuery();
                Sql.Close();
            }
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
            {
                Subject = txtSubject.Text;
                Spot = txtSpot.Text;
                CompromiseDate = maskedCompromiseDate.Value;
                StarHour = txtStartHour.Text;
                EndHour = txtEndHour.Text;

                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO DBCOMPROMISE 
                    (
                    [Subject],
                    [Spot],
                    [Compromise Date],
                    [Start hour],
                    [End hour],
                    [Kind of compromise]
                    
                    )
                    VALUES 
                    (
                    @Subject,
                    @Spot,
                    @CompromiseDate,
                    @Starthour,
                    @Endhour,
                    @Kindofcompromise
                    
                    )";

                    cmd.Parameters.AddWithValue("@Subject", Subject);
                    cmd.Parameters.AddWithValue("@Spot", Spot);
                    cmd.Parameters.AddWithValue("@CompromiseDate", CompromiseDate);
                    cmd.Parameters.AddWithValue("@Starthour", StarHour);
                    cmd.Parameters.AddWithValue("@Endhour", EndHour);
                    cmd.Parameters.AddWithValue("@Kindofcompromise", KindOfCompromise);
                    
                    Object id = cmd.ExecuteScalar();
                    object Id = Convert.ToInt32(id);
                }
            }

                txtAddedCompromise.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            KindOfCompromise = "REMOTE";
            if (rbRemote.Checked)
            {
                txtLink.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            KindOfCompromise = "MEETING";
           if (rbMeeting.Checked)
            {
                txtLink.Enabled = false;
            }

            if (txtSubject.TextLength > 0)
            {
                if (txtSpot.TextLength > 0)
                {
                    if (maskedCompromiseDate.Value > DateTime.Now)
                    {
                        if (txtStartHour.TextLength > 0)
                        {
                            if (txtEndHour.TextLength > 0)
                            {
                                if (KindOfCompromise == "REMOTE")
                                {
                                    if (txtLink.TextLength > 0)
                                    {
                                        btnAdd.Enabled = true;
                                    }
                                }

                                if (rbMeeting.Checked)
                                {
                                    btnAdd.Enabled = true;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void txtLink_TextChanged(object sender, EventArgs e)
        {
            if (txtSubject.TextLength>0)
            {
                if (txtSpot.TextLength>0)
                {
                    if (maskedCompromiseDate.Value>DateTime.Now)
                    {
                        if (txtStartHour.TextLength>0)
                        {
                            if (txtEndHour.TextLength>0)
                            {
                                if (KindOfCompromise == "REMOTE")
                                {
                                    if (txtLink.TextLength>0)
                                    {
                                        btnAdd.Enabled = true;
                                    }
                                }

                                if (rbMeeting.Checked)
                                {
                                    btnAdd.Enabled = true;
                                }
                            }
                        }
                    }
                }
            }

            if (txtLink.TextLength == 0)
            {
                btnAdd.Enabled = false;
                txtAddedCompromise.Visible = false;
            }
        }



        private void txtSubject_TextChanged(object sender, EventArgs e)
        {
            if (txtSubject.TextLength == 0)
            {
                btnAdd.Enabled = false;
                txtAddedCompromise.Visible = false;
            }
        }

        private void txtSpot_TextChanged(object sender, EventArgs e)
        {
            if (txtSpot.TextLength == 0)
            {
                btnAdd.Enabled = false;
                txtAddedCompromise.Visible = false;
            }
        }

        private void maskedCompromiseDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (maskedCompromiseDate.Value == DateTime.Now)
            {
                btnAdd.Enabled = false;
                txtAddedCompromise.Visible = false;
            }
        }

        private void txtStartHour_TextChanged(object sender, EventArgs e)
        {
            if (txtStartHour.TextLength == 0)
            {
                btnAdd.Enabled = false;
                txtAddedCompromise.Visible = false;
            }
        }

        private void txtEndHour_TextChanged(object sender, EventArgs e)
        {
            if (txtEndHour.TextLength == 0)
            {
                btnAdd.Enabled = false;
                txtAddedCompromise.Visible = false;
            }
        }
    }
}
