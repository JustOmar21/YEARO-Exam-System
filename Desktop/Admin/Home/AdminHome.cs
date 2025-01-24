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
        Form Parent;
        public AdminHome(Form Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }

        private void AdminHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Show();
        }
    }
}
