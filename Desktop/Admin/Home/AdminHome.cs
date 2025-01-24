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
            Utilites.InitForm(this, "Admin Home");
        }

        private void AdminHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Super.Show();
        }
    }
}
