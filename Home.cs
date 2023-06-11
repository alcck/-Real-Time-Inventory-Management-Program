using System.Data;
using System.Data.SqlClient;

namespace Real_Time_Inventory_Management_Program
{
    public partial class Home : Form
    {
        private string connectionString = "Data Source=DESKTOP-8E5K5O6\\MSSQLSERVER01;Initial Catalog=TIRSAN;Integrated Security=True;Pooling=False";
        public Home()
        {
            InitializeComponent();
            this.Load += Home_Load;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int selectedRowIndex = dataGridWarehouse.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridWarehouse.Rows[selectedRowIndex];
            int warehouseId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            // Pass the warehouseId to the Inventory form
            Inventory inventory = new Inventory(warehouseId);
            this.Hide();
            inventory.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Home_Load(object sender, EventArgs e)
        {
            // Specify the SQL query to retrieve data from the table
            string sqlQuery = "SELECT * FROM Warehouses";

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
                        dataGridWarehouse.DataSource = dataTableWH;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur
                MessageBox.Show(ex.Message);
            }
        }
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void searchWarehouseBtn_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=DESKTOP-8E5K5O6\\MSSQLSERVER01;Initial Catalog=TIRSAN;Integrated Security=True;Pooling=False";
            string query = "SELECT * FROM Warehouses WHERE columnName = @searchText";
            string searchText = searchWarehouseBox.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchText", searchText);
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridWarehouse.DataSource = dataTable;
                    connection.Close();
                }
            }
        }

        private void searchWarehouseBox_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-8E5K5O6\\MSSQLSERVER01;Initial Catalog=TIRSAN;Integrated Security=True;Pooling=False";
            string query = "SELECT * FROM Warehouses WHERE WarehouseName LIKE @searchText";
            string searchText = "%" + searchWarehouseBox.Text + "%";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchText", searchText);
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridWarehouse.DataSource = dataTable;
                    connection.Close();
                }
            }
        }

        private void criticalBtn_Click(object sender, EventArgs e)
        {
            // Get the selected warehouse ID from the grid view
            int selectedRowIndex = dataGridWarehouse.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridWarehouse.Rows[selectedRowIndex];
            int warehouseId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            string query = "SELECT COUNT(*) FROM Products WHERE WarehouseId = @warehouseId AND Quantity < @customLevel";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@warehouseId", warehouseId);
                    command.Parameters.AddWithValue("@customLevel", 10000);
                    connection.Open();

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Some stocks have reached critical levels. Please attend immediately.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("All stocks are above the critical level.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void Home_Load_1(object sender, EventArgs e)
        {

        }
    }


}

