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
    public partial class InstructorHome : Form
    {
        Form Super;
        public InstructorHome(Form Super)
        {
            InitializeComponent();
            this.Super = Super;
            Utilites.InitForm(this, "Instructor Home");
        }

        private void InstructorHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Super.Show();
        }
    }
}
