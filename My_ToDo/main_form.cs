using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_ToDo
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
            today_lab.Text += DateTime.Now;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
                today_lab.Text = "Today: " + DateTime.Now;
           
        }

        private void Calendar_Click(object sender, EventArgs e)
        {
            calendarpanel.Visible = true;
        }
    }
}
