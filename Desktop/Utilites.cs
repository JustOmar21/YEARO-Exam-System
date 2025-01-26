using Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Desktop
{
    static class Utilites
    {
        public static Person? Person;

        public static void InitForm(Form form , string name)
        {
            form.Text = name;
            form.BackColor = UIConfig.SecondaryColorDark;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.WindowState = FormWindowState.Maximized;
        }
    }
}
