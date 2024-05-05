using ChurchSystem.Database;

namespace ChurchSystem.Dashboard_Forms.MembersFiles
{
    public partial class MembersMain : Form
    {
        private DatabaseConnection dbConnection;

        public MembersMain()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection("churchSystem.db");
        }

        private void MembersMain_Load(object sender, EventArgs e)
        {
            
            dbConnection.OpenConnection();

            
            dbConnection.LoadMembersIntoDataGridView(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void MembersMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            dbConnection.CloseConnection();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddMember add = new AddMember();
            add.ShowDialog();
        }
    }
}
