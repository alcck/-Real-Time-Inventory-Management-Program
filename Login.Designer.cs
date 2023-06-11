namespace Real_Time_Inventory_Management_Program
{
    partial class Login
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
            loginBtn = new Button();
            emailLabel = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            PasswordLabel = new Label();
            titleLabel = new Label();
            SuspendLayout();
            // 
            // loginBtn
            // 
            loginBtn.BackColor = SystemColors.ActiveCaption;
            loginBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.Location = new Point(202, 240);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(239, 61);
            loginBtn.TabIndex = 3;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(102, 124);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(36, 15);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(184, 121);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(292, 23);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += email_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(184, 161);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(292, 23);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += password_TextChanged;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(102, 164);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(57, 15);
            PasswordLabel.TabIndex = 0;
            PasswordLabel.Text = "Password";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(37, 35);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(546, 37);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "TIRSAN Inventory Management Program";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 354);
            Controls.Add(titleLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(emailLabel);
            Controls.Add(loginBtn);
            Name = "Login";
            Text = "TIRSAN Inventory Management";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginBtn;
        private Label emailLabel;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label PasswordLabel;
        private Label titleLabel;
    }
}