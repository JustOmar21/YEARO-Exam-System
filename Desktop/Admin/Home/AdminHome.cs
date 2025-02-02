using Desktop.Admin.CourseTopicForm;
using Desktop.Admin.ExamQuestionsForm;
using Desktop.Admin.InstructorCourseForm;
using Desktop.Admin.StudentCourseForm;
using Desktop.Admin.StudentDepartmentForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class AdminHome : Form
    {
        Form Super;
        public AdminHome(Form Super)
        {
            InitializeComponent();
            this.Super = Super;
            Utilites.InitForm(this, $"Welcome Admin {Utilites.Person.Name}");
        }

        private void AdminHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Super.Show();
        }

        private void logOutBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void crsTopBTN_Click(object sender, EventArgs e)
        {
            CourseTopicForm form = new CourseTopicForm(this);
            form.Show();
            Hide();
        }

        private void examQuReport_Click(object sender, EventArgs e)
        {
            ExamQuestionForm form = new ExamQuestionForm(this);
            form.Show();
            Hide();
        }

        private void stdAnsBTN_Click(object sender, EventArgs e)
        {
            StudentAnswerForm form = new StudentAnswerForm(this);
            form.Show();
            Hide();
        }

        private void insCrsBTN_Click(object sender, EventArgs e)
        {
            InstructorCourseForm form = new InstructorCourseForm(this);
            form.Show();
            Hide();
        }

        private void stdGradeBTN_Click(object sender, EventArgs e)
        {
            StudentCourseForm form = new StudentCourseForm(this);
            form.Show();
            Hide();
        }

        private void stdDeptBTN_Click(object sender, EventArgs e)
        {
            StudentDepartmentForm form = new StudentDepartmentForm(this);
            form.Show();
            Hide();
        }
    }
}
