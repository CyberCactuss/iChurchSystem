using ChurchSystem.Dashboard_Forms.Members;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ChurchSystem.Dashboard_Forms
{
    public partial class Events : Form
    {
        private int month;
        private int year;

        public Events()
        {
            InitializeComponent();
            month = DateTime.Now.Month;
            year = DateTime.Now.Year;
            SetMonthYearLabel();
            btnnext.Click += btnNext_Click; 
            btnprevious.Click += btnPrevious_Click; 
           
        }

        private void SetMonthYearLabel()
        {
          
            textBox1.Text = $"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month)} {year}";
            PopulateDays();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
       
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }
            SetMonthYearLabel();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
         
            month--;
            if (month < 1)
            {
                month = 12;
                year--;
            }
            SetMonthYearLabel();
        }

        private void PopulateDays()
        {
           
            flowLayoutPanel1.Controls.Clear();
            DateTime firstDayOfMonth = new DateTime(year, month, 1);
           int startingDayOffset = (int)firstDayOfMonth.DayOfWeek; 

            int daysInMonth = DateTime.DaysInMonth(year, month);
            DateTime nextMonth = firstDayOfMonth.AddMonths(1);
            int daysInNextMonth = DateTime.DaysInMonth(nextMonth.Year, nextMonth.Month);


            DateTime previousMonth = firstDayOfMonth.AddMonths(-1);
            int daysInPreviousMonth = DateTime.DaysInMonth(previousMonth.Year, previousMonth.Month);

 
            for (int day = 1; day <= 42; day++) 
            {
                Button button1 = new Button();
                button1.Size = new Size(124, 90);

                if (day <= startingDayOffset)
                {
                   
                    button1.Text = (daysInPreviousMonth - startingDayOffset + day).ToString();
                    button1.Enabled = false;
                    button1.BackColor = Color.LightGray;
                    button1.Font = new System.Drawing.Font("Helvetica", 15, FontStyle.Regular);
                    button1.ForeColor = Color.Gray;
                }
                else if (day > daysInMonth + startingDayOffset)
                {
                  
                    button1.Text = (day - (daysInMonth + startingDayOffset)).ToString();
                    button1.Enabled = false;
                    button1.BackColor = Color.LightGray;
                    button1.Font = new System.Drawing.Font("Helvetica", 15, FontStyle.Regular);
                    button1.ForeColor = Color.Gray;
                }
                else
                {
                    
                    int currentDay = day - startingDayOffset;
                    button1.Text = currentDay.ToString();
                    button1.Click += (sender, e) =>
                    {
                        
                        DateTime selectedDate = new DateTime(year, month, currentDay);
                        EventDetailsForm eventDetailsForm = new EventDetailsForm(selectedDate);
                        eventDetailsForm.ShowDialog();
                    };
                    button1.BackColor = Color.White;
                    button1.FlatAppearance.BorderColor = Color.Black; 
                    button1.FlatAppearance.BorderSize = 1; 

                    button1.Font = new System.Drawing.Font("Helvetica", 15, FontStyle.Regular);
                }

               
                button1.TextAlign = ContentAlignment.MiddleCenter;

                flowLayoutPanel1.Controls.Add(button1);
            }
        }


    }
}
