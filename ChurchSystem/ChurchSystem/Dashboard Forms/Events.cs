using ChurchSystem.Dashboard_Forms.Members;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChurchSystem.Dashboard_Forms
{
    public partial class Events : Form
    {
 
        private const int rows = 5; 
        private const int columns = 7; 
        private Guna2Panel[,] calendarCells; 

        public Events()
        {
            InitializeComponent();
            InitializeCalendar();
        }

        private void InitializeCalendar()
        {
            int cellWidth = guna2Panel1.Width / columns;
            int cellHeight = guna2Panel1.Height / rows;
         

            calendarCells = new Guna2Panel[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Guna2Panel cell = new Guna2Panel();
                    cell.Size = new Size(cellWidth, cellHeight);
                    cell.Location = new Point(j * cellWidth, i * cellHeight);
                    cell.BorderThickness = 1; 
                    cell.BorderColor = Color.Gray; 
                    cell.BorderStyle = (System.Drawing.Drawing2D.DashStyle)BorderStyle.FixedSingle; 
                    cell.Click += Cell_Click;

            
                    guna2Panel1.Controls.Add(cell);
                    calendarCells[i, j] = cell;
                }
            }
        }

            private void Cell_Click(object sender, EventArgs e)
            {
                
                Guna2Panel clickedCell = (Guna2Panel)sender;
                
            }
        }
        
    }
