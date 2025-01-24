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
            Utilites.InitForm(this, "Login");

            // Header
            Header.Font = UIConfig.HeaderFont;
            Header.ForeColor = UIConfig.TextColor;

            // User TextBox
            userTXT.PlaceholderText = "e.g Omar@example.com";
            userTXT.Text = "";
            userLBL.Font = UIConfig.BodyFont;

            // Password TextBox
            passTXT.PlaceholderText = "e.g ********* :-)";
            passTXT.Text = "";
            passLBL.Font = UIConfig.BodyFont;

            // Login Button
            logBTN.BackColor = Color.Blue;
            logBTN.ForeColor = UIConfig.SecondaryColorLight;

            // Warning Label
            warningLBL.ForeColor = UIConfig.ErrorColor;
            warningLBL.Hide();
        }

        private void logBTN_Click(object sender, EventArgs e)
        {
            var user = userTXT.Text;
            var pass = passTXT.Text;

            Utilites.Person = context.People.SingleOrDefault(p=>p.Email == user && p.Password == pass);
            if (Utilites.Person != null)
            {
                warningLBL.Hide();
                if(Utilites.Person.Role == "Admin")
                {
                    AdminHome adminHome = new AdminHome(this);
                    adminHome.Show();
                    Hide();
                }
                else if(Utilites.Person.Role == "Student")
                {
                    StudentHome studentHome = new StudentHome(this);
                    studentHome.Show();
                    Hide();
                }
                else if( Utilites.Person.Role == "Instructor")
                {
                    InstructorHome instructorHome = new InstructorHome(this);
                    instructorHome.Show();
                    Hide();
                }
                else
                {
                    warningLBL.Show();
                    warningLBL.Text = "This Person has a role that doesn't have a homepage";
                }
                
            }
            else
            {
                warningLBL.Show();
            }
            userTXT.Text = "";
            passTXT.Text = "";
        }

        private void logBTN_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.RoyalBlue;
        }

        private void logBTN_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.Blue;
        }
    }
}
