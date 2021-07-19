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
    public partial class FormViewCompromises : Form
    {
        public FormViewCompromises()
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
                string query = "SELECT * FROM DBCOMPROMISE";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);

                advancedDataGridView2.DataSource = dt;

            }
        }

        private void btnViewBackScreenCompromise_Click(object sender, EventArgs e)
        {
            FormScreenCompromise compromise = new FormScreenCompromise();
            compromise.Visible = true;
            this.Close();
        }

        private void FormViewCompromises_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBTarefasDataSet1.DBCompromise' table. You can move, or remove it, as needed.
            this.dBCompromiseTableAdapter1.Fill(this.dBTarefasDataSet1.DBCompromise);
            // TODO: This line of code loads data into the 'dBTarefasDataSet.DBCompromise' table. You can move, or remove it, as needed.
            this.dBCompromiseTableAdapter.Fill(this.dBTarefasDataSet.DBCompromise);

        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            this.dBCompromiseBindingSource4.Filter = this.advancedDataGridView1.FilterString;
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            this.dBCompromiseBindingSource4.Sort = this.advancedDataGridView1.SortString;
        }

        private void dBCompromiseBindingSource4_CurrentChanged(object sender, EventArgs e)
        {
            txtCompromises.Text = String.Format("{0}:COMPROMISES", this.dBCompromiseBindingSource4.List.Count);
        }
    }
}
