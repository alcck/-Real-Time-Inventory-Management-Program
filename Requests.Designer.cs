namespace Real_Time_Inventory_Management_Program
{
    partial class Requests
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
            FacLabel = new Label();
            searchFaqBox = new TextBox();
            ReqLabel = new Label();
            dataGridReq = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridReq).BeginInit();
            SuspendLayout();
            // 
            // FacLabel
            // 
            FacLabel.AutoSize = true;
            FacLabel.Location = new Point(212, 18);
            FacLabel.Name = "FacLabel";
            FacLabel.Size = new Size(54, 15);
            FacLabel.TabIndex = 9;
            FacLabel.Text = "Factories";
            // 
            // searchFaqBox
            // 
            searchFaqBox.Location = new Point(272, 15);
            searchFaqBox.Name = "searchFaqBox";
            searchFaqBox.Size = new Size(238, 23);
            searchFaqBox.TabIndex = 11;
            searchFaqBox.TextChanged += searchFaqBox_TextChanged;
            // 
            // ReqLabel
            // 
            ReqLabel.AutoSize = true;
            ReqLabel.Location = new Point(12, 19);
            ReqLabel.Name = "ReqLabel";
            ReqLabel.Size = new Size(54, 15);
            ReqLabel.TabIndex = 10;
            ReqLabel.Text = "Requests";
            // 
            // dataGridReq
            // 
            dataGridReq.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridReq.Location = new Point(12, 59);
            dataGridReq.Name = "dataGridReq";
            dataGridReq.RowTemplate.Height = 25;
            dataGridReq.Size = new Size(733, 287);
            dataGridReq.TabIndex = 13;
            dataGridReq.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Requests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 358);
            Controls.Add(FacLabel);
            Controls.Add(searchFaqBox);
            Controls.Add(ReqLabel);
            Controls.Add(dataGridReq);
            Name = "Requests";
            Text = "Requests";
            ((System.ComponentModel.ISupportInitialize)dataGridReq).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FacLabel;
        private Button searchFaqBtn;
        private TextBox searchFaqBox;
        private Label ReqLabel;
        private DataGridView dataGridReq;
    }
}