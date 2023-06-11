using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Real_Time_Inventory_Management_Program
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text;
                string password = txtPassword.Text;

                string connectionString = "Data Source=DESKTOP-8E5K5O6\\MSSQLSERVER01;Initial Catalog=TIRSAN;Integrated Security=True;Pooling=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string query = ("SELECT Id FROM Users WHERE Email=@email AND Password=@password");
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    // Login successful
                    MessageBox.Show("Welcome to the system!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Home home = new Home();
                    this.Hide();
                    home.Show();
                }
                else
                {
                    // Login failed
                    MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
