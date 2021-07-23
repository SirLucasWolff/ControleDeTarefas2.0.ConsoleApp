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
    public partial class FormViewTasks : Form
    {
        public FormViewTasks()
        {
            InitializeComponent();
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
            {
                advancedDataGridView1.Visible = true;
                advancedDataGridView2.Visible = false;
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

                advancedDataGridView2.DataSource = dt;

                advancedDataGridView2.Visible = true;
                advancedDataGridView1.Visible = false;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnViewBackScreenTask_Click(object sender, EventArgs e)
        {
            FormScreenTasks tasks = new FormScreenTasks();
            tasks.Visible = true;
            this.Close();
        }

        private void FormViewTasks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBTarefasDataSet.DBCompromise' table. You can move, or remove it, as needed.
            this.dBCompromiseTableAdapter.Fill(this.dBTarefasDataSet.DBCompromise);
            // TODO: This line of code loads data into the 'dBTarefasDataSet1.DBTask' table. You can move, or remove it, as needed.
            this.dBTaskTableAdapter1.Fill(this.dBTarefasDataSet1.DBTask);
            // TODO: This line of code loads data into the 'dBTarefasDataSet.DBTask' table. You can move, or remove it, as needed.
            this.dBTaskTableAdapter.Fill(this.dBTarefasDataSet.DBTask);
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            this.dBTaskBindingSource.Filter = this.advancedDataGridView1.FilterString;
        }

        private void dBTaskBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            txtCount.Text = String.Format("{0}:TASKS", this.dBTaskBindingSource.List.Count);
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            this.dBTaskBindingSource.Sort = this.advancedDataGridView1.SortString;
        }
    }
}
