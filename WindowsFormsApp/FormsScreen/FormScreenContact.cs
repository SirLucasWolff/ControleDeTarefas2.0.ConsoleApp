using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormScreenContact : Form
    {
        public FormScreenContact()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddContacts formAdd = new FormAddContacts();
            formAdd.Visible = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormViewContacts viewContacts = new FormViewContacts();
            viewContacts.Visible = true;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormUpdateControls formUpdateControls = new FormUpdateControls();
            formUpdateControls.Visible = true;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormDeleteContacts formDeleteContacts = new FormDeleteContacts();
            formDeleteContacts.Visible = true;
            this.Close();
        }

        private void btnBackScreenContact_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        public void FormScreenContact_Load(object sender, EventArgs e)
        {

        }
    }
}
