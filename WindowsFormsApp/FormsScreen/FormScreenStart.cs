using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormScreenStart : Form
    {
        public FormScreenStart()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
           
            FormScreenContact formScreenContact = new FormScreenContact();
            formScreenContact.Visible = true;
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            FormScreenTasks formConact = new FormScreenTasks();
            formConact.Visible = true;
        }

        private void btnCompromises_Click(object sender, EventArgs e)
        {
            FormScreenCompromise formScreenCompromise = new FormScreenCompromise();
            formScreenCompromise.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlServer")
            {
                MessageBox.Show("SqlServer: Selected");
            }
            if (ConfigurationManager.AppSettings["DBSelected"] == "SqlLite")
            {
                MessageBox.Show("SqLite: Selected");
            }
        }
    }
}
