namespace Real_Time_Inventory_Management_Program
{
    partial class Inventory
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
            searchProductsBox = new TextBox();
            prodLabel = new Label();
            dataGridProd = new DataGridView();
            reqBtn = new Button();
            goBackBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridProd).BeginInit();
            SuspendLayout();
            // 
            // searchProductsBox
            // 
            searchProductsBox.Location = new Point(72, 16);
            searchProductsBox.Name = "searchProductsBox";
            searchProductsBox.Size = new Size(238, 23);
            searchProductsBox.TabIndex = 1;
            searchProductsBox.TextChanged += searchProductsBox_TextChanged;
            // 
            // prodLabel
            // 
            prodLabel.AutoSize = true;
            prodLabel.Location = new Point(12, 19);
            prodLabel.Name = "prodLabel";
            prodLabel.Size = new Size(54, 15);
            prodLabel.TabIndex = 0;
            prodLabel.Text = "Products";
            // 
            // dataGridProd
            // 
            dataGridProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProd.Location = new Point(156, 64);
            dataGridProd.Name = "dataGridProd";
            dataGridProd.RowTemplate.Height = 25;
            dataGridProd.Size = new Size(589, 282);
            dataGridProd.TabIndex = 5;
            dataGridProd.CellContentClick += dataGridView2_CellContentClick;
            // 
            // reqBtn
            // 
            reqBtn.BackColor = SystemColors.ActiveCaption;
            reqBtn.Location = new Point(12, 64);
            reqBtn.Name = "reqBtn";
            reqBtn.Size = new Size(138, 42);
            reqBtn.TabIndex = 4;
            reqBtn.Text = "See Requests";
            reqBtn.UseVisualStyleBackColor = false;
            reqBtn.Click += seeRequests_Click;
            // 
            // goBackBtn
            // 
            goBackBtn.BackColor = SystemColors.ActiveCaption;
            goBackBtn.Location = new Point(659, 12);
            goBackBtn.Name = "goBackBtn";
            goBackBtn.Size = new Size(87, 29);
            goBackBtn.TabIndex = 9;
            goBackBtn.Text = "Go Back";
            goBackBtn.UseVisualStyleBackColor = false;
            goBackBtn.Click += goBackBtn_Click;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 358);
            Controls.Add(goBackBtn);
            Controls.Add(reqBtn);
            Controls.Add(searchProductsBox);
            Controls.Add(prodLabel);
            Controls.Add(dataGridProd);
            Name = "Inventory";
            Text = "TIRSAN Inventory Management";
            ((System.ComponentModel.ISupportInitialize)dataGridProd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchProductsBtn;
        private TextBox searchProductsBox;
        private Label prodLabel;
        private DataGridView dataGridProd;
        private Button reqBtn;
        private Button button5;
        private Button goBackBtn;
    }
}