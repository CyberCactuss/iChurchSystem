using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchSystem.Database
{
    internal class DatabaseConnection
    {

        private string? connectionString;
        private SQLiteConnection connection;

        public DatabaseConnection(string dbFileName)
        {
            string directory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            if (!string.IsNullOrEmpty(directory))
            {              
                string dbFilePath = Path.Combine(directory, dbFileName);

                
                connectionString = $"Data Source={dbFilePath};Version=3;";

                
                connection = new SQLiteConnection(connectionString);
            }
            else
            {
                
                throw new Exception("Unable to determine the directory path of the executable.");
            }
        }

        public void OpenConnection()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Database connection opened.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening database connection: {ex.Message}");
            }
        }

        public void CloseConnection()
        {
            try
            {
                connection.Close();
                Console.WriteLine("Database connection closed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error closing database connection: {ex.Message}");
            }
        }

        public bool CheckCredentials(string username, string password)
        {
            
            bool isValid = false;

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Admin WHERE Username = @Username AND Password = @Password";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        isValid = count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error checking credentials: {ex.Message}");
            }

            return isValid;
        }

    }

}

