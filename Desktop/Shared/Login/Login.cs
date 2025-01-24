using Desktop.Data;
using Microsoft.EntityFrameworkCore;
namespace Desktop
{
    public partial class Login : Form
    {
        readonly ExamContext context = new();
        public Login()
        {
            InitializeComponent();
            Text = "Login";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome(this);
            Hide();
            adminHome.Show();
        }
    }
}
