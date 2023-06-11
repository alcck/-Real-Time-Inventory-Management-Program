using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Real_Time_Inventory_Management_Program
{
    public partial class Requests : Form
    {
        private string connectionString = "Data Source=DESKTOP-8E5K5O6\\MSSQLSERVER01;Initial Catalog=TIRSAN;Integrated Security=True;Pooling=False";
        public int ProductId { get; set; }
        private DataTable dataTableWH;


        public Requests()
        {
            InitializeComponent();
            this.Load += Requests_Load;
            dataTableWH = new DataTable();
        }
        private void Requests_Load(object sender, EventArgs e)
        {
            // Specify the SQL query to retrieve data from the table
            string sqlQuery = "SELECT * FROM Requests";

            // Create a DataTable object to hold the data
            DataTable dataTableWH = new DataTable();

            try
            {
                // Open the connection
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Create a SqlDataAdapter object and use it to fill the DataTable object
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, conn))
                    {
                        dataAdapter.Fill(dataTableWH);

                        // Bind the DataTable object to the DataGridView control
                        dataGridReq.DataSource = dataTableWH;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchFaqBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchFaqBox.Text;

            if (!string.IsNullOrEmpty(searchText))
            {
                DataTable filteredTable = dataTableWH.Clone(); // Create a clone of the dataTableWH schema

                foreach (DataRow row in dataTableWH.Rows)
                {
                    if (row.Field<string>("ColumnName").Contains(searchText))
                    {
                        filteredTable.ImportRow(row);
                    }
                }

                dataGridReq.DataSource = filteredTable;
            }
            else
            {
                dataGridReq.DataSource = dataTableWH;
            }
        }

        private void searchFaqBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-8E5K5O6\\MSSQLSERVER01;Initial Catalog=TIRSAN;Integrated Security=True;Pooling=False";
            string query = "SELECT * FROM yourTable WHERE columnName = @searchText";
            string searchText = searchFaqBox.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchText", searchText);
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridReq.DataSource = dataTable;
                    connection.Close();
                }
            }
        }
    }
}
