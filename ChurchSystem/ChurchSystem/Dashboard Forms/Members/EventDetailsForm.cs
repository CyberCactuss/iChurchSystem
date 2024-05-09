using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChurchSystem.Dashboard_Forms.Members
{
    public partial class EventDetailsForm : Form
    {
        private DateTime selectedDate;
        public EventDetailsForm(DateTime date)
        {
            InitializeComponent();
            selectedDate = date;
        }

        private void EventDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
