using Desktop.Data;
using Desktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Admin.CourseTopicForm
{
    public partial class CourseTopicForm : Form
    {
        Form super;
        ExamContext context = new();
        public CourseTopicForm(Form super)
        {
            InitializeComponent();
            this.super = super;
            Utilites.InitForm(this, "Course and Topics Reports");
            courseLIST.DisplayMember = "Name";
            courseLIST.ValueMember = "ID";
            courseLIST.DataSource = context.Courses.ToList();
            idTXT.BackColor = nameTXT.BackColor = UIConfig.SecondaryColorDark;
        }

        private void CourseTopicForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            super.Show();
        }

        private void FillTable()
        {
            var topics = context.Topics.Where(top => top.CrsID == (int)courseLIST.SelectedValue);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name");
            foreach (var topic in topics)
            {
                dt.Rows.Add(topic.ID, topic.Name);
            }
            topicDATA.DataSource = dt;
            topicDATA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            topicDATA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            topicDATA.AllowUserToAddRows = false;
        }

        private void showBTN_Click(object sender, EventArgs e)
        {
            FillTable();
        }

        private void topicDATA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                var dataGrid = sender as DataGridView;
                idTXT.Text = $"{dataGrid.Rows[e.RowIndex].Cells[0].Value}";
                nameTXT.Text = $"{dataGrid.Rows[e.RowIndex].Cells[1].Value}";
            }
        }

        private void idTXT_MouseDown(object sender, MouseEventArgs e)
        {
            idLBL.Focus();
        }

        private void returnBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
