using ChurchSystem.Database;
using System.Drawing;
using System.Windows.Forms;

namespace ChurchSystem.Dashboard_Forms.MembersFiles
{
    public partial class MembersMain : Form
    {
        private DatabaseConnection dbConnection;

        public MembersMain()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection("churchSystem.db");

            // Set the DataGridView's AutoSizeColumnsMode to Fill
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ScrollBars = ScrollBars.Vertical;

            // Set the row template's height to fill the available height
            dataGridView1.RowTemplate.Height = dataGridView1.ClientSize.Height / 10; // You can adjust the division factor as needed

            // Set spacing between rows
            dataGridView1.RowTemplate.DividerHeight = 10; // Set the spacing between rows

            // Customize column headers
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.BackColor = Color.Blue; // Change to blue color
            headerStyle.Font = new Font("Century Gothic", 15, FontStyle.Bold); // Set font size for column titles to 15
            headerStyle.Padding = new Padding(0, 20, 0, 20); // Set padding to make the height 2x of the row height
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Center-align the column titles
            dataGridView1.ColumnHeadersDefaultCellStyle = headerStyle;

            // Set font size for data below column titles to 11
            dataGridView1.DefaultCellStyle.Font = new Font("Yu Gothic", 11, FontStyle.Bold);

            // Center-align data in cells below column titles
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void MembersMain_Load(object sender, EventArgs e)
        {
            // Open the database connection
            dbConnection.OpenConnection();

            // Load data into the DataGridView
            dbConnection.LoadMembersIntoDataGridView(dataGridView1);
        }

        private void MembersMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close the database connection when the form is closing
            dbConnection.CloseConnection();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddMember add = new AddMember();
            add.ShowDialog();
        }
    }
}
