namespace Real_Time_Inventory_Management_Program
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelWarehouse = new Label();
            seeProdBtn = new Button();
            searchWarehouseBox = new TextBox();
            dataGridWarehouse = new DataGridView();
            criticalBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridWarehouse).BeginInit();
            SuspendLayout();
            // 
            // labelWarehouse
            // 
            labelWarehouse.AutoSize = true;
            labelWarehouse.Location = new Point(156, 21);
            labelWarehouse.Name = "labelWarehouse";
            labelWarehouse.Size = new Size(71, 15);
            labelWarehouse.TabIndex = 0;
            labelWarehouse.Text = "Warehouses";
            labelWarehouse.Click += label1_Click;
            // 
            // seeProdBtn
            // 
            seeProdBtn.BackColor = SystemColors.ActiveCaption;
            seeProdBtn.Location = new Point(12, 67);
            seeProdBtn.Name = "seeProdBtn";
            seeProdBtn.Size = new Size(138, 42);
            seeProdBtn.TabIndex = 4;
            seeProdBtn.Text = "See Products";
            seeProdBtn.UseVisualStyleBackColor = false;
            seeProdBtn.Click += button1_Click;
            // 
            // searchWarehouseBox
            // 
            searchWarehouseBox.Location = new Point(273, 18);
            searchWarehouseBox.Name = "searchWarehouseBox";
            searchWarehouseBox.Size = new Size(265, 23);
            searchWarehouseBox.TabIndex = 2;
            searchWarehouseBox.TextChanged += searchWarehouseBox_TextChanged;
            // 
            // dataGridWarehouse
            // 
            dataGridWarehouse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridWarehouse.Location = new Point(156, 67);
            dataGridWarehouse.Name = "dataGridWarehouse";
            dataGridWarehouse.RowTemplate.Height = 25;
            dataGridWarehouse.Size = new Size(589, 279);
            dataGridWarehouse.TabIndex = 5;
            dataGridWarehouse.CellContentClick += dataGridView1_CellContentClick;
            // 
            // criticalBtn
            // 
            criticalBtn.BackColor = SystemColors.ActiveCaption;
            criticalBtn.Location = new Point(12, 115);
            criticalBtn.Name = "criticalBtn";
            criticalBtn.Size = new Size(138, 231);
            criticalBtn.TabIndex = 6;
            criticalBtn.Text = "Check if Any Below Critical";
            criticalBtn.UseVisualStyleBackColor = false;
            criticalBtn.Click += criticalBtn_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 358);
            Controls.Add(criticalBtn);
            Controls.Add(searchWarehouseBox);
            Controls.Add(dataGridWarehouse);
            Controls.Add(seeProdBtn);
            Controls.Add(labelWarehouse);
            Name = "Home";
            Text = "TIRSAN Inventory Management";
            Load += Home_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridWarehouse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWarehouse;
        private Button seeProdBtn;
        private TextBox searchWarehouseBox;
        private Button searchWarehouseBtn;
        private DataGridView dataGridWarehouse;
        private Button criticalBtn;
    }
}