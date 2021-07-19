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
    public partial class FormScreenTasks : Form
    {
        public FormScreenTasks()
        {
            InitializeComponent();
        }

        private void btnBackScreenTask_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddTasks formAddTasks = new FormAddTasks();
            formAddTasks.Visible = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormViewTasks formViewTasks = new FormViewTasks();
            formViewTasks.Visible = true;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormUpdateTasks formUpdateTasks = new FormUpdateTasks();
            formUpdateTasks.Visible = true;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormDeleteTasks formDeleteTasks = new FormDeleteTasks();
            formDeleteTasks.Visible = true;
            this.Close();
        }
    }
}
