using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormViewContacts : Form
    {
        public FormViewContacts()
        {
            InitializeComponent();
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
            {
                advancedDataGridView2.Visible = false;
            }
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
            {
                advancedDataGridView1.Visible = false;
                SQLiteConnection con = new SQLiteConnection(@"data source=C:\Users\lucas\source\repos\ControleDeTarefas2.0.ConsoleApp\ControleDeTarefas2.0.ConsoleApp\bin\DataBase\bancoDedados.db");
                con.Open();
                string query = "SELECT * FROM DBCONTACTS";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);

                advancedDataGridView2.DataSource = dt;
            }
        }

        private void btnViewBackScreenContact_Click(object sender, EventArgs e)
        {
            FormScreenContact contact = new FormScreenContact();
            contact.Visible = true;
            this.Close();
        }

        private void FormViewContacts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBTarefasDataSet.DBContacts' table. You can move, or remove it, as needed.
            this.dBContactsTableAdapter.Fill(this.dBTarefasDataSet.DBContacts);

        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            this.dBContactsBindingSource.Filter = this.advancedDataGridView1.FilterString;
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            this.dBContactsBindingSource.Sort = this.advancedDataGridView1.SortString;
        }

        private void dBContactsBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            txtCountContacts.Text = String.Format("{0}:CONTACTS", this.dBContactsBindingSource.List.Count);
        }
    }
}
