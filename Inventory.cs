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
    public partial class Inventory : Form
    {
        private string connectionString = "Data Source=DESKTOP-8E5K5O6\\MSSQLSERVER01;Initial Catalog=TIRSAN;Integrated Security=True;Pooling=False";
        bool buttonClick = false;
        private int warehouseId;

        public Inventory(int warehouseId)
        {
            InitializeComponent();
            this.warehouseId = warehouseId;
            this.Load += Inventory_Load;
        }

        public void seeRequests_Click(object sender, EventArgs e)
        {
            // Get the selected product from the dataGridProd
            if (dataGridProd.SelectedRows.Count > 0)
            {
                // Retrieve the Products Id from the selected row
                int productId = Convert.ToInt32(dataGridProd.SelectedRows[0].Cells["Id"].Value);

                // Create an instance of the Requests form
                Requests requestsForm = new Requests();

                // Pass the productId to the Requests form
                requestsForm.ProductId = productId;

                // Show the Requests form
                requestsForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Inventory_Load(object sender, EventArgs e)
        {
            // Specify the SQL query to retrieve data from the table
            string sqlQuery = "SELECT * FROM Products WHERE WarehouseId = @warehouseId";




            // Open the connection
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                {
                    command.Parameters.AddWithValue("@warehouseId", warehouseId);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTableWH = new DataTable();
                    dataAdapter.Fill(dataTableWH);
                    dataGridProd.DataSource = dataTableWH;
                }
            }

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void searchProductsBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-8E5K5O6\\MSSQLSERVER01;Initial Catalog=TIRSAN;Integrated Security=True;Pooling=False";
            string query = "SELECT * FROM yourTable WHERE columnName = @searchText";
            string searchText = searchProductsBox.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchText", searchText);
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridProd.DataSource = dataTable;
                    connection.Close();
                }
            }
        }

        private void searchProductsBox_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-8E5K5O6\\MSSQLSERVER01;Initial Catalog=TIRSAN;Integrated Security=True;Pooling=False";
            string query = "SELECT * FROM Products WHERE ProductName LIKE @searchText";
            string searchText = "%" + searchProductsBox.Text + "%";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchText", searchText);
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridProd.DataSource = dataTable;
                    connection.Close();
                }
            }
        }
    }
}
