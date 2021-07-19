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
    public partial class FormScreenCompromise : Form
    {
        public FormScreenCompromise()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddCompromises formAddCompromises = new FormAddCompromises();
            formAddCompromises.Visible = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormViewCompromises formViewCompromises = new FormViewCompromises();
            formViewCompromises.Visible = true;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormUpdateCompromises formUpdateCompromises = new FormUpdateCompromises();
            formUpdateCompromises.Visible = true;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormDeleteCompromises formDeleteCompromises = new FormDeleteCompromises();
            formDeleteCompromises.Visible = true;
            this.Close();
        }

        private void btnBackScreenCompromise_Click(object sender, EventArgs e)
        {
            FormScreenStart formScreenStart = new FormScreenStart();
            formScreenStart.Visible = true;
            this.Close();
        }
    }
}
