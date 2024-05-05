using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChurchSystem.Dashboard_Forms.MembersFiles
{
    public partial class MembersMain : Form
    {
        public MembersMain()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddMember add = new AddMember();
            add.ShowDialog();
        }

        private void MembersMain_Load(object sender, EventArgs e)
        {

        }
    }
}