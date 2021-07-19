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
    public partial class FormAddContacts : Form
    {
        public FormAddContacts()
        {
            InitializeComponent();
            txtAddedContact.Visible = false;
            btnAdd.Enabled = false;
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
        private string DBAddContact = string.Empty;
        List<String> GetValue = new List<String>();
        public string Value { get; private set; }
        public string Position { get; private set; }
        public string Firm { get; private set; }
        public MaskFormat Phone { get; set; }
        public string Email { get; private set; }
        public string NameTask { get; private set; }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBackScreenContact_Click(object sender, EventArgs e)
        {
            FormScreenContact formScreenContact = new FormScreenContact();
            formScreenContact.Visible = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
            {
                DBAddContact = @"INSERT INTO DBCONTACTS
                (
                    [Name],
                    [Email],
                    [Phone],
                    [Firm],
                    [Position]
                )
                VALUES 
                (
                    @Name,
                    @Email,
                    @Phone,
                    @Firm,
                    @Position
                )";

                Sql = new SqlConnection(Adress);
                SqlCommand command = new SqlCommand(DBAddContact, Sql);

                command.Parameters.AddWithValue("@Name", SqlDbType.Text).Value = txtName.Text;
                command.Parameters.AddWithValue("@Email", SqlDbType.Text).Value = txtEmail.Text;
                command.Parameters.AddWithValue("@Phone", SqlDbType.Int).Value = maskedPhone.Text;
                command.Parameters.AddWithValue("@Firm", SqlDbType.Text).Value = txtFirm.Text;
                command.Parameters.AddWithValue("@Position", SqlDbType.Text).Value = txtPosition.Text;

                Sql.Open();
                command.ExecuteNonQuery();
                Sql.Close();
            }
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
            {
                Name = txtName.Text;
                Email = txtEmail.Text;
                Phone = maskedPhone.TextMaskFormat;
                Firm = txtFirm.Text;
                Position = txtPosition.Text;

                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO DBCONTACTS 
                    (
                    [Name],
                    [Email],
                    [Phone],
                    [Firm],
                    [Position]
                    )
                    VALUES 
                    (
                    @Name,
                    @Email,
                    @Phone,
                    @Firm,
                    @Position
                    )";

                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Phone", Phone);
                    cmd.Parameters.AddWithValue("@Firm", Firm);
                    cmd.Parameters.AddWithValue("@Position", Position);

                    Object id = cmd.ExecuteScalar();
                    object Id = Convert.ToInt32(id);
                    sqliteConnection.Close();
                }
            }


                txtAddedContact.Visible = true;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.TextLength == 0)
            {
                btnAdd.Enabled = false;
                txtAddedContact.Visible = false;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.TextLength == 0)
            {
                btnAdd.Enabled = false;
                txtAddedContact.Visible = false;
            }
        }

        private void maskedPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (maskedPhone.TextLength == 0)
            {
                btnAdd.Enabled = false;
                txtAddedContact.Visible = false;
            }
        }

        private void txtFirm_TextChanged(object sender, EventArgs e)
        {
           if (txtFirm.TextLength == 0)
            {
                btnAdd.Enabled = false;
                txtAddedContact.Visible = false;
            }
        }

        private void txtPosition_TextChanged(object sender, EventArgs e)
        {
           if (txtName.TextLength>0)
            {
                if (txtEmail.TextLength>0)
                {
                    if (maskedPhone.TextLength>7)
                    {
                        if (txtFirm.TextLength>0)
                        {
                            if (txtPosition.TextLength>0)
                            {
                                btnAdd.Enabled = true;
                            }
                        }
                    }
                }
            }
            
           if (txtPosition.TextLength == 0)
            {
                btnAdd.Enabled = false;
                txtAddedContact.Visible = false;
            }

           
        }
    }
}
