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
        public bool open_calendar = false;
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
            
            if (open_calendar == false)
            {
                // определение текущей даты
                string[] current_date = DateTime.Today.ToShortDateString().Split('.');

                // реализация текущей даты и месяца
                string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

                //отображение текущего месяца
                int current_month = Convert.ToInt16(current_date[1]) - 1;
                calendar_month.Text = current_date[2] + " " + months[current_month];

                //вычисление дней в месяце
                //int daysinmonth = DateTime.DaysInMonth(Convert.ToInt16(current_date[2]), Convert.ToInt16(current_date[1]));
                int daysinmonth = DateTime.DaysInMonth(2024, 4);

                for (int i = 0; i < 5; i++)
                {
                    calendargrid.Columns.Add($"{i + 1}", $"{i + 1}");
                }

                switch (daysinmonth)
                {
                    case 31:
                        calendargrid.Rows.Add(7);
                        break;
                    case 30:
                    case 29:
                    case 28:
                        calendargrid.Rows.Add(6);
                        break;
                }

                // заполнение оставшихся ячеек
                int start = 1;
                switch (daysinmonth)
                {
                    case 31:
                        for (int i = 0; i < 7; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                calendargrid.Rows[i].Cells[j].Value = start;
                                start++;
                                if (start == (daysinmonth + 1)) break;
                            }
                        }
                        break;
                    case 30:
                    case 29:
                    case 28:
                        for (int i = 0; i < 6; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                calendargrid.Rows[i].Cells[j].Value = start;
                                start++;
                                if (start == (daysinmonth + 1)) break;
                            }
                        }
                        break;
                }
                open_calendar = true;
            }
        }

    }
}
